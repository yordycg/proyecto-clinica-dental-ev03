namespace clinica_dental_ev03
{
    partial class ServiciosForm
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
            dgvServicios = new DataGridView();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            label6 = new Label();
            txtCosto = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label1 = new Label();
            txtDuracion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            SuspendLayout();
            // 
            // dgvServicios
            // 
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(400, 133);
            dgvServicios.Margin = new Padding(3, 4, 3, 4);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.RowHeadersWidth = 51;
            dgvServicios.Size = new Size(640, 337);
            dgvServicios.TabIndex = 33;
            dgvServicios.Text = "dataGridView1";
            dgvServicios.MouseClick += dgvServicios_MouseClick;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(63, 342);
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
            btnGuardar.Location = new Point(248, 342);
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
            btnLimpiar.Location = new Point(156, 342);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label6
            // 
            label6.Location = new Point(48, 273);
            label6.Name = "label6";
            label6.Size = new Size(114, 31);
            label6.TabIndex = 26;
            label6.Text = "Duracion (min):";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(173, 233);
            txtCosto.Margin = new Padding(3, 4, 3, 4);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(171, 27);
            txtCosto.TabIndex = 24;
            txtCosto.KeyPress += txtCosto_KeyPress;
            // 
            // label4
            // 
            label4.Location = new Point(48, 233);
            label4.Name = "label4";
            label4.Size = new Size(114, 31);
            label4.TabIndex = 23;
            label4.Text = "Costo:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(173, 193);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(171, 27);
            txtNombre.TabIndex = 22;
            // 
            // label3
            // 
            label3.Location = new Point(48, 193);
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
            label1.Size = new Size(301, 60);
            label1.TabIndex = 18;
            label1.Text = "Formulario Servicios";
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(173, 275);
            txtDuracion.Margin = new Padding(3, 4, 3, 4);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(171, 27);
            txtDuracion.TabIndex = 34;
            // 
            // ServiciosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1125, 548);
            Controls.Add(txtDuracion);
            Controls.Add(dgvServicios);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(label6);
            Controls.Add(txtCosto);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ServiciosForm";
            Text = "ServiciosForm";
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvServicios;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Label label6;
        private TextBox txtCosto;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private Label label1;
        private TextBox txtDuracion;
    }
}