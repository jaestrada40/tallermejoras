namespace Biblioteca
{
    partial class FormLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibros));
            lblTitulo = new Label();
            lblAutor = new Label();
            lblAnoPublicacion = new Label();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtAnio = new TextBox();
            rbFisico = new RadioButton();
            rbElectronico = new RadioButton();
            lblUbicacion = new Label();
            txtUbicacion = new TextBox();
            lblTamanoArchivo = new Label();
            txtTamano = new TextBox();
            txtFormato = new TextBox();
            label1 = new Label();
            btnAgregar = new Button();
            flowLayoutPanelLibros = new FlowLayoutPanel();
            txtBuscar = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(25, 82);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(50, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Título:";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(25, 127);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(49, 20);
            lblAutor.TabIndex = 1;
            lblAutor.Text = "Autor:";
            // 
            // lblAnoPublicacion
            // 
            lblAnoPublicacion.AutoSize = true;
            lblAnoPublicacion.Location = new Point(25, 173);
            lblAnoPublicacion.Name = "lblAnoPublicacion";
            lblAnoPublicacion.Size = new Size(140, 20);
            lblAnoPublicacion.TabIndex = 2;
            lblAnoPublicacion.Text = "Año de Publicación:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(201, 78);
            txtTitulo.Margin = new Padding(3, 4, 3, 4);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(263, 27);
            txtTitulo.TabIndex = 3;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(201, 123);
            txtAutor.Margin = new Padding(3, 4, 3, 4);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(263, 27);
            txtAutor.TabIndex = 4;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(201, 169);
            txtAnio.Margin = new Padding(3, 4, 3, 4);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(263, 27);
            txtAnio.TabIndex = 5;
            // 
            // rbFisico
            // 
            rbFisico.AutoSize = true;
            rbFisico.Location = new Point(205, 225);
            rbFisico.Margin = new Padding(3, 4, 3, 4);
            rbFisico.Name = "rbFisico";
            rbFisico.Size = new Size(71, 24);
            rbFisico.TabIndex = 6;
            rbFisico.TabStop = true;
            rbFisico.Text = "Físico ";
            rbFisico.UseVisualStyleBackColor = true;
            // 
            // rbElectronico
            // 
            rbElectronico.AutoSize = true;
            rbElectronico.Location = new Point(303, 225);
            rbElectronico.Margin = new Padding(3, 4, 3, 4);
            rbElectronico.Name = "rbElectronico";
            rbElectronico.Size = new Size(104, 24);
            rbElectronico.TabIndex = 7;
            rbElectronico.TabStop = true;
            rbElectronico.Text = "Electrónico";
            rbElectronico.UseVisualStyleBackColor = true;
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.Location = new Point(25, 265);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(78, 20);
            lblUbicacion.TabIndex = 8;
            lblUbicacion.Text = "Ubicación:";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(201, 261);
            txtUbicacion.Margin = new Padding(3, 4, 3, 4);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(263, 27);
            txtUbicacion.TabIndex = 9;
            // 
            // lblTamanoArchivo
            // 
            lblTamanoArchivo.AutoSize = true;
            lblTamanoArchivo.Location = new Point(25, 319);
            lblTamanoArchivo.Name = "lblTamanoArchivo";
            lblTamanoArchivo.Size = new Size(139, 20);
            lblTamanoArchivo.TabIndex = 10;
            lblTamanoArchivo.Text = "Tamaño de Archivo:";
            // 
            // txtTamano
            // 
            txtTamano.Location = new Point(201, 315);
            txtTamano.Margin = new Padding(3, 4, 3, 4);
            txtTamano.Name = "txtTamano";
            txtTamano.Size = new Size(263, 27);
            txtTamano.TabIndex = 11;
            // 
            // txtFormato
            // 
            txtFormato.Location = new Point(201, 373);
            txtFormato.Margin = new Padding(3, 4, 3, 4);
            txtFormato.Name = "txtFormato";
            txtFormato.Size = new Size(263, 27);
            txtFormato.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 377);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 13;
            label1.Text = "Formato:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(573, 94);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(86, 31);
            btnAgregar.TabIndex = 14;
            btnAgregar.Text = "Guardar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // flowLayoutPanelLibros
            // 
            flowLayoutPanelLibros.BackColor = SystemColors.ControlLight;
            flowLayoutPanelLibros.Location = new Point(12, 434);
            flowLayoutPanelLibros.Name = "flowLayoutPanelLibros";
            flowLayoutPanelLibros.Size = new Size(890, 403);
            flowLayoutPanelLibros.TabIndex = 19;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(204, 27);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Buscar libro...";
            txtBuscar.Size = new Size(455, 27);
            txtBuscar.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 30);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 21;
            label2.Text = "Buscar:";
            // 
            // FormLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(914, 883);
            Controls.Add(label2);
            Controls.Add(txtBuscar);
            Controls.Add(flowLayoutPanelLibros);
            Controls.Add(btnAgregar);
            Controls.Add(label1);
            Controls.Add(txtFormato);
            Controls.Add(txtTamano);
            Controls.Add(lblTamanoArchivo);
            Controls.Add(txtUbicacion);
            Controls.Add(lblUbicacion);
            Controls.Add(rbElectronico);
            Controls.Add(rbFisico);
            Controls.Add(txtAnio);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(lblAnoPublicacion);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLibros";
            Text = "Administración de Libros";
            Load += FormLibros_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblAutor;
        private Label lblAnoPublicacion;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtAnio;
        private RadioButton rbFisico;
        private RadioButton rbElectronico;
        private Label lblUbicacion;
        private TextBox txtUbicacion;
        private Label lblTamanoArchivo;
        private TextBox txtTamano;
        private TextBox txtFormato;
        private Label label1;
        private Button btnAgregar;
        private FlowLayoutPanel flowLayoutPanelLibros;
        private TextBox txtBuscar;
        private Label label2;
    }
}