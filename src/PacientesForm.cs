using clinica_dental_ev03.Models;
using System.Drawing.Text;

namespace clinica_dental_ev03;

public partial class PacientesForm : Form
{
    private ClinicaDentalDbContext db = new();
    Helpers h = new();
    string? idPaciente = null;

    public PacientesForm()
    {
        InitializeComponent();
        ShowPacientes();
        LoadSexo();
    }

    private void LoadSexo()
    {
        cbSexo.Items.Clear();
        cbSexo.Items.Add("Femenino");
        cbSexo.Items.Add("Masculino");
        cbSexo.Items.Add("Otro");
        cbSexo.Items.Add("No Responde");
        cbSexo.SelectedIndex = -1; // default.
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        CleanForm();
    }

    private void CleanForm()
    {
        txtRun.Text = String.Empty;
        txtNombres.Text = "";
        txtApellidos.Text = "";
        cbSexo.SelectedIndex = -1;
        cbSexo.Text = "";
        txtTelefono.Text = "";
        txtCorreo.Text = "";
        idPaciente = null;
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        string? err = null;

        if (txtRun.Text.Trim() == "")
        {
            err = "Debes ingresar el 'RUT' del paciente.\n";
        }
        if (txtNombres.Text.Trim() == "")
        {
            err += "Debes ingresar los 'NOMBRES' del paciente.\n";
        }
        if (txtApellidos.Text.Trim() == "")
        {
            err += "Debes ingresar los 'APELLIDOS' del paciente.\n";
        }
        if (cbSexo.Text.Trim() == "")
        {
            err += "Debes seleccionar una opcion.\n";
        }
        if (txtTelefono.Text.Trim() == "")
        {
            err += "Debes ingresar el 'TELEFONO' del paciente.\n";
        }
        if (txtCorreo.Text.Trim() == "")
        {
            err += "Debes ingresar el 'CORREO' del paciente.\n";
        }
        else
        {
            if (!h.ValidarEmail(txtCorreo.Text))
            {
                err += "El 'CORREO' no tiene el formato correcto.\n";
            }
        }
        if (err != null)
        {
            MessageBox.Show(err, "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else
        {
            if (idPaciente == null)
            {
                Paciente newPaciente = new();
                newPaciente.Run = txtRun.Text.Trim();
                newPaciente.Nombre = txtNombres.Text.Trim();
                newPaciente.Apellido = txtApellidos.Text.Trim();
                newPaciente.Sexo = cbSexo.Text.Trim();
                newPaciente.Telefono = txtTelefono.Text.Trim();
                newPaciente.Correo = txtCorreo.Text.Trim();

                db.Pacientes.Add(newPaciente);

                MessageBox.Show("Paciente registrado con exito!");
            }
            else
            {
                Paciente? foundPaciente = db.Pacientes.Find(idPaciente);

                // Realizar estos cambios SIEMPRE Y CUANDO se encuentre un paciente.
                if (foundPaciente != null)
                {
                    foundPaciente.Nombre = txtNombres.Text.Trim();
                    foundPaciente.Apellido = txtApellidos.Text.Trim();
                    foundPaciente.Sexo = cbSexo.Text.Trim();
                    foundPaciente.Telefono = txtTelefono.Text.Trim();
                    foundPaciente.Correo = txtCorreo.Text.Trim();

                    MessageBox.Show("Paciente modificaco con exito!");
                }
            }
            db.SaveChanges();
            CleanForm();
            ShowPacientes();
        }
    }


    private void ShowPacientes()
    {
        var pacientes = db.Pacientes.ToList();
        dgvPacientes.DataSource = pacientes;
        dgvPacientes.Columns[7].Visible = false; // ocultar columna 'citas'.
    }

    private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
    {
        h.SoloNumeros(e);
    }

    private void txtRun_TextChanged(object sender, EventArgs e)
    {
        if (txtRun.Text.Trim() != "" && txtRun.Text.Length > 1)
        {
            txtRun.Text = h.FormatearRun(txtRun.Text);
            txtRun.Select(txtRun.Text.Length, 0); // ubicar el cursor al final del texto.
        }
    }

    private void txtRun_Leave(object sender, EventArgs e)
    {
        if (txtRun.Text.Trim() != "")
        {
            if (!h.ValidarRun(txtRun.Text))
            {
                MessageBox.Show("El Run ingresado no es válido");
            }
            else
            {
                // FirstOrDefault(): retorna la primera coincidencia que encuentre.
                var foundPaciente = db.Pacientes.FirstOrDefault(p => p.Run == txtRun.Text);
                if (foundPaciente != null)
                {
                    MessageBox.Show("El paciente ya se encuentra registrado");
                    txtRun.Text = "";
                }
            }
        }
    }

    private void dgvPacientes_MouseClick(object sender, MouseEventArgs e)
    {
        txtRun.Text = dgvPacientes.CurrentRow.Cells[0].Value.ToString();
        idPaciente = dgvPacientes.CurrentRow.Cells[0].Value.ToString();
        txtNombres.Text = dgvPacientes.CurrentRow.Cells[1].Value.ToString();
        txtApellidos.Text = dgvPacientes.CurrentRow.Cells[2].Value.ToString();
        cbSexo.Text = dgvPacientes.CurrentRow.Cells[3].Value.ToString();
        txtTelefono.Text = dgvPacientes.CurrentRow.Cells[4].Value.ToString();
        txtCorreo.Text = dgvPacientes.CurrentRow.Cells[5].Value.ToString();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (idPaciente != null)
        {
            var resp = MessageBox.Show($"Desea eliminar el paciente de RUT: {txtRun.Text}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resp == DialogResult.Yes)
            {
                Paciente foundPaciente = db.Pacientes.Find(idPaciente);
                if (foundPaciente != null)
                {
                    db.Pacientes.Remove(foundPaciente);
                    db.SaveChanges();
                    CleanForm();
                    ShowPacientes();
                }
            }
        }
    }
}