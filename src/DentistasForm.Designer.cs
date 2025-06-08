namespace clinica_dental_ev03
{
    partial class DentistasForm
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
            dgvDentistas = new DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)dgvDentistas).BeginInit();
            SuspendLayout();
            // 
            // dgvDentistas
            // 
            dgvDentistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDentistas.Location = new Point(377, 100);
            dgvDentistas.Name = "dgvDentistas";
            dgvDentistas.Size = new Size(560, 253);
            dgvDentistas.TabIndex = 33;
            dgvDentistas.Text = "dataGridView1";
            dgvDentistas.MouseClick += dgvDentistas_MouseClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(160, 295);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(235, 265);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(90, 265);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(160, 190);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(150, 23);
            txtCorreo.TabIndex = 29;
            // 
            // label7
            // 
            label7.Location = new Point(50, 190);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 28;
            label7.Text = "Correo:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(160, 160);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 23);
            txtTelefono.TabIndex = 27;
            txtTelefono.KeyPress += txtTelefono_KeyPress;
            // 
            // label6
            // 
            label6.Location = new Point(50, 160);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 26;
            label6.Text = "Telefono:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(160, 130);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(150, 23);
            txtApellido.TabIndex = 24;
            // 
            // label4
            // 
            label4.Location = new Point(50, 130);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 23;
            label4.Text = "Apellido:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 100);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 23);
            txtNombre.TabIndex = 22;
            // 
            // label3
            // 
            label3.Location = new Point(50, 100);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 21;
            label3.Text = "Nombre:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(400, 20);
            label1.Name = "label1";
            label1.Size = new Size(241, 45);
            label1.TabIndex = 18;
            label1.Text = "Formulario Dentistas";
            // 
            // DentistasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 411);
            Controls.Add(dgvDentistas);
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
            Name = "DentistasForm";
            Text = "DentistasForm";
            ((System.ComponentModel.ISupportInitialize)dgvDentistas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDentistas;
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
    }
}