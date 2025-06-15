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
    public partial class PagosForm : Form
    {
        ClinicaDentalDbContext db = new();
        Helpers h = new();
        int? idPago = null;

        public PagosForm()
        {
            InitializeComponent();
            LoadMetodoPago();
            LoadEstadoPago();
            ShowCitas();
            ShowPagos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void CleanForm()
        {
            txtCitaId.Text = "";
            txtMonto.Text = "";
            dtpFecha.Value = DateTime.Now;
            cbMetodoPago.SelectedIndex = -1;
            cbEstadoPago.SelectedIndex = -1;
            idPago = null;
        }

        private void LoadMetodoPago()
        {
            cbMetodoPago.Items.Clear();
            cbMetodoPago.Items.Add("Efectivo");
            cbMetodoPago.Items.Add("Tarjeta de Credito");
            cbMetodoPago.Items.Add("Transferencia");
            cbMetodoPago.SelectedIndex = -1; // default.
        }

        private void LoadEstadoPago()
        {
            cbEstadoPago.Items.Clear();
            cbEstadoPago.Items.Add("Pagado");
            cbEstadoPago.Items.Add("Pendiente");
            cbEstadoPago.Items.Add("Reembolso");
            cbEstadoPago.SelectedIndex = -1; // default.
        }

        private void ShowCitas()
        {
            var citasCompletadas = db.Citas.Where(c => c.Estado == "Completada").ToList();
            dgvCitas.DataSource = citasCompletadas;
            dgvCitas.Columns[6].Visible = false;
            dgvCitas.Columns[7].Visible = false;
            dgvCitas.Columns[8].Visible = false;
            dgvCitas.Columns[9].Visible = false;
            dgvCitas.Columns[10].Visible = false;
            dgvCitas.Columns[11].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string? err = null;

            if (txtCitaId.Text.Trim() == "")
                err = "Debe seleccionar una 'CITA'.\n";
            if (txtMonto.Text.Trim() == "")
                err += "Debe ingresar un 'MONTO'.\n";
            if (cbMetodoPago.SelectedIndex == -1)
                err += "Debe seleccionar un 'METODO DE PAGO'.\n";
            if (cbEstadoPago.SelectedIndex == -1)
                err += "Debe seleccionar un 'ESTADO DEL PAGO'.\n";

            if (err != null)
            {
                MessageBox.Show(err, "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateOnly fechaPago = DateOnly.FromDateTime(dtpFecha.Value);

                if (idPago == null)
                {
                    Pago newPago = new();
                    newPago.CitaId = int.Parse(txtCitaId.Text);
                    newPago.Monto = int.Parse(txtMonto.Text);
                    newPago.Fecha = dtpFecha.Value;
                    newPago.MetodoPago = cbMetodoPago.Text;
                    newPago.EstadoPago = cbEstadoPago.Text;

                    db.Pagos.Add(newPago);

                    MessageBox.Show("Pago registrado con exito!");
                }
                else
                {
                    Pago? foundPago = db.Pagos.Find(idPago);
                    if (foundPago != null)
                    {
                        foundPago.CitaId = int.Parse(txtCitaId.Text);
                        foundPago.Monto = int.Parse(txtMonto.Text);
                        foundPago.Fecha = dtpFecha.Value;
                        foundPago.MetodoPago = cbMetodoPago.Text;
                        foundPago.EstadoPago = cbEstadoPago.Text;
                    }

                    MessageBox.Show("Pago modificado con exito!");
                }
                db.SaveChanges();
                CleanForm();
                ShowPagos();
            }
        }

        private void ShowPagos()
        {
            var pagos = db.Pagos.ToList();
            dgvPagos.DataSource = pagos;
            dgvPagos.Columns[0].Visible = false;
            dgvPagos.Columns[6].Visible = false;
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            h.SoloNumeros(e);
        }

        private void dgvCitas_MouseClick(object sender, MouseEventArgs e)
        {
            txtCitaId.Text = dgvCitas.CurrentRow.Cells[0].Value.ToString();
        }

        private void dgvPagos_MouseClick(object sender, MouseEventArgs e)
        {
            idPago = int.Parse(dgvPagos.CurrentRow.Cells[0].Value.ToString());
            txtCitaId.Text = dgvPagos.CurrentRow.Cells[1].Value.ToString();
            txtMonto.Text = dgvPagos.CurrentRow.Cells[2].Value.ToString();
            dtpFecha.Value = DateTime.Parse(dgvPagos.CurrentRow.Cells[3].Value.ToString());
            cbMetodoPago.Text = dgvPagos.CurrentRow.Cells[4].Value.ToString();
            cbEstadoPago.Text = dgvPagos.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idPago != null)
            {
                var resp = MessageBox.Show($"Desea cancelar el pago del paciente de RUT: CAMBIAR?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resp == DialogResult.Yes)
                {
                    Pago? foundPago = db.Pagos.Find(idPago);
                    if (foundPago != null)
                    {
                        foundPago.EstadoPago = "Cancelada";

                        db.SaveChanges();
                        CleanForm();
                        ShowPagos();
                    }
                }
            }
        }
    }
}
