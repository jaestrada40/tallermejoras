using Biblioteca.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormPrestamos : Form
    {
        private BindingList<Prestamo> prestamos = new BindingList<Prestamo>();

        public FormPrestamos()
        {
            InitializeComponent();
            CargarDatos();
        }

        // Configura el formulario con datos iniciales
        private void CargarDatos()
        {
            // Cargar libros y miembros en los ComboBoxes
            CargarLibros();
            CargarMiembros();
            txtBuscar.TextChanged += txtBuscar_TextChanged;
        }

        private void CargarLibros()
        {
            // Cargar libros en el ComboBox
            comboBoxLibros.Items.Clear();
            foreach (var libro in DataStore.Libros)
            {
                comboBoxLibros.Items.Add(libro);
            }
            comboBoxLibros.DisplayMember = "Titulo";
        }

        private void CargarMiembros()
        {
            // Cargar miembros en el ComboBox
            comboBoxMiembros.Items.Clear();
            foreach (var miembro in DataStore.Miembros)
            {
                comboBoxMiembros.Items.Add(miembro);
            }
            comboBoxMiembros.DisplayMember = "Nombre";
        }

        private void btnRealizarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                Libro libroSeleccionado = comboBoxLibros.SelectedItem as Libro;
                Miembro miembroSeleccionado = comboBoxMiembros.SelectedItem as Miembro;

                if (libroSeleccionado == null || miembroSeleccionado == null)
                {
                    MessageBox.Show("Por favor, seleccione un libro y un miembro.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Prestamo prestamo = new Prestamo(libroSeleccionado, miembroSeleccionado, DateTime.Now);
                prestamo.RealizarPrestamo();

                prestamos.Add(prestamo); // Agregar a la lista de préstamos

                DataStore.Prestamos.Add(prestamo); // Actualizar en DataStore si es necesario

                // Crear y agregar la tarjeta al FlowLayoutPanel
                CrearTarjetaPrestamo(prestamo);

                MessageBox.Show("El préstamo se ha realizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos después de realizar el préstamo
                comboBoxLibros.SelectedItem = null; 
                comboBoxMiembros.SelectedItem = null; 
                txtBuscar.Clear();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Eliminar el código de devolución relacionado con el DataGridView
        private void btnDevolverLibro_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para devolver un libro, utilice el botón 'Devolver' en la tarjeta correspondiente.");
        }

        private void FormPrestamos_Load(object sender, EventArgs e)
        {

        }

        private void CrearTarjetaPrestamo(Prestamo prestamo)
        {
            // Crear un panel para la tarjeta
            Panel panelTarjeta = new Panel
            {
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10),
                Margin = new Padding(10),
                BackColor = Color.LightGray,
                Size = new Size(200, 150) // Tamaño de la tarjeta
            };

            // Mostrar información del préstamo
            Label lblInfo = new Label
            {
                Text = $"Libro: {prestamo.LibroPrestado.Titulo}\n" +
                       $"Miembro: {prestamo.Miembro.Nombre}\n" +
                       $"Fecha: {prestamo.FechaPrestamo.ToShortDateString()}",
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Regular),
                Padding = new Padding(5)
            };

            // Botón para devolver el libro
            Button btnDevolver = new Button
            {
                Text = "Devolver",
                AutoSize = true,
                Location = new Point(10, 100) // Posición del botón
            };
            btnDevolver.Click += (sender, e) =>
            {
                DialogResult resultado = MessageBox.Show($"¿Estás seguro de devolver el libro '{prestamo.LibroPrestado.Titulo}'?", "Devolver libro", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    prestamo.DevolverLibro();
                    // Opcional: Puedes actualizar la interfaz para reflejar la devolución, como eliminando o actualizando la tarjeta.
                    flowLayoutPanelPrestamos.Controls.Remove(panelTarjeta);
                    MessageBox.Show("El libro ha sido devuelto correctamente.");
                }
            };

            // Agregar los controles al panel de la tarjeta
            panelTarjeta.Controls.Add(lblInfo);
            panelTarjeta.Controls.Add(btnDevolver);

            // Agregar la tarjeta al FlowLayoutPanel
            flowLayoutPanelPrestamos.Controls.Add(panelTarjeta);
        }

        private void FiltrarPrestamos(string textoBusqueda)
{
    flowLayoutPanelPrestamos.Controls.Clear(); // Limpiar las tarjetas existentes
    
    // Filtrar los préstamos según el texto de búsqueda
    var prestamosFiltrados = prestamos.Where(prestamo =>
        prestamo.LibroPrestado.Titulo.Contains(textoBusqueda, StringComparison.OrdinalIgnoreCase) ||
        prestamo.Miembro.Nombre.Contains(textoBusqueda, StringComparison.OrdinalIgnoreCase)
    );

    // Crear y agregar las tarjetas filtradas al FlowLayoutPanel
    foreach (var prestamo in prestamosFiltrados)
    {
        CrearTarjetaPrestamo(prestamo);
    }
}


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            FiltrarPrestamos(txtBuscar.Text);
        }
    }
}
