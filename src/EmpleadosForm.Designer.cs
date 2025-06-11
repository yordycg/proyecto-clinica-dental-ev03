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
            label1 = new Label();
            txtRun = new TextBox();
            label2 = new Label();
            cbSexo = new ComboBox();
            label8 = new Label();
            cbTipoEmpleado = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(431, 133);
            dgvEmpleados.Margin = new Padding(3, 4, 3, 4);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(640, 337);
            dgvEmpleados.TabIndex = 33;
            dgvEmpleados.Text = "dataGridView1";
            dgvEmpleados.MouseClick += dgvDentistas_MouseClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(189, 461);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(275, 421);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(109, 421);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(189, 364);
            txtCorreo.Margin = new Padding(3, 4, 3, 4);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(171, 27);
            txtCorreo.TabIndex = 29;
            // 
            // label7
            // 
            label7.Location = new Point(63, 364);
            label7.Name = "label7";
            label7.Size = new Size(114, 31);
            label7.TabIndex = 28;
            label7.Text = "Correo:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(189, 324);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(171, 27);
            txtTelefono.TabIndex = 27;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label6
            // 
            label6.Location = new Point(63, 324);
            label6.Name = "label6";
            label6.Size = new Size(114, 31);
            label6.TabIndex = 26;
            label6.Text = "Telefono:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(189, 194);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(171, 27);
            txtApellido.TabIndex = 24;
            // 
            // label4
            // 
            label4.Location = new Point(63, 194);
            label4.Name = "label4";
            label4.Size = new Size(114, 31);
            label4.TabIndex = 23;
            label4.Text = "Apellido:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(189, 154);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(171, 27);
            txtNombre.TabIndex = 22;
            // 
            // label3
            // 
            label3.Location = new Point(63, 154);
            label3.Name = "label3";
            label3.Size = new Size(114, 31);
            label3.TabIndex = 21;
            label3.Text = "Nombre:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(457, 27);
            label1.Name = "label1";
            label1.Size = new Size(312, 60);
            label1.TabIndex = 18;
            label1.Text = "Nuevo Empleado";
            // 
            // txtRun
            // 
            txtRun.Location = new Point(189, 108);
            txtRun.Margin = new Padding(3, 4, 3, 4);
            txtRun.Name = "txtRun";
            txtRun.Size = new Size(171, 27);
            txtRun.TabIndex = 35;
            txtRun.TextChanged += txtRun_TextChanged;
            txtRun.Leave += txtRun_Leave;
            // 
            // label2
            // 
            label2.Location = new Point(63, 108);
            label2.Name = "label2";
            label2.Size = new Size(114, 31);
            label2.TabIndex = 34;
            label2.Text = "Run:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cbSexo.Location = new Point(189, 283);
            cbSexo.Margin = new Padding(3, 4, 3, 4);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(171, 28);
            cbSexo.TabIndex = 39;
            // 
            // label8
            // 
            label8.Location = new Point(63, 283);
            label8.Name = "label8";
            label8.Size = new Size(114, 31);
            label8.TabIndex = 38;
            label8.Text = "Sexo:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbTipoEmpleado
            // 
            cbTipoEmpleado.FormattingEnabled = true;
            cbTipoEmpleado.Location = new Point(189, 240);
            cbTipoEmpleado.Margin = new Padding(3, 4, 3, 4);
            cbTipoEmpleado.Name = "cbTipoEmpleado";
            cbTipoEmpleado.Size = new Size(171, 28);
            cbTipoEmpleado.TabIndex = 41;
            // 
            // label5
            // 
            label5.Location = new Point(63, 240);
            label5.Name = "label5";
            label5.Size = new Size(114, 31);
            label5.TabIndex = 40;
            label5.Text = "Tipo Empleado:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EmpleadosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 548);
            Controls.Add(cbTipoEmpleado);
            Controls.Add(label5);
            Controls.Add(cbSexo);
            Controls.Add(label8);
            Controls.Add(txtRun);
            Controls.Add(label2);
            Controls.Add(dgvEmpleados);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(txtCorreo);
            Controls.Add(label7);
            Controls.Add(txtTelefono);
            Controls.Add(label6);
            Controls.Add(txtApellido);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmpleadosForm";
            Text = "DentistasForm";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
        private TextBox txtRun;
        private Label label2;
        private ComboBox cbSexo;
        private Label label8;
        private ComboBox cbTipoEmpleado;
        private Label label5;
    }
}