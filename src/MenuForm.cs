using clinica_dental_ev03.Models;
using Microsoft.EntityFrameworkCore;
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
        ClinicaDentalDbContext db = new();
        string? tipoEmpleadoActual = null;
        Form formActivo;
        Button btnActivo;

        public MenuForm()
        {
            InitializeComponent();
            LoadDataEmpleado();
        }

        private void LoadDataEmpleado()
        {
            Empleado? empleadoActual = db.Empleados
                .Include(e => e.TipoEmpleado)
                .FirstOrDefault(e => e.Run == LoginForm.empleadoRun);

            if (empleadoActual != null)
            {
                tipoEmpleadoActual = empleadoActual.TipoEmpleado.Nombre;
                lblTipoEmpleado.Text = tipoEmpleadoActual;

                switch (tipoEmpleadoActual.ToLower())
                {
                    // "admin": puede ver todo.
                    case "auxiliar":
                    case "dentista":
                    btnFormPagos.Visible = false;
                    btnFormEmpleados.Visible = false;
                    break;
                    case "secretari@":
                    btnFormEmpleados.Visible = false;
                    btnFormUsuarios.Visible = false;
                    break;
                }
            }
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

            // 52, 143, 108
            btnActivo.BackColor = Color.White;
            btnActivo.ForeColor = Color.FromArgb(52, 143, 108);
        }

        private void botonDesactivado()
        {
            foreach (Control btn in pnMenu.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    btn.BackColor = Color.FromArgb(52, 143, 108);
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
            OpenForm(new PagosForm(), sender, "Gestion de Pagos");
        }

        private void btnFormCitas_Click(object sender, EventArgs e)
        {
            OpenForm(new CitaForm(), sender, "Gestion de Citas");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var resp = MessageBox.Show("Desea salir del sistema?", "Confirmar Salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resp == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
