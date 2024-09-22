using Biblioteca.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormMiembros : Form
    {
        private int indexMiembroEditado = -1;
        private bool modoEdicion = false;

        public FormMiembros()
        {
            InitializeComponent();
            txtNumeroMiembro.KeyPress += TxtNumeroMiembro_KeyPress;
            txtBuscar.TextChanged += TxtBuscar_TextChanged;
            ActualizarListaMiembros();
        }

        // Botón Agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    if (modoEdicion && indexMiembroEditado >= 0)
                    {
                        // Actualizar miembro existente
                        DataStore.Miembros[indexMiembroEditado].Nombre = txtNombre.Text;
                        DataStore.Miembros[indexMiembroEditado].NumeroMiembro = int.Parse(txtNumeroMiembro.Text);
                        ActualizarListaMiembros();
                        MessageBox.Show("Miembro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        modoEdicion = false;
                        indexMiembroEditado = -1;
                        btnGuardar.Text = "Agregar";
                    }
                    else
                    {
                        // Agregar nuevo miembro
                        Miembro miembro = new Miembro(txtNombre.Text, int.Parse(txtNumeroMiembro.Text));
                        DataStore.Miembros.Add(miembro);
                        ActualizarListaMiembros();
                        MessageBox.Show("Miembro agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Error en los formatos de datos. Verifica que el número de miembro sea correcto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Botón Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (indexMiembroEditado >= 0)
            {
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este miembro?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    DataStore.Miembros.RemoveAt(indexMiembroEditado);
                    ActualizarListaMiembros();
                    LimpiarCampos();
                    MessageBox.Show("Miembro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un miembro para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Actualizar lista de miembros en el FlowLayoutPanel
        private void ActualizarListaMiembros()
        {
            flowLayoutPanelMiembros.Controls.Clear(); // Limpiar el FlowLayoutPanel
            string busqueda = txtBuscar.Text.ToLower(); // Obtener el texto de búsqueda en minúsculas

            foreach (var miembro in DataStore.Miembros)
            {
                // Filtrar miembros según el nombre o número
                if (miembro.Nombre.ToLower().Contains(busqueda) ||
                    miembro.NumeroMiembro.ToString().Contains(busqueda))
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
                        Text = $"{miembro.Nombre} \nNúmero: {miembro.NumeroMiembro}",
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
                    btnEditar.Click += (sender, e) => EditarMiembro(miembro);

                    Button btnEliminar = new Button
                    {
                        Text = "Eliminar",
                        AutoSize = true,
                        Location = new Point(90, 100)
                    };
                    btnEliminar.Click += (sender, e) =>
                    {
                        DialogResult resultado = MessageBox.Show($"¿Estás seguro de eliminar a {miembro.Nombre}?", "Eliminar miembro", MessageBoxButtons.YesNo);
                        if (resultado == DialogResult.Yes)
                        {
                            EliminarMiembro(miembro);
                        }
                    };

                    panelTarjeta.Controls.Add(lblInfo);
                    panelTarjeta.Controls.Add(btnEditar);
                    panelTarjeta.Controls.Add(btnEliminar);

                    flowLayoutPanelMiembros.Controls.Add(panelTarjeta);
                }
            }
        }

        private void EditarMiembro(Miembro miembro)
        {
            txtNombre.Text = miembro.Nombre;
            txtNumeroMiembro.Text = miembro.NumeroMiembro.ToString();
            modoEdicion = true;
            indexMiembroEditado = DataStore.Miembros.IndexOf(miembro);
            btnGuardar.Text = "Guardar Cambios";
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtNumeroMiembro.Clear();
        }

        private bool ValidarCampos()
        {
            return !string.IsNullOrWhiteSpace(txtNombre.Text) && int.TryParse(txtNumeroMiembro.Text, out _);
        }

        private void FormMiembros_Load(object sender, EventArgs e)
        {

        }

        private void EliminarMiembro(Miembro miembro)
        {
            DialogResult resultado = MessageBox.Show($"¿Estás seguro de que deseas eliminar al miembro {miembro.Nombre}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                DataStore.Miembros.Remove(miembro);
                ActualizarListaMiembros();
                MessageBox.Show("Miembro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtNumeroMiembro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada es un número o una tecla de control (como backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Evita que el carácter no numérico se escriba en el campo
                MessageBox.Show("Solo se permiten números en el campo 'Número de Miembro'.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            ActualizarListaMiembros();
        }

    }
}
