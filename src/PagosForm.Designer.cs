namespace clinica_dental_ev03
{
    partial class PagosForm
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
            dgvCitas = new DataGridView();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            dgvPagos = new DataGridView();
            cbMetodoPago = new ComboBox();
            label5 = new Label();
            cbEstadoPago = new ComboBox();
            label8 = new Label();
            txtCitaId = new TextBox();
            label2 = new Label();
            label4 = new Label();
            txtMonto = new TextBox();
            label3 = new Label();
            dtpFecha = new DateTimePicker();
            pnDGVCitas = new Panel();
            pnForm = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).BeginInit();
            pnForm.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCitas
            // 
            dgvCitas.BackgroundColor = Color.White;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(50, 25);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.Size = new Size(900, 150);
            dgvCitas.TabIndex = 0;
            dgvCitas.MouseClick += dgvCitas_MouseClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.IndianRed;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Nirmala UI", 9F);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(137, 295);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 18;
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
            btnGuardar.Location = new Point(228, 295);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 17;
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
            btnLimpiar.Location = new Point(46, 295);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvPagos
            // 
            dgvPagos.BackgroundColor = Color.White;
            dgvPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPagos.Location = new Point(350, 200);
            dgvPagos.Name = "dgvPagos";
            dgvPagos.Size = new Size(600, 300);
            dgvPagos.TabIndex = 19;
            dgvPagos.MouseClick += dgvPagos_MouseClick;
            // 
            // cbMetodoPago
            // 
            cbMetodoPago.FormattingEnabled = true;
            cbMetodoPago.Location = new Point(153, 201);
            cbMetodoPago.Name = "cbMetodoPago";
            cbMetodoPago.Size = new Size(150, 23);
            cbMetodoPago.TabIndex = 51;
            // 
            // label5
            // 
            label5.Location = new Point(29, 201);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 50;
            label5.Text = "Metodo Pago";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbEstadoPago
            // 
            cbEstadoPago.FormattingEnabled = true;
            cbEstadoPago.Items.AddRange(new object[] { "Femenino", "Masculino" });
            cbEstadoPago.Location = new Point(153, 240);
            cbEstadoPago.Name = "cbEstadoPago";
            cbEstadoPago.Size = new Size(150, 23);
            cbEstadoPago.TabIndex = 49;
            // 
            // label8
            // 
            label8.Location = new Point(29, 240);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 48;
            label8.Text = "Estado Pago";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtCitaId
            // 
            txtCitaId.Location = new Point(153, 84);
            txtCitaId.Name = "txtCitaId";
            txtCitaId.Size = new Size(150, 23);
            txtCitaId.TabIndex = 47;
            // 
            // label2
            // 
            label2.Location = new Point(29, 84);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 46;
            label2.Text = "Num Cita";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(29, 162);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 44;
            label4.Text = "Fecha";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(153, 123);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(150, 23);
            txtMonto.TabIndex = 43;
            txtMonto.KeyPress += txtMonto_KeyPress;
            // 
            // label3
            // 
            label3.Location = new Point(29, 123);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 42;
            label3.Text = "Monto";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtpFecha
            // 
            dtpFecha.CustomFormat = "dd/MM/yyyy";
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.Location = new Point(153, 163);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(150, 23);
            dtpFecha.TabIndex = 52;
            // 
            // pnDGVCitas
            // 
            pnDGVCitas.Dock = DockStyle.Top;
            pnDGVCitas.Location = new Point(0, 0);
            pnDGVCitas.Name = "pnDGVCitas";
            pnDGVCitas.Size = new Size(1000, 150);
            pnDGVCitas.TabIndex = 53;
            // 
            // pnForm
            // 
            pnForm.Controls.Add(dtpFecha);
            pnForm.Controls.Add(cbMetodoPago);
            pnForm.Controls.Add(label5);
            pnForm.Controls.Add(cbEstadoPago);
            pnForm.Controls.Add(label8);
            pnForm.Controls.Add(txtCitaId);
            pnForm.Controls.Add(label2);
            pnForm.Controls.Add(label4);
            pnForm.Controls.Add(txtMonto);
            pnForm.Controls.Add(label3);
            pnForm.Controls.Add(btnEliminar);
            pnForm.Controls.Add(btnGuardar);
            pnForm.Controls.Add(btnLimpiar);
            pnForm.Dock = DockStyle.Left;
            pnForm.Location = new Point(0, 150);
            pnForm.Name = "pnForm";
            pnForm.Size = new Size(350, 400);
            pnForm.TabIndex = 54;
            // 
            // panel1
            // 
            panel1.Location = new Point(350, 150);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 400);
            panel1.TabIndex = 55;
            // 
            // PagosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 550);
            Controls.Add(dgvCitas);
            Controls.Add(pnForm);
            Controls.Add(pnDGVCitas);
            Controls.Add(dgvPagos);
            Controls.Add(panel1);
            Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PagosForm";
            Text = "PagosForm";
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPagos).EndInit();
            pnForm.ResumeLayout(false);
            pnForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCitas;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private DataGridView dgvPagos;
        private ComboBox cbMetodoPago;
        private Label label5;
        private ComboBox cbEstadoPago;
        private Label label8;
        private TextBox txtCitaId;
        private Label label2;
        private Label label4;
        private TextBox txtMonto;
        private Label label3;
        private DateTimePicker dtpFecha;
        private Panel pnDGVCitas;
        private Panel pnForm;
        private Panel panel1;
    }
}