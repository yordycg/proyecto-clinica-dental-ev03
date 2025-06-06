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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        txtRut = new System.Windows.Forms.TextBox();
        txtNombres = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        txtApellidos = new System.Windows.Forms.TextBox();
        label4 = new System.Windows.Forms.Label();
        txtSexo = new System.Windows.Forms.TextBox();
        label5 = new System.Windows.Forms.Label();
        txtTelefono = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        txtCorreo = new System.Windows.Forms.TextBox();
        label7 = new System.Windows.Forms.Label();
        btnLimpiar = new System.Windows.Forms.Button();
        btnGuardar = new System.Windows.Forms.Button();
        btnEliminar = new System.Windows.Forms.Button();
        dgvPacientes = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(400, 20);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(241, 45);
        label1.TabIndex = 0;
        label1.Text = "Formulario Pacientes";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(50, 100);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 1;
        label2.Text = "Rut:";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtRut
        // 
        txtRut.Location = new System.Drawing.Point(160, 100);
        txtRut.Name = "txtRut";
        txtRut.Size = new System.Drawing.Size(150, 23);
        txtRut.TabIndex = 2;
        // 
        // txtNombres
        // 
        txtNombres.Location = new System.Drawing.Point(160, 130);
        txtNombres.Name = "txtNombres";
        txtNombres.Size = new System.Drawing.Size(150, 23);
        txtNombres.TabIndex = 4;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(50, 130);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 23);
        label3.TabIndex = 3;
        label3.Text = "Nombre:";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtApellidos
        // 
        txtApellidos.Location = new System.Drawing.Point(160, 160);
        txtApellidos.Name = "txtApellidos";
        txtApellidos.Size = new System.Drawing.Size(150, 23);
        txtApellidos.TabIndex = 6;
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(50, 160);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(100, 23);
        label4.TabIndex = 5;
        label4.Text = "Apellidos:";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtSexo
        // 
        txtSexo.Location = new System.Drawing.Point(160, 190);
        txtSexo.Name = "txtSexo";
        txtSexo.Size = new System.Drawing.Size(150, 23);
        txtSexo.TabIndex = 8;
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(50, 190);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(100, 23);
        label5.TabIndex = 7;
        label5.Text = "Sexo:";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtTelefono
        // 
        txtTelefono.Location = new System.Drawing.Point(160, 220);
        txtTelefono.Name = "txtTelefono";
        txtTelefono.Size = new System.Drawing.Size(150, 23);
        txtTelefono.TabIndex = 10;
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(50, 220);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(100, 23);
        label6.TabIndex = 9;
        label6.Text = "Telefono:";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // txtCorreo
        // 
        txtCorreo.Location = new System.Drawing.Point(160, 250);
        txtCorreo.Name = "txtCorreo";
        txtCorreo.Size = new System.Drawing.Size(150, 23);
        txtCorreo.TabIndex = 12;
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(50, 250);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(100, 23);
        label7.TabIndex = 11;
        label7.Text = "Correo:";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
        // 
        // btnLimpiar
        // 
        btnLimpiar.Location = new System.Drawing.Point(90, 300);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new System.Drawing.Size(75, 23);
        btnLimpiar.TabIndex = 13;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.UseVisualStyleBackColor = true;
        // 
        // btnGuardar
        // 
        btnGuardar.Location = new System.Drawing.Point(235, 300);
        btnGuardar.Name = "btnGuardar";
        btnGuardar.Size = new System.Drawing.Size(75, 23);
        btnGuardar.TabIndex = 14;
        btnGuardar.Text = "Guardar";
        btnGuardar.UseVisualStyleBackColor = true;
        // 
        // btnEliminar
        // 
        btnEliminar.Location = new System.Drawing.Point(160, 330);
        btnEliminar.Name = "btnEliminar";
        btnEliminar.Size = new System.Drawing.Size(75, 23);
        btnEliminar.TabIndex = 15;
        btnEliminar.Text = "Eliminar";
        btnEliminar.UseVisualStyleBackColor = true;
        // 
        // dgvPacientes
        // 
        dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvPacientes.Location = new System.Drawing.Point(370, 100);
        dgvPacientes.Name = "dgvPacientes";
        dgvPacientes.Size = new System.Drawing.Size(560, 253);
        dgvPacientes.TabIndex = 16;
        dgvPacientes.Text = "dataGridView1";
        // 
        // PacientesForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(984, 411);
        Controls.Add(dgvPacientes);
        Controls.Add(btnEliminar);
        Controls.Add(btnGuardar);
        Controls.Add(btnLimpiar);
        Controls.Add(txtCorreo);
        Controls.Add(label7);
        Controls.Add(txtTelefono);
        Controls.Add(label6);
        Controls.Add(txtSexo);
        Controls.Add(label5);
        Controls.Add(txtApellidos);
        Controls.Add(label4);
        Controls.Add(txtNombres);
        Controls.Add(label3);
        Controls.Add(txtRut);
        Controls.Add(label2);
        Controls.Add(label1);
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

    private System.Windows.Forms.TextBox txtRut;
    private System.Windows.Forms.TextBox txtNombres;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtApellidos;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtSexo;
    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    #endregion
}