namespace Biblioteca
{
    partial class FormMiembros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMiembros));
            txtNombre = new TextBox();
            txtNumeroMiembro = new TextBox();
            lblNombre = new Label();
            lblNumeroMiembro = new Label();
            btnGuardar = new Button();
            flowLayoutPanelMiembros = new FlowLayoutPanel();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(188, 80);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(353, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtNumeroMiembro
            // 
            txtNumeroMiembro.Location = new Point(188, 134);
            txtNumeroMiembro.Margin = new Padding(3, 4, 3, 4);
            txtNumeroMiembro.Name = "txtNumeroMiembro";
            txtNumeroMiembro.Size = new Size(353, 27);
            txtNumeroMiembro.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(38, 84);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // lblNumeroMiembro
            // 
            lblNumeroMiembro.AutoSize = true;
            lblNumeroMiembro.Location = new Point(38, 138);
            lblNumeroMiembro.Name = "lblNumeroMiembro";
            lblNumeroMiembro.Size = new Size(152, 20);
            lblNumeroMiembro.TabIndex = 3;
            lblNumeroMiembro.Text = "Número de Miembro:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(600, 80);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnAgregar_Click;
            // 
            // flowLayoutPanelMiembros
            // 
            flowLayoutPanelMiembros.BackColor = SystemColors.ControlLight;
            flowLayoutPanelMiembros.Location = new Point(12, 186);
            flowLayoutPanelMiembros.Name = "flowLayoutPanelMiembros";
            flowLayoutPanelMiembros.Size = new Size(890, 402);
            flowLayoutPanelMiembros.TabIndex = 8;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(188, 31);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar miembro...";
            txtBuscar.Size = new Size(644, 27);
            txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(38, 34);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(55, 20);
            lblBuscar.TabIndex = 9;
            lblBuscar.Text = "Buscar:";
            // 
            // FormMiembros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(914, 600);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(flowLayoutPanelMiembros);
            Controls.Add(btnGuardar);
            Controls.Add(lblNumeroMiembro);
            Controls.Add(lblNombre);
            Controls.Add(txtNumeroMiembro);
            Controls.Add(txtNombre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMiembros";
            Text = "Administración de Miembros";
            Load += FormMiembros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtNumeroMiembro;
        private Label lblNombre;
        private Label lblNumeroMiembro;
        private Button btnGuardar;
        private FlowLayoutPanel flowLayoutPanelMiembros;
        private TextBox txtBuscar;
        private Label lblBuscar;
    }
}