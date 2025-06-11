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
    public partial class MenuForm : Form
    {
        Form formActivo;
        Button btnActivo;

        public MenuForm()
        {
            InitializeComponent();
        }

        private void OpenForm(Form formHijo, object sender, string nombre)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }

            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;

            pnCentral.Controls.Add(formHijo);
            pnCentral.Tag = formHijo;

            formHijo.BringToFront();
            formHijo.Show();
            lblTitulo.Text = nombre;
            botonActivado(sender);
        }

        private void botonActivado(object sender)
        {
            botonDesactivado();
            if (btnActivo != sender)
            {
                btnActivo = (Button)sender;
            }

            btnActivo.BackColor = Color.White;
            btnActivo.ForeColor = Color.MidnightBlue;
        }

        private void botonDesactivado()
        {
            foreach (Control btn in pnMenu.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.MidnightBlue;
                    btn.ForeColor = Color.White;
                }
            }
        }


        private void btnFormEmpleados_Click(object sender, EventArgs e)
        {
            OpenForm(new EmpleadosForm(), sender, "Gestion de Empleados"); ;
        }

        private void btnFormUsuarios_Click(object sender, EventArgs e)
        {
            OpenForm(new UsuarioForm(), sender, "Gestion de Usuarios"); ;
        }

        private void btnFormPacientes_Click(object sender, EventArgs e)
        {
            OpenForm(new PacientesForm(), sender, "Gestion de Pacientes"); ;
        }

        private void btnFormServicios_Click(object sender, EventArgs e)
        {
            OpenForm(new ServiciosForm(), sender, "Gestion de Servicios"); ;
        }

        private void btnFormPagos_Click(object sender, EventArgs e)
        {
            // TODO: implementar formulario!
            MessageBox.Show("Falta IMPLEMENTAR");
        }

        private void btnFormCitas_Click(object sender, EventArgs e)
        {
            // TODO: implementar formulario, esta a media!
            MessageBox.Show("Falta TERMINAR");

        }
    }
}
