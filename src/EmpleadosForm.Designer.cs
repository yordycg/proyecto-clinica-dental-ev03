namespace clinica_dental_ev03
{
    partial class EmpleadosForm
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
            dgvEmpleados = new DataGridView();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            txtCorreo = new TextBox();
            label7 = new Label();
            txtTelefono = new TextBox();
            label6 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtRun = new TextBox();
            label2 = new Label();
            cbSexo = new ComboBox();
            label8 = new Label();
            cbTipoEmpleado = new ComboBox();
            label5 = new Label();
            pnDGV = new Panel();
            pnForm = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            pnDGV.SuspendLayout();
            pnForm.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(0, 50);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(600, 450);
            dgvEmpleados.TabIndex = 33;
            dgvEmpleados.Text = "dataGridView1";
            dgvEmpleados.MouseClick += dgvDentistas_MouseClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Nirmala UI", 9F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(134, 417);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 32;
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
            btnGuardar.Location = new Point(225, 417);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 31;
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
            btnLimpiar.Location = new Point(43, 417);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(150, 351);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(150, 23);
            txtCorreo.TabIndex = 29;
            // 
            // label7
            // 
            label7.Location = new Point(26, 351);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 28;
            label7.Text = "Correo:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(150, 312);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 23);
            txtTelefono.TabIndex = 27;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label6
            // 
            label6.Location = new Point(26, 312);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 26;
            label6.Text = "Telefono:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(150, 195);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 23);
            txtApellido.TabIndex = 24;
            // 
            // label4
            // 
            label4.Location = new Point(26, 195);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 23;
            label4.Text = "Apellido:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 156);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 23);
            txtNombre.TabIndex = 22;
            // 
            // label3
            // 
            label3.Location = new Point(26, 156);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 21;
            label3.Text = "Nombre:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtRun
            // 
            txtRun.Location = new Point(150, 117);
            txtRun.Name = "txtRun";
            txtRun.Size = new Size(150, 23);
            txtRun.TabIndex = 35;
            txtRun.TextChanged += txtRun_TextChanged;
            txtRun.Leave += txtRun_Leave;
            // 
            // label2
            // 
            label2.Location = new Point(26, 117);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 34;
            label2.Text = "Run:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cbSexo.Location = new Point(150, 273);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(150, 23);
            cbSexo.TabIndex = 39;
            // 
            // label8
            // 
            label8.Location = new Point(26, 273);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 38;
            label8.Text = "Sexo:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbTipoEmpleado
            // 
            cbTipoEmpleado.FormattingEnabled = true;
            cbTipoEmpleado.Location = new Point(150, 234);
            cbTipoEmpleado.Name = "cbTipoEmpleado";
            cbTipoEmpleado.Size = new Size(150, 23);
            cbTipoEmpleado.TabIndex = 41;
            // 
            // label5
            // 
            label5.Location = new Point(26, 234);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 40;
            label5.Text = "Tipo Empleado:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnDGV
            // 
            pnDGV.Controls.Add(dgvEmpleados);
            pnDGV.Dock = DockStyle.Right;
            pnDGV.Location = new Point(350, 0);
            pnDGV.Name = "pnDGV";
            pnDGV.Size = new Size(650, 550);
            pnDGV.TabIndex = 42;
            // 
            // pnForm
            // 
            pnForm.Controls.Add(cbTipoEmpleado);
            pnForm.Controls.Add(label5);
            pnForm.Controls.Add(cbSexo);
            pnForm.Controls.Add(label8);
            pnForm.Controls.Add(txtRun);
            pnForm.Controls.Add(label2);
            pnForm.Controls.Add(btnEliminar);
            pnForm.Controls.Add(btnGuardar);
            pnForm.Controls.Add(btnLimpiar);
            pnForm.Controls.Add(txtCorreo);
            pnForm.Controls.Add(label7);
            pnForm.Controls.Add(txtTelefono);
            pnForm.Controls.Add(label6);
            pnForm.Controls.Add(txtApellido);
            pnForm.Controls.Add(label4);
            pnForm.Controls.Add(txtNombre);
            pnForm.Controls.Add(label3);
            pnForm.Dock = DockStyle.Left;
            pnForm.Location = new Point(0, 0);
            pnForm.Name = "pnForm";
            pnForm.Size = new Size(350, 550);
            pnForm.TabIndex = 43;
            // 
            // EmpleadosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 550);
            Controls.Add(pnForm);
            Controls.Add(pnDGV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmpleadosForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DentistasForm";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            pnDGV.ResumeLayout(false);
            pnForm.ResumeLayout(false);
            pnForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmpleados;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private TextBox txtCorreo;
        private Label label7;
        private TextBox txtTelefono;
        private Label label6;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtRun;
        private Label label2;
        private ComboBox cbSexo;
        private Label label8;
        private ComboBox cbTipoEmpleado;
        private Label label5;
        private Panel pnDGV;
        private Panel pnForm;
    }
}