using Biblioteca.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormLibros : Form
    {
        private List<Libro> libros = new List<Libro>();
        private int indiceEdicion = -1;
        private bool modoEdicion = false;

        public FormLibros()
        {
            InitializeComponent();
            ActualizarListaLibros();
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
        }

        private void FormLibros_Load(object sender, EventArgs e) { }

        // Botón Agregar
        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    if (modoEdicion)
                    {
                        // Actualizar el libro seleccionado
                        Libro libroSeleccionado = DataStore.Libros[indiceEdicion];
                        ActualizarLibro(libroSeleccionado);
                        // Actualizar la lista de libros después de la edición
                        ActualizarListaLibros();
                        MessageBox.Show("Libro editado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        modoEdicion = false;
                        btnAgregar.Text = "Agregar";
                    }
                    else
                    {
                        // Agregar un nuevo libro
                        Libro nuevoLibro = CrearNuevoLibro();
                        DataStore.Libros.Add(nuevoLibro);
                        ActualizarListaLibros();
                        MessageBox.Show("Libro agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Por favor, completa todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Error en los formatos de datos. Verifica que los campos numéricos sean correctos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (indiceEdicion >= 0)
            {
                // Eliminar el libro de la lista
                DataStore.Libros.RemoveAt(indiceEdicion);
                ActualizarListaLibros();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Selecciona un libro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (indiceEdicion >= 0)
            {
                // Cargar datos del libro seleccionado
                var libroSeleccionado = DataStore.Libros[indiceEdicion];
                txtTitulo.Text = libroSeleccionado.Titulo;
                txtAutor.Text = libroSeleccionado.Autor;
                txtAnio.Text = libroSeleccionado.AnioPublicacion.ToString();

                if (libroSeleccionado is LibroFisico libroFisico)
                {
                    txtUbicacion.Text = libroFisico.Ubicacion;
                    rbFisico.Checked = true;
                }
                else if (libroSeleccionado is LibroElectronico libroElectronico)
                {
                    txtTamano.Text = libroElectronico.TamanoArchivo.ToString();
                    txtFormato.Text = libroElectronico.Formato;
                    rbElectronico.Checked = true;
                }

                // Configurar para edición
                modoEdicion = true;
                btnAgregar.Text = "Guardar";
            }
            else
            {
                MessageBox.Show("Selecciona un libro para cargar los datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Actualiza los datos del FlowLayoutPanel
        private void ActualizarListaLibros()
        {
            flowLayoutPanelLibros.Controls.Clear();
            string busqueda = txtBuscar.Text.ToLower();

            foreach (var libro in DataStore.Libros)
            {
                // Filtrar libros según el título o el autor
                if (libro.Titulo.ToLower().Contains(busqueda) || libro.Autor.ToLower().Contains(busqueda))
                {
                    Panel panelTarjeta = new Panel
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        Padding = new Padding(10),
                        Margin = new Padding(10),
                        BackColor = Color.LightGray,
                        Size = new Size(200, 150)
                    };

                    Label lblInfo = new Label
                    {
                        Text = $"{libro.Titulo}\nAutor: {libro.Autor}\nAño: {libro.AnioPublicacion}",
                        AutoSize = true,
                        Font = new Font("Arial", 10, FontStyle.Regular),
                        Padding = new Padding(5)
                    };

                    Button btnEditar = new Button
                    {
                        Text = "Editar",
                        AutoSize = true,
                        Location = new Point(10, 100)
                    };
                    btnEditar.Click += (sender, e) => EditarLibro(libro);

                    Button btnEliminar = new Button
                    {
                        Text = "Eliminar",
                        AutoSize = true,
                        Location = new Point(90, 100)
                    };
                    btnEliminar.Click += (s, e) =>
                    {
                        DialogResult resultado = MessageBox.Show($"¿Estás seguro de eliminar el libro '{libro.Titulo}'?", "Eliminar libro", MessageBoxButtons.YesNo);
                        if (resultado == DialogResult.Yes)
                        {
                            indiceEdicion = DataStore.Libros.IndexOf(libro);
                            btnEliminar_Click_1(s, e);
                        }
                    };

                    panelTarjeta.Controls.Add(lblInfo);
                    panelTarjeta.Controls.Add(btnEditar);
                    panelTarjeta.Controls.Add(btnEliminar);

                    flowLayoutPanelLibros.Controls.Add(panelTarjeta);
                }
            }
        }
        private void EditarLibro(Libro libro)
        {
            // Asegura que el índice de edición se asigna al índice correcto
            indiceEdicion = DataStore.Libros.IndexOf(libro);

            // Verifica que un libro fue encontrado
            if (indiceEdicion >= 0) 
            {
                // Rellenar los campos del formulario con los datos del libro
                txtTitulo.Text = libro.Titulo;
                txtAutor.Text = libro.Autor;
                txtAnio.Text = libro.AnioPublicacion.ToString();

                // Verifica si es un libro físico o electrónico
                if (libro is LibroFisico libroFisico)
                {
                    txtUbicacion.Text = libroFisico.Ubicacion;
                    rbFisico.Checked = true;
                }
                else if (libro is LibroElectronico libroElectronico)
                {
                    txtTamano.Text = libroElectronico.TamanoArchivo.ToString();
                    txtFormato.Text = libroElectronico.Formato;
                    rbElectronico.Checked = true;
                }

                // Cambiar el modo a edición
                modoEdicion = true;
                btnAgregar.Text = "Guardar Cambios";
            }
            else
            {
                MessageBox.Show("No se encontró el libro seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ActualizarLibro(Libro libro)
        {
            libro.Titulo = txtTitulo.Text;
            libro.Autor = txtAutor.Text;
            libro.AnioPublicacion = int.Parse(txtAnio.Text);

            if (libro is LibroFisico libroFisico)
            {
                libroFisico.Ubicacion = txtUbicacion.Text;
            }
            else if (libro is LibroElectronico libroElectronico)
            {
                libroElectronico.TamanoArchivo = double.Parse(txtTamano.Text);
                libroElectronico.Formato = txtFormato.Text;
            }
        }

        private Libro CrearNuevoLibro()
        {
            if (rbFisico.Checked)
            {
                return new LibroFisico(txtTitulo.Text, txtAutor.Text, int.Parse(txtAnio.Text), txtUbicacion.Text);
            }
            else
            {
                return new LibroElectronico(txtTitulo.Text, txtAutor.Text, int.Parse(txtAnio.Text), double.Parse(txtTamano.Text), txtFormato.Text);
            }
        }

        // Limpiar campos del formulario
        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnio.Clear();
            txtUbicacion.Clear();
            txtTamano.Clear();
            txtFormato.Clear();
            rbFisico.Checked = true;
            indiceEdicion = -1;
        }

        // Validar campos del formulario
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text) ||
                string.IsNullOrWhiteSpace(txtAnio.Text) ||
                (rbFisico.Checked && string.IsNullOrWhiteSpace(txtUbicacion.Text)) ||
                (rbElectronico.Checked && (string.IsNullOrWhiteSpace(txtTamano.Text) || string.IsNullOrWhiteSpace(txtFormato.Text))))
            {
                return false;
            }

            // Validar que el año de publicación sea un número
            if (!int.TryParse(txtAnio.Text, out _))
            {
                return false;
            }

            // Validar que el tamaño del archivo sea un número
            if (rbElectronico.Checked && !double.TryParse(txtTamano.Text, out _))
            {
                return false;
            }

            return true;
        }

        private void rbFisico_CheckedChanged(object sender, EventArgs e)
        {
            txtUbicacion.Enabled = rbFisico.Checked;
            txtTamano.Enabled = !rbFisico.Checked;
            txtFormato.Enabled = !rbFisico.Checked;
        }

        private void rbElectronico_CheckedChanged(object sender, EventArgs e)
        {
            txtUbicacion.Enabled = !rbElectronico.Checked;
            txtTamano.Enabled = rbElectronico.Checked;
            txtFormato.Enabled = rbElectronico.Checked;
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            ActualizarListaLibros ();
        }
    }
}
