namespace Biblioteca
{
    partial class FormPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrestamos));
            comboBoxLibros = new ComboBox();
            comboBoxMiembros = new ComboBox();
            lblLibros = new Label();
            lblMiembros = new Label();
            btnRealizarPrestamo = new Button();
            flowLayoutPanelPrestamos = new FlowLayoutPanel();
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            SuspendLayout();
            // 
            // comboBoxLibros
            // 
            comboBoxLibros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLibros.FormattingEnabled = true;
            comboBoxLibros.Location = new Point(184, 77);
            comboBoxLibros.Margin = new Padding(3, 4, 3, 4);
            comboBoxLibros.Name = "comboBoxLibros";
            comboBoxLibros.Size = new Size(226, 28);
            comboBoxLibros.TabIndex = 0;
            // 
            // comboBoxMiembros
            // 
            comboBoxMiembros.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMiembros.FormattingEnabled = true;
            comboBoxMiembros.Location = new Point(184, 133);
            comboBoxMiembros.Margin = new Padding(3, 4, 3, 4);
            comboBoxMiembros.Name = "comboBoxMiembros";
            comboBoxMiembros.Size = new Size(226, 28);
            comboBoxMiembros.TabIndex = 1;
            // 
            // lblLibros
            // 
            lblLibros.AutoSize = true;
            lblLibros.Location = new Point(31, 86);
            lblLibros.Name = "lblLibros";
            lblLibros.Size = new Size(52, 20);
            lblLibros.TabIndex = 2;
            lblLibros.Text = "Libros:";
            // 
            // lblMiembros
            // 
            lblMiembros.AutoSize = true;
            lblMiembros.Location = new Point(31, 137);
            lblMiembros.Name = "lblMiembros";
            lblMiembros.Size = new Size(79, 20);
            lblMiembros.TabIndex = 3;
            lblMiembros.Text = "Miembros:";
            // 
            // btnRealizarPrestamo
            // 
            btnRealizarPrestamo.Location = new Point(513, 80);
            btnRealizarPrestamo.Margin = new Padding(3, 4, 3, 4);
            btnRealizarPrestamo.Name = "btnRealizarPrestamo";
            btnRealizarPrestamo.Size = new Size(158, 31);
            btnRealizarPrestamo.TabIndex = 4;
            btnRealizarPrestamo.Text = "Realizar Préstamo";
            btnRealizarPrestamo.UseVisualStyleBackColor = true;
            btnRealizarPrestamo.Click += btnRealizarPrestamo_Click;
            // 
            // flowLayoutPanelPrestamos
            // 
            flowLayoutPanelPrestamos.BackColor = SystemColors.ControlLight;
            flowLayoutPanelPrestamos.Location = new Point(12, 183);
            flowLayoutPanelPrestamos.Name = "flowLayoutPanelPrestamos";
            flowLayoutPanelPrestamos.Size = new Size(890, 394);
            flowLayoutPanelPrestamos.TabIndex = 7;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(185, 28);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar Prestamo...";
            txtBuscar.Size = new Size(486, 27);
            txtBuscar.TabIndex = 8;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(31, 31);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(52, 20);
            lblBuscar.TabIndex = 9;
            lblBuscar.Text = "Libros:";
            // 
            // FormPrestamos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(914, 625);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(flowLayoutPanelPrestamos);
            Controls.Add(btnRealizarPrestamo);
            Controls.Add(lblMiembros);
            Controls.Add(lblLibros);
            Controls.Add(comboBoxMiembros);
            Controls.Add(comboBoxLibros);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPrestamos";
            Text = "Realizar Prestamos";
            Load += FormPrestamos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxLibros;
        private ComboBox comboBoxMiembros;
        private Label lblLibros;
        private Label lblMiembros;
        private Button btnRealizarPrestamo;
        private FlowLayoutPanel flowLayoutPanelPrestamos;
        private Button btnDevolverLibro;
        private TextBox txtBuscar;
        private Label lblBuscar;
    }
}