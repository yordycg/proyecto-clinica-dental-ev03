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
    public partial class ServiciosForm : Form
    {
        ClinicaDentalDbContext db = new();
        Helpers h = new();
        int? idServicio = null;

        public ServiciosForm()
        {
            InitializeComponent();
            ShowServicios();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void CleanForm()
        {
            txtNombre.Text = "";
            txtCosto.Text = "";
            txtDuracion.Text = "";
            idServicio = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string? err = null;
            if (txtNombre.Text == "")
            {
                err = "Debes ingresar el 'NOMBRE' del servicio.\n";
            }
            if (txtCosto.Text == "")
            {
                err += "Debes ingresar el 'COSTO' del servicio.\n";
            }
            if (txtDuracion.Text == "")
            {
                err += "Debes ingresar la 'DURACION' del servicio.\n";
            }
            if (err != null)
            {
                MessageBox.Show(err, "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (idServicio == null)
                {
                    Servicio? newServicio = new();
                    if (newServicio != null)
                    {
                        newServicio.Nombre = txtNombre.Text;
                        newServicio.Costo = int.Parse(txtCosto.Text);
                        newServicio.Duracion = int.Parse(txtDuracion.Text);

                        db.Servicios.Add(newServicio);

                        MessageBox.Show("Servicio registrado con exito!");
                    }
                }
                else
                {
                    Servicio? foundServicio = db.Servicios.Find(idServicio);
                    if (foundServicio != null)
                    {
                        foundServicio.Nombre = txtNombre.Text;
                        foundServicio.Costo = int.Parse(txtCosto.Text);
                        foundServicio.Duracion = int.Parse(txtDuracion.Text);

                        MessageBox.Show("Servicio modificado con exito!");
                    }
                }
                db.SaveChanges();
                CleanForm();
                ShowServicios();
            }
        }

        private void ShowServicios()
        {
            var servicios = db.Servicios.ToList();
            dgvServicios.DataSource = servicios;
            dgvServicios.Columns[0].Visible = false;
            dgvServicios.Columns[4].Visible = false;
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            h.SoloNumeros(e);
        }

        private void txtDuracion_KeyPress(object sender, KeyPressEventArgs e)
        {
            h.SoloNumeros(e);
        }

        private void dgvServicios_MouseClick(object sender, MouseEventArgs e)
        {
            idServicio = int.Parse(dgvServicios.CurrentRow.Cells[0].Value.ToString());
            txtNombre.Text = dgvServicios.CurrentRow.Cells[1].Value.ToString();
            txtCosto.Text = dgvServicios.CurrentRow.Cells[2].Value.ToString();
            txtDuracion.Text = dgvServicios.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idServicio != null)
            {
                var resp = MessageBox.Show($"Desea eliminar el servicio de nombre: {txtNombre.Text}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resp == DialogResult.Yes)
                {
                    Servicio? foundServicio = db.Servicios.Find(idServicio);
                    if (foundServicio != null)
                    {
                        db.Servicios.Remove(foundServicio);
                        db.SaveChanges();
                        CleanForm();
                        ShowServicios();
                    }
                }
            }
        }

        private void txtCosto_Leave(object sender, EventArgs e)
        {
            if (txtCosto.Text.Trim() != "")
            {
                if (int.Parse(txtCosto.Text) <= 0)
                {
                    txtCosto.Text = "";
                    MessageBox.Show("El costo debe ser mayor a 0");
                }
            }
        }
    }
}