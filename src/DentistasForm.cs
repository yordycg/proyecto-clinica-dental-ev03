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
    public partial class DentistasForm : Form
    {
        ClinicaDentalDbContext db = new();
        Helpers h = new();
        int? idDentista = null;

        public DentistasForm()
        {
            InitializeComponent();
            ShowDentistas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void CleanForm()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            idDentista = null;
        }

        private void ShowDentistas()
        {
            var dentistas = db.Dentistas.ToList();
            dgvDentistas.DataSource = dentistas;
            dgvDentistas.Columns[6].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string? err = null;
            if (txtNombre.Text.Trim() == "")
            {
                err = "Debe ingresar el 'NOMBRE' del dentista.\n";
            }
            if (txtApellido.Text.Trim() == "")
            {
                err += "Debe ingresar el 'APELLIDO' del dentista.\n";
            }
            if (txtTelefono.Text.Trim() == "")
            {
                err += "Debe ingresar el 'TELEFONO' del dentista.\n";
            }
            if (txtCorreo.Text.Trim() == "")
            {
                err += "Debe ingresar el 'CORREO' del dentista.\n";
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
                if (idDentista == null)
                {
                    Dentista newDentista = new();
                    newDentista.Nombre = txtNombre.Text.Trim();
                    newDentista.Apellido = txtApellido.Text.Trim();
                    newDentista.Telefono = txtTelefono.Text.Trim();
                    newDentista.Correo = txtCorreo.Text.Trim();

                    db.Dentistas.Add(newDentista);
                }
                else
                {
                    Dentista? foundDentista = db.Dentistas.Find(idDentista);

                    if (foundDentista != null)
                    {
                        foundDentista.Nombre = txtNombre.Text.Trim();
                        foundDentista.Apellido = txtApellido.Text.Trim();
                        foundDentista.Telefono = txtTelefono.Text.Trim();
                        foundDentista.Correo = txtCorreo.Text.Trim();
                    }
                }
                db.SaveChanges();
                MessageBox.Show("Dentista registrado con exito!");
                CleanForm();
                ShowDentistas();
            }

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            h.SoloNumeros(e);
        }

        private void dgvDentistas_MouseClick(object sender, MouseEventArgs e)
        {
            idDentista = int.Parse(dgvDentistas.CurrentRow.Cells[0].Value.ToString());
            txtNombre.Text = dgvDentistas.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvDentistas.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = dgvDentistas.CurrentRow.Cells[3].Value.ToString();
            txtCorreo.Text = dgvDentistas.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idDentista != null)
            {
                var resp = MessageBox.Show($"Desea eliminar el dentista de nombre: {txtNombre.Text}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resp == DialogResult.Yes)
                {
                    var foundDentista = db.Dentistas.Find(idDentista);

                    if (foundDentista != null)
                    {
                        db.Dentistas.Remove(foundDentista);
                        db.SaveChanges();
                        CleanForm();
                        ShowDentistas();
                    }
                }
            }
        }
    }
}
