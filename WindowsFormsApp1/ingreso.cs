using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ingreso : Form
    {
        public ingreso()
        {
            InitializeComponent();
        }

        private void btnIniciarSesionIngreso_Click(object sender, EventArgs e)
        {
            if (validarUsuario())
            {
                RequisitosPaciente requisitosPaciente = new RequisitosPaciente();
                requisitosPaciente.Show();
                Hide();
            }

            else
            {
                MessageBox.Show("Los datos de autentificación no son válidos.", "¡Atención!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool validarUsuario()
        {
            if (txtUsuario.Text != "admin" && txtContraseña.Text != "123")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
