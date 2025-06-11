using clinica_dental_ev03.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinica_dental_ev03
{
    public partial class CitaForm : Form
    {
        ClinicaDentalDbContext db = new();
        Helpers h = new();
        int? idCita = null;

        public CitaForm()
        {
            InitializeComponent();
            ShowCitas();
            LoadEstadoCita();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void CleanForm()
        {
            txtRun.Text = "";
            cbEstado.SelectedIndex = -1;
            dtpFechaCita.Value = DateTime.Now;
            dtpHoraCita.Value = DateTime.Now;
            idCita = null;
        }

        private void LoadEstadoCita()
        {
            cbEstado.Items.Clear();
            cbEstado.Items.Add("Cancelada");
            cbEstado.Items.Add("Completada");
            cbEstado.Items.Add("Programada");
            cbEstado.Items.Add("Reprogramada");
            cbEstado.SelectedIndex = -1; // default.
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validacion de inputs form
            string? err = null;
            if (txtRun.Text == "")
            {
                err = "Debe ingresar el 'RUN' del paciente.\n";
            }
            if (cbEstado.Text == "")
            {
                err += "Debe ingresar un 'ESTADO' de la cita.\n";

            }
            if (err != null)
            {
                MessageBox.Show(err, "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateOnly fechaCita = DateOnly.FromDateTime(dtpFechaCita.Value);
                TimeOnly horaCita = TimeOnly.FromDateTime(dtpHoraCita.Value);

                // TODO: implementar LoginForm, para obtener el DentistaID.

                if (idCita == null)
                {
                    // Crear una nueva cita ...
                    Cita newCita = new();
                    newCita.RunPaciente = txtRun.Text;
                    // DentistaID
                    newCita.Estado = cbEstado.Text;
                    newCita.Fecha = fechaCita;
                    newCita.Hora = horaCita;

                    db.Citas.Add(newCita);

                    MessageBox.Show("Cita registrada con exito!");
                }
                else
                {
                    // Modificar una cita ...
                    Cita? foundCita = db.Citas.Find(idCita);
                    if (foundCita != null)
                    {
                        foundCita.RunPaciente = txtRun.Text;
                        // DentistaID
                        foundCita.Estado = cbEstado.Text;
                        // FechaCita
                        foundCita.Fecha = fechaCita;
                        foundCita.Hora = horaCita;
                    }

                    MessageBox.Show("Cita modificada con exito!");
                }
                db.SaveChanges();
                CleanForm();
                ShowCitas();
            }
        }

        private void ShowCitas()
        {
            var citas = db.Citas.ToList();
            dgvCitas.DataSource = citas;
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
            // Early return ...
            if (txtRun.Text.Trim() == "")
            {
                return;
            }

            if (!h.ValidarRun(txtRun.Text))
            {
                MessageBox.Show("El Run ingresado no es válido");
            }
            else
            {
                // FirstOrDefault(): retorna la primera coincidencia que encuentre.
                var foundPaciente = db.Pacientes.FirstOrDefault(p => p.Run == txtRun.Text);
                if (foundPaciente == null)
                {
                    MessageBox.Show($"El RUN no se encuentra registrado!");
                    txtRun.Text = "";
                }
            }
        }

        // TODO: Metodo - cargar datos del DGV al formulario.
        // TODO: Metodo - eliminar una cita.
    }
}
