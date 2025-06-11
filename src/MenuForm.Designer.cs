namespace clinica_dental_ev03
{
    partial class MenuForm
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
            pnMenu = new Panel();
            btnFormCitas = new Button();
            btnFormPagos = new Button();
            btnFormServicios = new Button();
            btnFormPacientes = new Button();
            btnFormUsuarios = new Button();
            btnFormEmpleados = new Button();
            pnLogo = new Panel();
            pictureBox1 = new PictureBox();
            pnTitulo = new Panel();
            lblTitulo = new Label();
            pnCentral = new Panel();
            pnMenu.SuspendLayout();
            pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.WhiteSmoke;
            pnMenu.Controls.Add(btnFormCitas);
            pnMenu.Controls.Add(btnFormPagos);
            pnMenu.Controls.Add(btnFormServicios);
            pnMenu.Controls.Add(btnFormPacientes);
            pnMenu.Controls.Add(btnFormUsuarios);
            pnMenu.Controls.Add(btnFormEmpleados);
            pnMenu.Controls.Add(pnLogo);
            pnMenu.Dock = DockStyle.Left;
            pnMenu.Location = new Point(0, 0);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(143, 450);
            pnMenu.TabIndex = 0;
            // 
            // btnFormCitas
            // 
            btnFormCitas.Dock = DockStyle.Top;
            btnFormCitas.FlatStyle = FlatStyle.Flat;
            btnFormCitas.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFormCitas.Location = new Point(0, 330);
            btnFormCitas.Name = "btnFormCitas";
            btnFormCitas.Size = new Size(143, 51);
            btnFormCitas.TabIndex = 6;
            btnFormCitas.Text = "Citas";
            btnFormCitas.UseVisualStyleBackColor = true;
            btnFormCitas.Click += btnFormCitas_Click;
            // 
            // btnFormPagos
            // 
            btnFormPagos.Dock = DockStyle.Top;
            btnFormPagos.FlatStyle = FlatStyle.Flat;
            btnFormPagos.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFormPagos.Location = new Point(0, 279);
            btnFormPagos.Name = "btnFormPagos";
            btnFormPagos.Size = new Size(143, 51);
            btnFormPagos.TabIndex = 5;
            btnFormPagos.Text = "Pagos";
            btnFormPagos.UseVisualStyleBackColor = true;
            btnFormPagos.Click += btnFormPagos_Click;
            // 
            // btnFormServicios
            // 
            btnFormServicios.Dock = DockStyle.Top;
            btnFormServicios.FlatStyle = FlatStyle.Flat;
            btnFormServicios.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFormServicios.Location = new Point(0, 228);
            btnFormServicios.Name = "btnFormServicios";
            btnFormServicios.Size = new Size(143, 51);
            btnFormServicios.TabIndex = 4;
            btnFormServicios.Text = "Servicios";
            btnFormServicios.UseVisualStyleBackColor = true;
            btnFormServicios.Click += btnFormServicios_Click;
            // 
            // btnFormPacientes
            // 
            btnFormPacientes.Dock = DockStyle.Top;
            btnFormPacientes.FlatStyle = FlatStyle.Flat;
            btnFormPacientes.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFormPacientes.Location = new Point(0, 177);
            btnFormPacientes.Name = "btnFormPacientes";
            btnFormPacientes.Size = new Size(143, 51);
            btnFormPacientes.TabIndex = 3;
            btnFormPacientes.Text = "Pacientes";
            btnFormPacientes.UseVisualStyleBackColor = true;
            btnFormPacientes.Click += btnFormPacientes_Click;
            // 
            // btnFormUsuarios
            // 
            btnFormUsuarios.Dock = DockStyle.Top;
            btnFormUsuarios.FlatStyle = FlatStyle.Flat;
            btnFormUsuarios.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFormUsuarios.Location = new Point(0, 126);
            btnFormUsuarios.Name = "btnFormUsuarios";
            btnFormUsuarios.Size = new Size(143, 51);
            btnFormUsuarios.TabIndex = 2;
            btnFormUsuarios.Text = "Usuarios";
            btnFormUsuarios.UseVisualStyleBackColor = true;
            btnFormUsuarios.Click += btnFormUsuarios_Click;
            // 
            // btnFormEmpleados
            // 
            btnFormEmpleados.Dock = DockStyle.Top;
            btnFormEmpleados.FlatStyle = FlatStyle.Flat;
            btnFormEmpleados.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFormEmpleados.Location = new Point(0, 75);
            btnFormEmpleados.Name = "btnFormEmpleados";
            btnFormEmpleados.Size = new Size(143, 51);
            btnFormEmpleados.TabIndex = 1;
            btnFormEmpleados.Text = "Empleados";
            btnFormEmpleados.UseVisualStyleBackColor = true;
            btnFormEmpleados.Click += btnFormEmpleados_Click;
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(pictureBox1);
            pnLogo.Dock = DockStyle.Top;
            pnLogo.Location = new Point(0, 0);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(143, 75);
            pnLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_clinica_dental;
            pictureBox1.Location = new Point(21, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnTitulo
            // 
            pnTitulo.BackColor = Color.WhiteSmoke;
            pnTitulo.Controls.Add(lblTitulo);
            pnTitulo.Dock = DockStyle.Top;
            pnTitulo.Location = new Point(143, 0);
            pnTitulo.Name = "pnTitulo";
            pnTitulo.Size = new Size(657, 75);
            pnTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(148, 27);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(135, 31);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bienvenido";
            // 
            // pnCentral
            // 
            pnCentral.BackColor = Color.WhiteSmoke;
            pnCentral.Dock = DockStyle.Fill;
            pnCentral.Location = new Point(143, 75);
            pnCentral.Name = "pnCentral";
            pnCentral.Size = new Size(657, 375);
            pnCentral.TabIndex = 2;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnCentral);
            Controls.Add(pnTitulo);
            Controls.Add(pnMenu);
            Name = "MenuForm";
            Text = "MenuForm";
            pnMenu.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnTitulo.ResumeLayout(false);
            pnTitulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMenu;
        private Panel pnLogo;
        private PictureBox pictureBox1;
        private Panel pnTitulo;
        private Panel pnCentral;
        private Button btnFormCitas;
        private Button btnFormPagos;
        private Button btnFormServicios;
        private Button btnFormPacientes;
        private Button btnFormUsuarios;
        private Button btnFormEmpleados;
        private Label lblTitulo;
    }
}