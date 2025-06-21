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
            pnLogo = new Panel();
            pictureBox1 = new PictureBox();
            btnFormCitas = new Button();
            btnFormPagos = new Button();
            btnFormServicios = new Button();
            btnFormPacientes = new Button();
            btnFormUsuarios = new Button();
            btnFormEmpleados = new Button();
            pnNombreCD = new Panel();
            btnCambiarUsuario = new Button();
            pnTitulo = new Panel();
            panel1 = new Panel();
            btnClose = new Button();
            lblTitulo = new Label();
            pnCentral = new Panel();
            pnMenu.SuspendLayout();
            pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnNombreCD.SuspendLayout();
            pnTitulo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnMenu
            // 
            pnMenu.BackColor = Color.FromArgb(52, 143, 108);
            pnMenu.Controls.Add(pnLogo);
            pnMenu.Controls.Add(btnFormCitas);
            pnMenu.Controls.Add(btnFormPagos);
            pnMenu.Controls.Add(btnFormServicios);
            pnMenu.Controls.Add(btnFormPacientes);
            pnMenu.Controls.Add(btnFormUsuarios);
            pnMenu.Controls.Add(btnFormEmpleados);
            pnMenu.Controls.Add(pnNombreCD);
            pnMenu.Dock = DockStyle.Left;
            pnMenu.Location = new Point(0, 0);
            pnMenu.Name = "pnMenu";
            pnMenu.Size = new Size(200, 600);
            pnMenu.TabIndex = 0;
            // 
            // pnLogo
            // 
            pnLogo.Controls.Add(pictureBox1);
            pnLogo.Dock = DockStyle.Bottom;
            pnLogo.Location = new Point(0, 450);
            pnLogo.Margin = new Padding(3, 4, 3, 4);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(200, 150);
            pnLogo.TabIndex = 7;
            // 
            // pictureBox1
            // 

            pictureBox1.Image = Image.FromFile(@"..\..\..\Assets\images\logo_dental_02.png"); ;
            pictureBox1.Location = new Point(50, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnFormCitas
            // 
            btnFormCitas.Dock = DockStyle.Top;
            btnFormCitas.FlatAppearance.BorderSize = 0;
            btnFormCitas.FlatStyle = FlatStyle.Flat;
            btnFormCitas.Font = new Font("Nirmala UI", 12F);
            btnFormCitas.ForeColor = Color.White;
            btnFormCitas.Location = new Point(0, 250);
            btnFormCitas.Name = "btnFormCitas";
            btnFormCitas.Padding = new Padding(17, 0, 0, 0);
            btnFormCitas.Size = new Size(200, 40);
            btnFormCitas.TabIndex = 6;
            btnFormCitas.Text = "Citas";
            btnFormCitas.TextAlign = ContentAlignment.MiddleLeft;
            btnFormCitas.UseVisualStyleBackColor = true;
            btnFormCitas.Click += btnFormCitas_Click;
            // 
            // btnFormPagos
            // 
            btnFormPagos.Dock = DockStyle.Top;
            btnFormPagos.FlatAppearance.BorderSize = 0;
            btnFormPagos.FlatStyle = FlatStyle.Flat;
            btnFormPagos.Font = new Font("Nirmala UI", 12F);
            btnFormPagos.ForeColor = Color.White;
            btnFormPagos.Location = new Point(0, 210);
            btnFormPagos.Name = "btnFormPagos";
            btnFormPagos.Padding = new Padding(17, 0, 0, 0);
            btnFormPagos.Size = new Size(200, 40);
            btnFormPagos.TabIndex = 5;
            btnFormPagos.Text = "Pagos";
            btnFormPagos.TextAlign = ContentAlignment.MiddleLeft;
            btnFormPagos.UseVisualStyleBackColor = true;
            btnFormPagos.Click += btnFormPagos_Click;
            // 
            // btnFormServicios
            // 
            btnFormServicios.Dock = DockStyle.Top;
            btnFormServicios.FlatAppearance.BorderSize = 0;
            btnFormServicios.FlatStyle = FlatStyle.Flat;
            btnFormServicios.Font = new Font("Nirmala UI", 12F);
            btnFormServicios.ForeColor = Color.White;
            btnFormServicios.Location = new Point(0, 170);
            btnFormServicios.Name = "btnFormServicios";
            btnFormServicios.Padding = new Padding(17, 0, 0, 0);
            btnFormServicios.Size = new Size(200, 40);
            btnFormServicios.TabIndex = 4;
            btnFormServicios.Text = "Servicios";
            btnFormServicios.TextAlign = ContentAlignment.MiddleLeft;
            btnFormServicios.UseVisualStyleBackColor = true;
            btnFormServicios.Click += btnFormServicios_Click;
            // 
            // btnFormPacientes
            // 
            btnFormPacientes.Dock = DockStyle.Top;
            btnFormPacientes.FlatAppearance.BorderSize = 0;
            btnFormPacientes.FlatStyle = FlatStyle.Flat;
            btnFormPacientes.Font = new Font("Nirmala UI", 12F);
            btnFormPacientes.ForeColor = Color.White;
            btnFormPacientes.Location = new Point(0, 130);
            btnFormPacientes.Name = "btnFormPacientes";
            btnFormPacientes.Padding = new Padding(17, 0, 0, 0);
            btnFormPacientes.Size = new Size(200, 40);
            btnFormPacientes.TabIndex = 3;
            btnFormPacientes.Text = "Pacientes";
            btnFormPacientes.TextAlign = ContentAlignment.MiddleLeft;
            btnFormPacientes.UseVisualStyleBackColor = true;
            btnFormPacientes.Click += btnFormPacientes_Click;
            // 
            // btnFormUsuarios
            // 
            btnFormUsuarios.Dock = DockStyle.Top;
            btnFormUsuarios.FlatAppearance.BorderSize = 0;
            btnFormUsuarios.FlatStyle = FlatStyle.Flat;
            btnFormUsuarios.Font = new Font("Nirmala UI", 12F);
            btnFormUsuarios.ForeColor = Color.White;
            btnFormUsuarios.Location = new Point(0, 90);
            btnFormUsuarios.Name = "btnFormUsuarios";
            btnFormUsuarios.Padding = new Padding(17, 0, 0, 0);
            btnFormUsuarios.Size = new Size(200, 40);
            btnFormUsuarios.TabIndex = 2;
            btnFormUsuarios.Text = "Usuarios";
            btnFormUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnFormUsuarios.UseVisualStyleBackColor = true;
            btnFormUsuarios.Click += btnFormUsuarios_Click;
            // 
            // btnFormEmpleados
            // 
            btnFormEmpleados.Dock = DockStyle.Top;
            btnFormEmpleados.FlatAppearance.BorderSize = 0;
            btnFormEmpleados.FlatStyle = FlatStyle.Flat;
            btnFormEmpleados.Font = new Font("Nirmala UI", 12F);
            btnFormEmpleados.ForeColor = Color.White;
            btnFormEmpleados.Location = new Point(0, 50);
            btnFormEmpleados.Name = "btnFormEmpleados";
            btnFormEmpleados.Padding = new Padding(17, 0, 0, 0);
            btnFormEmpleados.Size = new Size(200, 40);
            btnFormEmpleados.TabIndex = 1;
            btnFormEmpleados.Text = "Empleados";
            btnFormEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            btnFormEmpleados.UseVisualStyleBackColor = true;
            btnFormEmpleados.Click += btnFormEmpleados_Click;
            // 
            // pnNombreCD
            // 
            pnNombreCD.Controls.Add(btnCambiarUsuario);
            pnNombreCD.Dock = DockStyle.Top;
            pnNombreCD.Location = new Point(0, 0);
            pnNombreCD.Name = "pnNombreCD";
            pnNombreCD.Size = new Size(200, 50);
            pnNombreCD.TabIndex = 0;
            // 
            // btnCambiarUsuario
            // 
            btnCambiarUsuario.BackColor = Color.FromArgb(52, 143, 108);
            btnCambiarUsuario.FlatAppearance.BorderSize = 0;
            btnCambiarUsuario.FlatStyle = FlatStyle.Flat;
            btnCambiarUsuario.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarUsuario.ForeColor = Color.White;
            btnCambiarUsuario.Location = new Point(20, 5);
            btnCambiarUsuario.Margin = new Padding(3, 0, 3, 0);
            btnCambiarUsuario.Name = "btnCambiarUsuario";
            btnCambiarUsuario.Size = new Size(160, 40);
            btnCambiarUsuario.TabIndex = 0;
            btnCambiarUsuario.Text = "Tipo";
            btnCambiarUsuario.UseVisualStyleBackColor = false;
            btnCambiarUsuario.Click += btnCambiarUsuario_Click;
            // 
            // pnTitulo
            // 
            pnTitulo.BackColor = Color.White;
            pnTitulo.Controls.Add(panel1);
            pnTitulo.Controls.Add(lblTitulo);
            pnTitulo.Dock = DockStyle.Top;
            pnTitulo.Location = new Point(200, 0);
            pnTitulo.Name = "pnTitulo";
            pnTitulo.Size = new Size(1000, 50);
            pnTitulo.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(950, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(50, 50);
            panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(52, 143, 108);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(10, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(150, 5);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(650, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Bienvenido";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnCentral
            // 
            pnCentral.BackColor = Color.White;
            pnCentral.Dock = DockStyle.Fill;
            pnCentral.Location = new Point(200, 50);
            pnCentral.Name = "pnCentral";
            pnCentral.Size = new Size(1000, 550);
            pnCentral.TabIndex = 2;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 600);
            Controls.Add(pnCentral);
            Controls.Add(pnTitulo);
            Controls.Add(pnMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuForm";
            pnMenu.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnNombreCD.ResumeLayout(false);
            pnTitulo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMenu;
        private Panel pnNombreCD;
        private Panel pnTitulo;
        private Panel pnCentral;
        private Button btnFormCitas;
        private Button btnFormPagos;
        private Button btnFormServicios;
        private Button btnFormPacientes;
        private Button btnFormUsuarios;
        private Button btnFormEmpleados;
        private Label lblTitulo;
        private Panel pnLogo;
        private Panel panel1;
        private Button btnClose;
        private PictureBox pictureBox1;
        private Button btnCambiarUsuario;
    }
}