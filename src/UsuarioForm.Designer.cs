namespace clinica_dental_ev03
{
    partial class UsuarioForm
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
            dgvUsuarios = new DataGridView();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            txtPass = new TextBox();
            label4 = new Label();
            txtNombreUsuario = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtRun = new TextBox();
            label2 = new Label();
            txtPassRep = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(417, 85);
            dgvUsuarios.Margin = new Padding(3, 4, 3, 4);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(729, 337);
            dgvUsuarios.TabIndex = 54;
            dgvUsuarios.Text = "dataGridView1";
            dgvUsuarios.MouseClick += dgvUsuarios_MouseClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(150, 348);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 53;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(236, 308);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 52;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(70, 308);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 51;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(168, 207);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(171, 27);
            txtPass.TabIndex = 46;
            // 
            // label4
            // 
            label4.Location = new Point(42, 207);
            label4.Name = "label4";
            label4.Size = new Size(114, 31);
            label4.TabIndex = 45;
            label4.Text = "Contraseña:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(168, 167);
            txtNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(171, 27);
            txtNombreUsuario.TabIndex = 44;
            // 
            // label3
            // 
            label3.Location = new Point(25, 165);
            label3.Name = "label3";
            label3.Size = new Size(131, 31);
            label3.TabIndex = 43;
            label3.Text = "Nombre Usuario:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(417, 12);
            label1.Name = "label1";
            label1.Size = new Size(312, 60);
            label1.TabIndex = 42;
            label1.Text = "Nuevo Empleado";
            // 
            // txtRun
            // 
            txtRun.Location = new Point(168, 127);
            txtRun.Margin = new Padding(3, 4, 3, 4);
            txtRun.Name = "txtRun";
            txtRun.Size = new Size(171, 27);
            txtRun.TabIndex = 56;
            txtRun.TextChanged += txtRut_TextChanged;
            txtRun.Leave += txtRut_Leave;
            // 
            // label2
            // 
            label2.Location = new Point(42, 127);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 55;
            label2.Text = "Run Empleado:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPassRep
            // 
            txtPassRep.Location = new Point(168, 252);
            txtPassRep.Margin = new Padding(3, 4, 3, 4);
            txtPassRep.Name = "txtPassRep";
            txtPassRep.PasswordChar = '*';
            txtPassRep.Size = new Size(171, 27);
            txtPassRep.TabIndex = 58;
            // 
            // label5
            // 
            label5.Location = new Point(12, 250);
            label5.Name = "label5";
            label5.Size = new Size(144, 31);
            label5.TabIndex = 57;
            label5.Text = "Repetir Contraseña:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UsuarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 453);
            Controls.Add(txtPassRep);
            Controls.Add(label5);
            Controls.Add(txtRun);
            Controls.Add(label2);
            Controls.Add(dgvUsuarios);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtPass);
            Controls.Add(label4);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "UsuarioForm";
            Text = "UsuarioForm";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvUsuarios;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private TextBox txtPass;
        private Label label4;
        private TextBox txtNombreUsuario;
        private Label label3;
        private Label label1;
        private TextBox txtRun;
        private Label label2;
        private TextBox txtPassRep;
        private Label label5;
    }
}