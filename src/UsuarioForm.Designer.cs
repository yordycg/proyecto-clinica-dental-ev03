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
            label2 = new Label();
            txtPassRep = new TextBox();
            label5 = new Label();
            pnForm = new Panel();
            cbRun = new ComboBox();
            pnDGV = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            pnForm.SuspendLayout();
            pnDGV.SuspendLayout();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.BackgroundColor = Color.White;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(0, 50);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.Size = new Size(600, 450);
            dgvUsuarios.TabIndex = 54;
            dgvUsuarios.Text = "dataGridView1";
            dgvUsuarios.MouseClick += dgvUsuarios_MouseClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Nirmala UI", 9F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(130, 316);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 53;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(52, 143, 108);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Nirmala UI", 9F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(234, 316);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 52;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Gainsboro;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Nirmala UI", 9F);
            btnLimpiar.Location = new Point(26, 316);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 51;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(157, 184);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(171, 27);
            txtPass.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 188);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 45;
            label4.Text = "Contraseña";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(157, 132);
            txtNombreUsuario.Margin = new Padding(3, 4, 3, 4);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(171, 27);
            txtNombreUsuario.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 136);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 43;
            label3.Text = "Nombre Usuario";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 88);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 55;
            label2.Text = "Run Empleado";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPassRep
            // 
            txtPassRep.Location = new Point(157, 236);
            txtPassRep.Margin = new Padding(3, 4, 3, 4);
            txtPassRep.Name = "txtPassRep";
            txtPassRep.PasswordChar = '*';
            txtPassRep.Size = new Size(171, 27);
            txtPassRep.TabIndex = 58;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 240);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 57;
            label5.Text = "Repetir Contraseña";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnForm
            // 
            pnForm.Controls.Add(cbRun);
            pnForm.Controls.Add(txtPassRep);
            pnForm.Controls.Add(label5);
            pnForm.Controls.Add(label2);
            pnForm.Controls.Add(btnEliminar);
            pnForm.Controls.Add(btnGuardar);
            pnForm.Controls.Add(btnLimpiar);
            pnForm.Controls.Add(txtPass);
            pnForm.Controls.Add(label4);
            pnForm.Controls.Add(txtNombreUsuario);
            pnForm.Controls.Add(label3);
            pnForm.Dock = DockStyle.Left;
            pnForm.Location = new Point(0, 0);
            pnForm.Name = "pnForm";
            pnForm.Size = new Size(350, 550);
            pnForm.TabIndex = 59;
            // 
            // cbRun
            // 
            cbRun.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRun.FormattingEnabled = true;
            cbRun.Location = new Point(157, 84);
            cbRun.Margin = new Padding(3, 4, 3, 4);
            cbRun.Name = "cbRun";
            cbRun.Size = new Size(171, 28);
            cbRun.TabIndex = 59;
            // 
            // pnDGV
            // 
            pnDGV.Controls.Add(dgvUsuarios);
            pnDGV.Dock = DockStyle.Right;
            pnDGV.Location = new Point(350, 0);
            pnDGV.Name = "pnDGV";
            pnDGV.Size = new Size(650, 550);
            pnDGV.TabIndex = 60;
            // 
            // UsuarioForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 550);
            Controls.Add(pnForm);
            Controls.Add(pnDGV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsuarioForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UsuarioForm";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            pnForm.ResumeLayout(false);
            pnForm.PerformLayout();
            pnDGV.ResumeLayout(false);
            ResumeLayout(false);
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
        private Label label2;
        private TextBox txtPassRep;
        private Label label5;
        private Panel pnForm;
        private Panel pnDGV;
        private ComboBox cbRun;
    }
}