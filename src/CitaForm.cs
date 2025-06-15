using clinica_dental_ev03.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
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
            LoadDentistas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void CleanForm()
        {
            txtRun.Text = "";
            cbDentistas.SelectedIndex = -1;
            cbDentistas.Text = "";
            cbEstados.SelectedIndex = -1;
            cbEstados.Text = "";
            dtpFechaCita.Value = DateTime.Now;
            dtpHoraCita.Value = DateTime.Now;
            idCita = null;
        }

        private void LoadEstadoCita()
        {
            cbEstados.Items.Clear();
            cbEstados.Items.Add("Cancelada");
            cbEstados.Items.Add("Completada");
            cbEstados.Items.Add("Programada");
            cbEstados.Items.Add("Reprogramada");
            cbEstados.SelectedIndex = -1; // default.
        }

        private void LoadDentistas()
        {
            var empleadosDentistas = db.Empleados
                .Include(e => e.TipoEmpleado)
                .Where(e => e.TipoEmpleado.Nombre == "Dentista")
                .ToList();

            cbDentistas.DataSource = empleadosDentistas;
            cbDentistas.DisplayMember = "Nombre";
            cbDentistas.ValueMember = "Run";
            cbDentistas.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string? err = null;
            if (txtRun.Text == "")
            {
                err = "Debe ingresar el 'RUN' del paciente.\n";
            }
            if (cbEstados.Text == "")
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

                if (idCita == null)
                {
                    Cita newCita = new();
                    newCita.RunPaciente = txtRun.Text;
                    newCita.DentistaId = cbDentistas.SelectedValue.ToString();
                    newCita.Estado = cbEstados.Text;
                    newCita.Fecha = fechaCita;
                    newCita.Hora = horaCita;
                    newCita.CreadoPor = LoginForm.empleadoRun;

                    db.Citas.Add(newCita);

                    MessageBox.Show("Cita registrada con exito!");
                }
                else
                {
                    Cita? foundCita = db.Citas.Find(idCita);
                    if (foundCita != null)
                    {
                        foundCita.RunPaciente = txtRun.Text;
                        foundCita.DentistaId = cbDentistas.SelectedValue.ToString();
                        foundCita.Estado = cbEstados.Text;
                        foundCita.Fecha = fechaCita;
                        foundCita.Hora = horaCita;
                        foundCita.CreadoPor = LoginForm.empleadoRun;
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
            dgvCitas.Columns[0].Visible = false;
            dgvCitas.Columns[6].Visible = false;
            dgvCitas.Columns[7].Visible = false;
            dgvCitas.Columns[8].Visible = false;
            dgvCitas.Columns[9].Visible = false;
            dgvCitas.Columns[10].Visible = false;
            dgvCitas.Columns[11].Visible = false;
        }

        private void txtRun_TextChanged(object sender, EventArgs e)
        {
            if (txtRun.Text.Trim() != "" && txtRun.Text.Length > 1)
            {
                txtRun.Text = h.FormatearRun(txtRun.Text);
                txtRun.Select(txtRun.Text.Length, 0);
            }
        }

        private void txtRun_Leave(object sender, EventArgs e)
        {
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

        private void dgvCitas_MouseClick(object sender, MouseEventArgs e)
        {
            idCita = int.Parse(dgvCitas.CurrentRow.Cells[0].Value.ToString());
            txtRun.Text = dgvCitas.CurrentRow.Cells[1].Value.ToString();
            cbDentistas.Text = dgvCitas.CurrentRow.Cells[2].Value.ToString();
            cbEstados.Text = dgvCitas.CurrentRow.Cells[3].Value.ToString();
            DateOnly fechaRegistro = DateOnly.Parse(dgvCitas.CurrentRow.Cells[4].Value.ToString());
            dtpFechaCita.Value = fechaRegistro.ToDateTime(TimeOnly.MinValue);
            TimeOnly horaRegistro = TimeOnly.Parse(dgvCitas.CurrentRow.Cells[5].Value.ToString());
            dtpHoraCita.Value = DateTime.Today.Add(horaRegistro.ToTimeSpan());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idCita != null)
            {
                var resp = MessageBox.Show($"Desea cancelar la cita del paciente de RUT: {txtRun.Text}?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resp == DialogResult.Yes)
                {
                    Cita? foundCita = db.Citas.Find(idCita);
                    if (foundCita != null)
                    {
                        foundCita.Estado = "Cancelada";

                        db.SaveChanges();
                        CleanForm();
                        ShowCitas();
                    }
                }
            }
        }
    }
}
