namespace clinica_dental_ev03
{
    partial class CitaForm
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
            cbEstado = new ComboBox();
            dgvCitas = new DataGridView();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtRun = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dtpFechaCita = new DateTimePicker();
            dtpHoraCita = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            SuspendLayout();
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Programada", "Completada", "Cancelada", "Reprogramada" });
            cbEstado.Location = new Point(160, 130);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(150, 23);
            cbEstado.TabIndex = 34;
            // 
            // dgvCitas
            // 
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(370, 100);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.Size = new Size(560, 253);
            dgvCitas.TabIndex = 33;
            dgvCitas.Text = "dataGridView1";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(155, 280);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 32;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(235, 250);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 23);
            btnGuardar.TabIndex = 31;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(75, 250);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label7
            // 
            label7.Location = new Point(50, 190);
            label7.Name = "label7";
            label7.Size = new Size(100, 23);
            label7.TabIndex = 28;
            label7.Text = "Hora:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Location = new Point(50, 160);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 26;
            label6.Text = "Fecha:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Location = new Point(50, 130);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 25;
            label5.Text = "Estado:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtRun
            // 
            txtRun.Location = new Point(160, 100);
            txtRun.Name = "txtRun";
            txtRun.Size = new Size(150, 23);
            txtRun.TabIndex = 20;
            txtRun.TextChanged += txtRun_TextChanged;
            txtRun.Leave += txtRun_Leave;
            // 
            // label2
            // 
            label2.Location = new Point(50, 100);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 19;
            label2.Text = "Run:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(400, 20);
            label1.Name = "label1";
            label1.Size = new Size(241, 45);
            label1.TabIndex = 18;
            label1.Text = "Formulario Citas";
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.CustomFormat = "dd/MM/yyyy";
            dtpFechaCita.Format = DateTimePickerFormat.Custom;
            dtpFechaCita.Location = new Point(160, 160);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(150, 23);
            dtpFechaCita.TabIndex = 35;
            // 
            // dtpHoraCita
            // 
            dtpHoraCita.Format = DateTimePickerFormat.Time;
            dtpHoraCita.Location = new Point(160, 190);
            dtpHoraCita.Name = "dtpHoraCita";
            dtpHoraCita.ShowUpDown = true;
            dtpHoraCita.Size = new Size(150, 23);
            dtpHoraCita.TabIndex = 36;
            dtpHoraCita.Value = new DateTime(2025, 6, 8, 15, 0, 0, 0);
            // 
            // CitaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 411);
            Controls.Add(dtpHoraCita);
            Controls.Add(dtpFechaCita);
            Controls.Add(cbEstado);
            Controls.Add(dgvCitas);
            Controls.Add(btnEliminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnLimpiar);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtRun);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CitaForm";
            Text = "CitaForm";
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbEstado;
        private DataGridView dgvCitas;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtRun;
        private Label label2;
        private Label label1;
        private DateTimePicker dtpFechaCita;
        private DateTimePicker dtpHoraCita;
    }
}