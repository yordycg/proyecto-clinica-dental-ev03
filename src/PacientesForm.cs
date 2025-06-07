using clinica_dental_ev03.Models;
using System.Drawing.Text;

namespace clinica_dental_ev03;

public partial class PacientesForm : Form
{
    private ClinicaDentalDbContext db = new();
    string? idPaciente = null;

    public PacientesForm()
    {
        InitializeComponent();
        ShowPacientes();
    }

    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        CleanForm();
    }

    private void CleanForm()
    {
        txtRut.Text = String.Empty;
        txtNombres.Text = "";
        txtApellidos.Text = "";
        cbSexo.Text = "";
        txtTelefono.Text = "";
        txtCorreo.Text = "";
        idPaciente = null;
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        string? err = null;

        if (txtRut.Text.Trim() == "")
            err = "Debes ingresar el 'RUT' del paciente.\n";
        if (txtNombres.Text.Trim() == "")
            err += "Debes ingresar los 'NOMBRES' del paciente.\n";
        if (txtApellidos.Text.Trim() == "")
            err += "Debes ingresar los 'APELLIDOS' del paciente.\n";
        if (cbSexo.Text.Trim() == "")
            err += "Debes seleccionar el 'SEXO' del paciente.\n";
        if (txtTelefono.Text.Trim() == "")
            err += "Debes ingresar el 'TELEFONO' del paciente.\n";
        if (txtCorreo.Text.Trim() == "")
            err += "Debes ingresar el 'CORREO' del paciente.\n";
        if (err != null)
            MessageBox.Show(
                err,
                "Error de Validacion",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        else
        {
            if (idPaciente == null)
            {
                Paciente newPaciente = new();
                newPaciente.Rut = txtRut.Text.Trim();
                newPaciente.Nombre = txtNombres.Text.Trim();
                newPaciente.Apellido = txtApellidos.Text.Trim();
                // Retornar la inicial de la opcion seleccionada.
                newPaciente.Sexo = cbSexo.Text.Trim()[0].ToString();
                newPaciente.Telefono = txtTelefono.Text.Trim();
                newPaciente.Correo = txtCorreo.Text.Trim();

                db.Pacientes.Add(newPaciente);
            }
            else
            {
                Paciente? foundPaciente = db.Pacientes.Find(idPaciente);

                // Realizar estos cambios SIEMPRE Y CUANDO se encuentre un paciente.
                if (foundPaciente != null)
                {
                    foundPaciente.Nombre = txtNombres.Text.Trim();
                    foundPaciente.Apellido = txtApellidos.Text.Trim();
                    foundPaciente.Sexo = cbSexo.Text.Trim()[0].ToString();
                    foundPaciente.Telefono = txtTelefono.Text.Trim();
                    foundPaciente.Correo = txtCorreo.Text.Trim();
                }
            }
            db.SaveChanges();
            MessageBox.Show("Paciente registrado con exito!");
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
}