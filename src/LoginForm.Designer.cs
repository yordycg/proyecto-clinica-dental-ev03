namespace clinica_dental_ev03
{
    partial class LoginForm
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            btnIngresar = new Button();
            btnRegistrar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(77, 241);
            label1.Name = "label1";
            label1.Size = new Size(223, 41);
            label1.TabIndex = 0;
            label1.Text = "Ingresar Datos";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_clinica_dental;
            pictureBox1.Location = new Point(79, 33);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 204);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 289);
            label2.Name = "label2";
            label2.Size = new Size(86, 28);
            label2.TabIndex = 2;
            label2.Text = "Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 381);
            label3.Name = "label3";
            label3.Size = new Size(119, 28);
            label3.TabIndex = 3;
            label3.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(52, 321);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(280, 39);
            txtUsuario.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPass.Location = new Point(52, 413);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(280, 39);
            txtPass.TabIndex = 5;
            txtPass.KeyPress += txtPass_KeyPress;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Green;
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(212, 474);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(120, 45);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.LightSlateGray;
            btnRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.Location = new Point(52, 474);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(120, 45);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 548);
            Controls.Add(btnRegistrar);
            Controls.Add(btnIngresar);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private Button btnIngresar;
        private Button btnRegistrar;
    }
}