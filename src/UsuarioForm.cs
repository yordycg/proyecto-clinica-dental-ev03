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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace clinica_dental_ev03
{
    public partial class UsuarioForm : Form
    {

        ClinicaDentalDbContext db = new();
        Helpers h = new();
        int? idUsuario = null;


        public UsuarioForm()
        {
            InitializeComponent();
            ShowUsuarios();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            CleanForm();
        }

        private void CleanForm()
        {
            txtRun.Text = "";
            txtNombreUsuario.Text = "";
            txtPass.Text = "";
            txtPassRep.Text = "";
            idUsuario = null;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string? err = null;

            if (txtRun.Text.Trim() == "")
            {
                err = "Debe ingresar el 'RUT' del empleado.\n";
            }
            if (txtNombreUsuario.Text.Trim() == "")
            {
                err += "Debe ingresar un 'NOMBRE' del usuario.\n";
            }
            if (txtPass.Text.Trim() == "")
            {
                err += "Debe ingresar Contraseña \n";
            }
            else
            {
                if (txtPass.Text.Trim() != txtPassRep.Text.Trim())
                {
                    err += "Las contraseñas no coinciden \n";
                }
            }
            if (err != null)

            {
                MessageBox.Show(err, "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (idUsuario == null)
                {
                    Usuario newUsuario = new();
                    newUsuario.EmpleadoRun = txtRun.Text.Trim();
                    newUsuario.Nombre = txtNombreUsuario.Text.Trim();
                    newUsuario.Password = txtPass.Text.Trim();

                    db.Usuarios.Add(newUsuario);
                    MessageBox.Show("Usuario registrado con exito!");
                }
                else
                {
                    Usuario? foundUsuario = db.Usuarios.Find(idUsuario);

                    if (foundUsuario != null)
                    {
                        foundUsuario.EmpleadoRun = txtRun.Text.Trim();
                        foundUsuario.Nombre = txtNombreUsuario.Text.Trim();
                        foundUsuario.Password = txtPass.Text.Trim();

                        MessageBox.Show("Usuario modificado con exito!");
                    }
                }
                db.SaveChanges();
                CleanForm();
                ShowUsuarios();
            }
        }



        private void ShowUsuarios()
        {
            var usuarios = db.Usuarios.ToList();
            dgvUsuarios.DataSource = usuarios;
            dgvUsuarios.Columns[0].Visible = false;
            dgvUsuarios.Columns[5].Visible = false;

        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
            if (txtRun.Text.Trim() != "" && txtRun.Text.Length > 1)
            {
                txtRun.Text = h.FormatearRun(txtRun.Text);
                txtRun.Select(txtRun.Text.Length, 0);
            }
        }

        private void txtRut_Leave(object sender, EventArgs e)
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
                    if (foundEmpleado == null)
                    {
                        MessageBox.Show("El empleado no se encuentra registrado. Ir al Formulario de Empleado");
                        txtRun.Text = "";
                    }
                }
            }

        }

        private void dgvUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            idUsuario = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
            txtRun.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtNombreUsuario.Text = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtPass.Text = dgvUsuarios.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idUsuario != null)
            {
                var resp = MessageBox.Show($"Desea eliminar el usuario de rut: {txtRun.Text}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resp == DialogResult.Yes)
                {
                    var foundUsuario = db.Usuarios.Find(idUsuario);

                    if (foundUsuario != null)
                    {
                        db.Usuarios.Remove(foundUsuario);
                        db.SaveChanges();
                        CleanForm();
                        ShowUsuarios();
                    }
                }
            }
        }
    }
}
