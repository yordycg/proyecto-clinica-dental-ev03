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
            txtDuracion = new TextBox();
            pnForm = new Panel();
            pnDGV = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvServicios).BeginInit();
            pnForm.SuspendLayout();
            SuspendLayout();
            // 
            // dgvServicios
            // 
            dgvServicios.BackgroundColor = Color.White;
            dgvServicios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvServicios.Location = new Point(350, 50);
            dgvServicios.Name = "dgvServicios";
            dgvServicios.RowHeadersWidth = 51;
            dgvServicios.Size = new Size(600, 450);
            dgvServicios.TabIndex = 33;
            dgvServicios.Text = "dataGridView1";
            dgvServicios.MouseClick += dgvServicios_MouseClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Nirmala UI", 9F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(132, 282);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 31);
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
            btnGuardar.Location = new Point(236, 282);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 31);
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
            btnLimpiar.Location = new Point(28, 282);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label6
            // 
            label6.Location = new Point(12, 206);
            label6.Name = "label6";
            label6.Size = new Size(114, 31);
            label6.TabIndex = 26;
            label6.Text = "Duracion (min):";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(150, 154);
            txtCosto.Margin = new Padding(3, 4, 3, 4);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(171, 27);
            txtCosto.TabIndex = 24;
            txtCosto.KeyPress += txtCosto_KeyPress;
            txtCosto.Leave += txtCosto_Leave;
            // 
            // label4
            // 
            label4.Location = new Point(12, 154);
            label4.Name = "label4";
            label4.Size = new Size(114, 31);
            label4.TabIndex = 23;
            label4.Text = "Costo:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 102);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(171, 27);
            txtNombre.TabIndex = 22;
            // 
            // label3
            // 
            label3.Location = new Point(12, 102);
            label3.Name = "label3";
            label3.Size = new Size(114, 31);
            label3.TabIndex = 21;
            label3.Text = "Nombre:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtDuracion
            // 
            txtDuracion.Location = new Point(150, 206);
            txtDuracion.Margin = new Padding(3, 4, 3, 4);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(171, 27);
            txtDuracion.TabIndex = 34;
            // 
            // pnForm
            // 
            pnForm.Controls.Add(txtDuracion);
            pnForm.Controls.Add(btnEliminar);
            pnForm.Controls.Add(btnGuardar);
            pnForm.Controls.Add(btnLimpiar);
            pnForm.Controls.Add(label6);
            pnForm.Controls.Add(txtCosto);
            pnForm.Controls.Add(label4);
            pnForm.Controls.Add(txtNombre);
            pnForm.Controls.Add(label3);
            pnForm.Dock = DockStyle.Left;
            pnForm.Location = new Point(0, 0);
            pnForm.Name = "pnForm";
            pnForm.Size = new Size(350, 550);
            pnForm.TabIndex = 35;
            // 
            // pnDGV
            // 
            pnDGV.Dock = DockStyle.Right;
            pnDGV.Location = new Point(350, 0);
            pnDGV.Name = "pnDGV";
            pnDGV.Size = new Size(650, 550);
            pnDGV.TabIndex = 36;
            // 
            // ServiciosForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 550);
            Controls.Add(pnForm);
            Controls.Add(dgvServicios);
            Controls.Add(pnDGV);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ServiciosForm";
            Text = "ServiciosForm";
            ((System.ComponentModel.ISupportInitialize)dgvServicios).EndInit();
            pnForm.ResumeLayout(false);
            pnForm.PerformLayout();
            ResumeLayout(false);
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
        private TextBox txtDuracion;
        private Panel pnForm;
        private Panel pnDGV;
    }
}