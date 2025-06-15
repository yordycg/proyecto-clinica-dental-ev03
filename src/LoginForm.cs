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
    public partial class LoginForm : Form
    {
        ClinicaDentalDbContext db = new();
        Helpers h = new();
        public static int? usuarioId = null;
        public static string? empleadoRun = null;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void CleanForm()
        {
            txtUsuario.Text = "";
            txtPass.Text = "";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Logg();
        }

        private void Logg()
        {
            string? err = null;
            if (txtUsuario.Text.Trim() == "")
            {
                err = "Debe ingresar el 'USUARIO'.\n";
            }
            if (txtPass.Text.Trim() == "")
            {
                err += "Debe ingresar 'CONTRASEÑA'.\n";
            }
            if (err != null)
            {
                MessageBox.Show(err, "Error de Validacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var user = db.Usuarios.FirstOrDefault(u => u.Nombre == txtUsuario.Text && u.Password == txtPass.Text); ;

                if (user != null)
                {
                    usuarioId = user.UsuarioId;
                    empleadoRun = user.EmpleadoRun;
                    //MessageBox.Show($"Bienvenido {user.Nombre}", "Ingreso Exitoso!");
                    MenuForm newMenuForm = new();
                    //newMenuForm.WindowState = FormWindowState.Maximized; // abrir en vista maximizada.
                    newMenuForm.Show();
                    CleanForm();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // tecla 'Enter'.
            {
                Logg();
            }
        }
    }
}
