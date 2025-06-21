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
            cbEstados = new ComboBox();
            dgvCitas = new DataGridView();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtRun = new TextBox();
            label2 = new Label();
            dtpFechaCita = new DateTimePicker();
            dtpHoraCita = new DateTimePicker();
            pnForm = new Panel();
            cbDentistas = new ComboBox();
            label1 = new Label();
            pnDGV = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvCitas).BeginInit();
            pnForm.SuspendLayout();
            pnDGV.SuspendLayout();
            SuspendLayout();
            // 
            // cbEstados
            // 
            cbEstados.BackColor = Color.White;
            cbEstados.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstados.FormattingEnabled = true;
            cbEstados.Items.AddRange(new object[] { "Programada", "Completada", "Cancelada", "Reprogramada" });
            cbEstados.Location = new Point(134, 212);
            cbEstados.Margin = new Padding(3, 4, 3, 4);
            cbEstados.Name = "cbEstados";
            cbEstados.Size = new Size(171, 28);
            cbEstados.TabIndex = 34;
            // 
            // dgvCitas
            // 
            dgvCitas.BackgroundColor = Color.White;
            dgvCitas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitas.Location = new Point(0, 50);
            dgvCitas.Name = "dgvCitas";
            dgvCitas.Size = new Size(600, 450);
            dgvCitas.TabIndex = 33;
            dgvCitas.Text = "dataGridView1";
            dgvCitas.MouseClick += dgvCitas_MouseClick;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.IndianRed;
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Nirmala UI", 9F);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(134, 391);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 31);
            btnCancelar.TabIndex = 32;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(52, 143, 108);
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Nirmala UI", 9F);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(238, 391);
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
            btnLimpiar.ForeColor = SystemColors.ControlText;
            btnLimpiar.Location = new Point(30, 391);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(86, 31);
            btnLimpiar.TabIndex = 30;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 324);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 28;
            label7.Text = "Hora";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 272);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 26;
            label6.Text = "Fecha";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 216);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 25;
            label5.Text = "Estado";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtRun
            // 
            txtRun.BackColor = Color.White;
            txtRun.BorderStyle = BorderStyle.FixedSingle;
            txtRun.ForeColor = Color.FromArgb(6, 20, 27);
            txtRun.Location = new Point(134, 110);
            txtRun.Margin = new Padding(3, 4, 3, 4);
            txtRun.Name = "txtRun";
            txtRun.Size = new Size(171, 27);
            txtRun.TabIndex = 20;
            txtRun.TextChanged += txtRun_TextChanged;
            txtRun.Leave += txtRun_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(6, 20, 27);
            label2.Location = new Point(48, 112);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 19;
            label2.Text = "Run";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpFechaCita
            // 
            dtpFechaCita.CustomFormat = "dd/MM/yyyy";
            dtpFechaCita.Format = DateTimePickerFormat.Custom;
            dtpFechaCita.Location = new Point(134, 264);
            dtpFechaCita.Margin = new Padding(3, 4, 3, 4);
            dtpFechaCita.Name = "dtpFechaCita";
            dtpFechaCita.Size = new Size(171, 27);
            dtpFechaCita.TabIndex = 35;
            // 
            // dtpHoraCita
            // 
            dtpHoraCita.Format = DateTimePickerFormat.Time;
            dtpHoraCita.Location = new Point(134, 316);
            dtpHoraCita.Margin = new Padding(3, 4, 3, 4);
            dtpHoraCita.Name = "dtpHoraCita";
            dtpHoraCita.ShowUpDown = true;
            dtpHoraCita.Size = new Size(171, 27);
            dtpHoraCita.TabIndex = 36;
            dtpHoraCita.Value = new DateTime(2025, 6, 8, 15, 0, 0, 0);
            // 
            // pnForm
            // 
            pnForm.Controls.Add(cbDentistas);
            pnForm.Controls.Add(label1);
            pnForm.Controls.Add(dtpHoraCita);
            pnForm.Controls.Add(dtpFechaCita);
            pnForm.Controls.Add(cbEstados);
            pnForm.Controls.Add(btnCancelar);
            pnForm.Controls.Add(btnGuardar);
            pnForm.Controls.Add(btnLimpiar);
            pnForm.Controls.Add(label7);
            pnForm.Controls.Add(label6);
            pnForm.Controls.Add(label5);
            pnForm.Controls.Add(txtRun);
            pnForm.Controls.Add(label2);
            pnForm.Dock = DockStyle.Left;
            pnForm.Location = new Point(0, 0);
            pnForm.Margin = new Padding(3, 4, 3, 4);
            pnForm.Name = "pnForm";
            pnForm.Size = new Size(350, 550);
            pnForm.TabIndex = 39;
            // 
            // cbDentistas
            // 
            cbDentistas.BackColor = SystemColors.Window;
            cbDentistas.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDentistas.FormattingEnabled = true;
            cbDentistas.Items.AddRange(new object[] { "Programada", "Completada", "Cancelada", "Reprogramada" });
            cbDentistas.Location = new Point(134, 162);
            cbDentistas.Margin = new Padding(3, 4, 3, 4);
            cbDentistas.Name = "cbDentistas";
            cbDentistas.Size = new Size(171, 28);
            cbDentistas.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 166);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 39;
            label1.Text = "Dentista";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnDGV
            // 
            pnDGV.Controls.Add(dgvCitas);
            pnDGV.Dock = DockStyle.Right;
            pnDGV.Location = new Point(350, 0);
            pnDGV.Margin = new Padding(3, 4, 3, 4);
            pnDGV.Name = "pnDGV";
            pnDGV.Size = new Size(650, 550);
            pnDGV.TabIndex = 40;
            // 
            // CitaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 550);
            Controls.Add(pnDGV);
            Controls.Add(pnForm);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CitaForm";
            Text = "CitaForm";
            ((System.ComponentModel.ISupportInitialize)dgvCitas).EndInit();
            pnForm.ResumeLayout(false);
            pnForm.PerformLayout();
            pnDGV.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbEstados;
        private DataGridView dgvCitas;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtRun;
        private Label label2;
        private DateTimePicker dtpFechaCita;
        private DateTimePicker dtpHoraCita;
        private Panel pnForm;
        private Panel pnDGV;
        private ComboBox cbDentistas;
        private Label label1;
    }
}