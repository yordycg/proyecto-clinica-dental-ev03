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
    public partial class EmpleadosForm : Form
    {
        ClinicaDentalDbContext db = new();
        Helpers h = new();
        string? runEmpleado = null;

        public EmpleadosForm()
        {
            InitializeComponent();
            ShowEmpleados();
            LoadTiposEmpleados();
        }

        private void LoadTiposEmpleados()
        {
            var tiposEmpleados = db.TiposEmpleados.ToList();
            cbTipoEmpleado.DataSource = tiposEmpleados;
            cbTipoEmpleado.DisplayMember = "Nombre";
            cbTipoEmpleado.ValueMember = "TipoId";
            cbTipoEmpleado.SelectedIndex = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void CleanForm()
        {
            txtRun.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            cbTipoEmpleado.SelectedIndex = -1;
            cbSexo.SelectedIndex = -1;
            cbSexo.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            runEmpleado = null;
        }

        private void ShowEmpleados()
        {
            var empleados = db.Empleados.ToList();
            dgvEmpleados.DataSource = empleados;
            dgvEmpleados.Columns[8].Visible = false;
            dgvEmpleados.Columns[9].Visible = false;
            dgvEmpleados.Columns[10].Visible = false;
            dgvEmpleados.Columns[11].Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string? err = null;
            if (txtRun.Text.Trim() == "")
            {
                err = "Debe ingresar el 'RUN' del empleado.\n";
            }
            if (txtNombre.Text.Trim() == "")
            {
                err += "Debe ingresar el 'NOMBRE' del empleado.\n";
            }
            if (txtApellido.Text.Trim() == "")
            {
                err += "Debe ingresar el 'APELLIDO' del empleado.\n";
            }
            if (cbTipoEmpleado.Text.Trim() == "")
            {
                err += "Debe seleccionar una opcion.\n";
            }
            if (cbSexo.Text.Trim() == "")
            {
                err += "Debe seleccionar una opcion.\n";
            }
            if (txtTelefono.Text.Trim() == "")
            {
                err += "Debe ingresar el 'TELEFONO' del empleado.\n";
            }
            if (txtCorreo.Text.Trim() == "")
            {
                err += "Debe ingresar el 'CORREO' del empleado.\n";
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
                if (runEmpleado == null)
                {
                    Empleado newEmpleado = new();
                    newEmpleado.Run = txtRun.Text.Trim();
                    newEmpleado.Nombre = txtNombre.Text.Trim();
                    newEmpleado.Apellido = txtApellido.Text.Trim();
                    newEmpleado.TipoEmpleadoId = int.Parse(cbTipoEmpleado.SelectedValue.ToString());
                    newEmpleado.Sexo = cbSexo.Text.Trim()[0].ToString();
                    newEmpleado.Telefono = txtTelefono.Text.Trim();
                    newEmpleado.Correo = txtCorreo.Text.Trim();

                    db.Empleados.Add(newEmpleado);
                    MessageBox.Show("Empleado registrado con exito!");
                }
                else
                {
                    Empleado? foundDentista = db.Empleados.Find(runEmpleado);

                    if (foundDentista != null)
                    {
                        foundDentista.Nombre = txtNombre.Text.Trim();
                        foundDentista.Apellido = txtApellido.Text.Trim();
                        foundDentista.Telefono = txtTelefono.Text.Trim();
                        foundDentista.Correo = txtCorreo.Text.Trim();

                        MessageBox.Show("Empleado modificado con exito!");
                    }
                }
                db.SaveChanges();
                CleanForm();
                ShowEmpleados();
            }
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
                txtRun.Select(txtRun.Text.Length, 0);
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
                    var foundEmpleado = db.Empleados.FirstOrDefault(x => x.Run == txtRun.Text);
                    if (foundEmpleado != null)
                    {
                        MessageBox.Show("El empleado ya se encuentra registrado");
                        txtRun.Text = "";
                    }
                }
            }
        }


        private void dgvDentistas_MouseClick(object sender, MouseEventArgs e)
        {
            runEmpleado = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtRun.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
            cbTipoEmpleado.SelectedValue = int.Parse(dgvEmpleados.CurrentRow.Cells[3].Value.ToString());
            cbSexo.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtTelefono.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
            txtCorreo.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (runEmpleado != null)
            {
                var respEmpleado = MessageBox.Show($"Desea eliminar el dentista de nombre: {txtNombre.Text}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respEmpleado == DialogResult.Yes)
                {
                    var foundEmpleado = db.Empleados.Find(runEmpleado);

                    if (foundEmpleado != null)
                    {
                        // Verificar existencias de CITAS asociadas al registro.
                        var citasAsociadas = db.Citas.Any(c => c.DentistaId == runEmpleado);

                        if (citasAsociadas)
                        {
                            var respCitas = MessageBox.Show("El empleado tiene citas asociadas. " +
                               "¿Desea eliminar también las citas?",
                               "Citas asociadas", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (respCitas == DialogResult.Yes)
                            {
                                var citas = db.Citas.Where(c => c.DentistaId == runEmpleado);
                                db.Citas.RemoveRange(citas);
                                db.SaveChanges();
                            }
                            else
                            {
                                return;
                            }
                        }

                        db.Empleados.Remove(foundEmpleado);
                        db.SaveChanges();
                        CleanForm();
                        ShowEmpleados();
                    }
                }
            }
        }

    }
}
