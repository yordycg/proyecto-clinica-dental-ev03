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
        label1 = new Label();
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
        ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        label1.Location = new Point(400, 20);
        label1.Name = "label1";
        label1.Size = new Size(241, 45);
        label1.TabIndex = 0;
        label1.Text = "Formulario Pacientes";
        // 
        // label2
        // 
        label2.Location = new Point(50, 100);
        label2.Name = "label2";
        label2.Size = new Size(100, 23);
        label2.TabIndex = 1;
        label2.Text = "Run:";
        label2.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtRun
        // 
        txtRun.Location = new Point(160, 100);
        txtRun.Name = "txtRun";
        txtRun.Size = new Size(150, 23);
        txtRun.TabIndex = 2;
        txtRun.TextChanged += txtRun_TextChanged;
        txtRun.Leave += txtRun_Leave;
        // 
        // txtNombres
        // 
        txtNombres.Location = new Point(160, 130);
        txtNombres.Name = "txtNombres";
        txtNombres.Size = new Size(150, 23);
        txtNombres.TabIndex = 4;
        // 
        // label3
        // 
        label3.Location = new Point(50, 130);
        label3.Name = "label3";
        label3.Size = new Size(100, 23);
        label3.TabIndex = 3;
        label3.Text = "Nombre:";
        label3.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtApellidos
        // 
        txtApellidos.Location = new Point(160, 160);
        txtApellidos.Name = "txtApellidos";
        txtApellidos.Size = new Size(150, 23);
        txtApellidos.TabIndex = 6;
        // 
        // label4
        // 
        label4.Location = new Point(50, 160);
        label4.Name = "label4";
        label4.Size = new Size(100, 23);
        label4.TabIndex = 5;
        label4.Text = "Apellidos:";
        label4.TextAlign = ContentAlignment.MiddleRight;
        // 
        // label5
        // 
        label5.Location = new Point(50, 190);
        label5.Name = "label5";
        label5.Size = new Size(100, 23);
        label5.TabIndex = 7;
        label5.Text = "Sexo:";
        label5.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtTelefono
        // 
        txtTelefono.Location = new Point(160, 220);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.Size = new Size(150, 23);
        txtTelefono.TabIndex = 10;
        txtTelefono.KeyPress += txtTelefono_KeyPress;
        // 
        // label6
        // 
        label6.Location = new Point(50, 220);
        label6.Name = "label6";
        label6.Size = new Size(100, 23);
        label6.TabIndex = 9;
        label6.Text = "Telefono:";
        label6.TextAlign = ContentAlignment.MiddleRight;
        // 
        // txtCorreo
        // 
        txtCorreo.Location = new Point(160, 250);
        txtCorreo.Name = "txtCorreo";
        txtCorreo.Size = new Size(150, 23);
        txtCorreo.TabIndex = 12;
        // 
        // label7
        // 
        label7.Location = new Point(50, 250);
        label7.Name = "label7";
        label7.Size = new Size(100, 23);
        label7.TabIndex = 11;
        label7.Text = "Correo:";
        label7.TextAlign = ContentAlignment.MiddleRight;
        // 
        // btnLimpiar
        // 
        btnLimpiar.Location = new Point(90, 300);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(75, 23);
        btnLimpiar.TabIndex = 13;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.UseVisualStyleBackColor = true;
        btnLimpiar.Click += btnLimpiar_Click;
        // 
        // btnGuardar
        // 
        btnGuardar.Location = new Point(235, 300);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new Size(75, 23);
        btnGuardar.TabIndex = 14;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = true;
        btnGuardar.Click += btnGuardar_Click;
        // 
        // btnEliminar
        // 
        btnEliminar.Location = new Point(160, 330);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new Size(75, 23);
        btnEliminar.TabIndex = 15;
        btnEliminar.Text = "Eliminar";
        btnEliminar.UseVisualStyleBackColor = true;
        btnEliminar.Click += btnEliminar_Click;
        // 
        // dgvPacientes
        // 
        dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPacientes.Location = new Point(370, 100);
        dgvPacientes.Name = "dgvPacientes";
        dgvPacientes.Size = new Size(560, 253);
        dgvPacientes.TabIndex = 16;
        dgvPacientes.Text = "dataGridView1";
        dgvPacientes.MouseClick += dgvPacientes_MouseClick;
        // 
        // cbSexo
        // 
        cbSexo.FormattingEnabled = true;
        cbSexo.Items.AddRange(new object[] { "Femenino", "Masculino" });
        cbSexo.Location = new Point(160, 190);
        cbSexo.Name = "cbSexo";
        cbSexo.Size = new Size(150, 23);
        cbSexo.TabIndex = 17;
        // 
        // PacientesForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(984, 411);
        Controls.Add(cbSexo);
        Controls.Add(dgvPacientes);
        Controls.Add(btnEliminar);
        Controls.Add(btnGuardar);
        Controls.Add(btnLimpiar);
        Controls.Add(txtCorreo);
        Controls.Add(label7);
        Controls.Add(txtTelefono);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(txtApellidos);
        Controls.Add(label4);
        Controls.Add(txtNombres);
        Controls.Add(label3);
        Controls.Add(txtRun);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "PacientesForm";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
        ResumeLayout(false);
        PerformLayout();
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

    private System.Windows.Forms.Label label1;

    #endregion

    private ComboBox cbSexo;
}