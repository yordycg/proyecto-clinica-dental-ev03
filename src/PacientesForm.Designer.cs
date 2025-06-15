namespace clinica_dental_ev03;

partial class PacientesForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        label2 = new Label();
        txtRun = new TextBox();
        txtNombres = new TextBox();
        label3 = new Label();
        txtApellidos = new TextBox();
        label4 = new Label();
        label5 = new Label();
        txtTelefono = new TextBox();
        label6 = new Label();
        txtCorreo = new TextBox();
        label7 = new Label();
        btnLimpiar = new Button();
        btnGuardar = new Button();
        btnEliminar = new Button();
        dgvPacientes = new DataGridView();
        cbSexo = new ComboBox();
        panel1 = new Panel();
        panel2 = new Panel();
        ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // label2
        // 
        label2.Location = new Point(22, 127);
        label2.Name = "label2";
        label2.Size = new Size(100, 23);
        label2.TabIndex = 1;
        label2.Text = "Run";
        label2.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtRun
        // 
        txtRun.Location = new Point(139, 127);
        txtRun.Name = "txtRun";
        txtRun.Size = new Size(150, 23);
        txtRun.TabIndex = 2;
        txtRun.TextChanged += txtRun_TextChanged;
        txtRun.Leave += txtRun_Leave;
        // 
        // txtNombres
        // 
        txtNombres.Location = new Point(139, 165);
        txtNombres.Name = "txtNombres";
        txtNombres.Size = new Size(150, 23);
        txtNombres.TabIndex = 4;
        // 
        // label3
        // 
        label3.Location = new Point(22, 165);
        label3.Name = "label3";
        label3.Size = new Size(100, 23);
        label3.TabIndex = 3;
        label3.Text = "Nombre";
        label3.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtApellidos
        // 
        txtApellidos.BorderStyle = BorderStyle.FixedSingle;
        txtApellidos.Location = new Point(139, 203);
        txtApellidos.Name = "txtApellidos";
        txtApellidos.Size = new Size(150, 23);
        txtApellidos.TabIndex = 6;
        // 
        // label4
        // 
        label4.Location = new Point(22, 203);
        label4.Name = "label4";
        label4.Size = new Size(100, 23);
        label4.TabIndex = 5;
        label4.Text = "Apellido";
        label4.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label5
        // 
        label5.Location = new Point(22, 241);
        label5.Name = "label5";
        label5.Size = new Size(100, 23);
        label5.TabIndex = 7;
        label5.Text = "Sexo";
        label5.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtTelefono
        // 
        txtTelefono.Location = new Point(139, 279);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.Size = new Size(150, 23);
        txtTelefono.TabIndex = 10;
        txtTelefono.KeyPress += txtTelefono_KeyPress;
        // 
        // label6
        // 
        label6.Location = new Point(22, 279);
        label6.Name = "label6";
        label6.Size = new Size(100, 23);
        label6.TabIndex = 9;
        label6.Text = "Telefono";
        label6.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtCorreo
        // 
        txtCorreo.Location = new Point(139, 317);
        txtCorreo.Name = "txtCorreo";
        txtCorreo.Size = new Size(150, 23);
        txtCorreo.TabIndex = 12;
        // 
        // label7
        // 
        label7.Location = new Point(22, 317);
        label7.Name = "label7";
        label7.Size = new Size(100, 23);
        label7.TabIndex = 11;
        label7.Text = "Correo";
        label7.TextAlign = ContentAlignment.MiddleRight;
        // 
        // btnLimpiar
        // 
        btnLimpiar.BackColor = Color.Gainsboro;
        btnLimpiar.FlatAppearance.BorderSize = 0;
        btnLimpiar.FlatStyle = FlatStyle.Flat;
        btnLimpiar.Font = new Font("Nirmala UI", 9F);
        btnLimpiar.Location = new Point(47, 381);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(75, 23);
        btnLimpiar.TabIndex = 13;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.UseVisualStyleBackColor = false;
        btnLimpiar.Click += btnLimpiar_Click;
        // 
        // btnGuardar
        // 
        btnGuardar.BackColor = Color.FromArgb(52, 143, 108);
        btnGuardar.FlatAppearance.BorderSize = 0;
        btnGuardar.FlatStyle = FlatStyle.Flat;
        btnGuardar.Font = new Font("Nirmala UI", 9F);
        btnGuardar.ForeColor = Color.White;
        btnGuardar.Location = new Point(229, 381);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(75, 23);
        btnGuardar.TabIndex = 14;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = false;
        btnGuardar.Click += btnGuardar_Click;
        // 
        // btnEliminar
        // 
        btnEliminar.BackColor = Color.IndianRed;
        btnEliminar.FlatAppearance.BorderSize = 0;
        btnEliminar.FlatStyle = FlatStyle.Flat;
        btnEliminar.Font = new Font("Nirmala UI", 9F);
        btnEliminar.ForeColor = Color.White;
        btnEliminar.Location = new Point(138, 381);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new Size(75, 23);
        btnEliminar.TabIndex = 15;
        btnEliminar.Text = "Eliminar";
        btnEliminar.UseVisualStyleBackColor = false;
        btnEliminar.Click += btnEliminar_Click;
        // 
        // dgvPacientes
        // 
        dgvPacientes.BackgroundColor = Color.White;
        dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPacientes.Location = new Point(0, 50);
        dgvPacientes.Name = "dgvPacientes";
        dgvPacientes.RowHeadersWidth = 51;
        dgvPacientes.Size = new Size(600, 450);
        dgvPacientes.TabIndex = 16;
        dgvPacientes.Text = "dataGridView1";
        dgvPacientes.MouseClick += dgvPacientes_MouseClick;
        // 
        // cbSexo
        // 
        cbSexo.FormattingEnabled = true;
        cbSexo.Location = new Point(139, 241);
        cbSexo.Name = "cbSexo";
        cbSexo.Size = new Size(150, 23);
        cbSexo.TabIndex = 17;
        // 
        // panel1
        // 
        panel1.Controls.Add(cbSexo);
        panel1.Controls.Add(btnEliminar);
        panel1.Controls.Add(btnGuardar);
        panel1.Controls.Add(btnLimpiar);
        panel1.Controls.Add(txtCorreo);
        panel1.Controls.Add(label7);
        panel1.Controls.Add(txtTelefono);
        panel1.Controls.Add(label6);
        panel1.Controls.Add(label5);
        panel1.Controls.Add(txtApellidos);
        panel1.Controls.Add(label4);
        panel1.Controls.Add(txtNombres);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(txtRun);
        panel1.Controls.Add(label2);
        panel1.Dock = DockStyle.Left;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(350, 550);
        panel1.TabIndex = 18;
        // 
        // panel2
        // 
        panel2.Controls.Add(dgvPacientes);
        panel2.Dock = DockStyle.Right;
        panel2.Location = new Point(350, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(650, 550);
        panel2.TabIndex = 19;
        // 
        // PacientesForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1000, 550);
        Controls.Add(panel2);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "PacientesForm";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox txtTelefono;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtCorreo;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btnLimpiar;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.DataGridView dgvPacientes;

    private System.Windows.Forms.TextBox txtRun;
    private System.Windows.Forms.TextBox txtNombres;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtApellidos;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label2;

    #endregion

    private ComboBox cbSexo;
    private Panel panel1;
    private Panel panel2;
}