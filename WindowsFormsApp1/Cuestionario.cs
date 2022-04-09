using Negocio;
using Repositorio;
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
    public partial class Cuestionario : Form
    {
        public Cuestionario()
        {
            InitializeComponent();
        }

        private void Cuestionario_Load(object sender, EventArgs e)
        {
            var negocio = new MaestroNegocio(new MaestroRepositorio());
            var escala = negocio.ObtenerEscalaX();
            cbxRespuesta1.DataSource = escala;
            cbxRespuesta1.DisplayMember = "Nombre";
            cbxRespuesta1.SelectedItem = null;

            var escala2 = negocio.ObtenerEscalaX();
            cbxRespuesta2.DataSource = escala2;
            cbxRespuesta2.DisplayMember = "Nombre";
            cbxRespuesta2.SelectedItem = null;

            var escala3 = negocio.ObtenerEscalaX();
            cbxRespuesta3.DataSource = escala3;
            cbxRespuesta3.DisplayMember = "Nombre";
            cbxRespuesta3.SelectedItem = null;

            var escala4 = negocio.ObtenerEscalaX();
            cbxRespuesta4.DataSource = escala4;
            cbxRespuesta4.DisplayMember = "Nombre";
            cbxRespuesta4.SelectedItem = null;

            var escala5 = negocio.ObtenerEscalaX();
            cbxRespuesta5.DataSource = escala5;
            cbxRespuesta5.DisplayMember = "Nombre";
            cbxRespuesta5.SelectedItem = null;

            var escala6 = negocio.ObtenerEscalaX();
            cbxRespuesta6.DataSource = escala6;
            cbxRespuesta6.DisplayMember = "Nombre";
            cbxRespuesta6.SelectedItem = null;

            var escala7 = negocio.ObtenerEscalaX();
            cbxRespuesta7.DataSource = escala7;
            cbxRespuesta7.DisplayMember = "Nombre";
            cbxRespuesta7.SelectedItem = null;

            var escala8 = negocio.ObtenerEscalaX();
            cbxRespuesta8.DataSource = escala8;
            cbxRespuesta8.DisplayMember = "Nombre";
            cbxRespuesta8.SelectedItem = null;

            var escala9 = negocio.ObtenerEscalaX();
            cbxRespuesta9.DataSource = escala9;
            cbxRespuesta9.DisplayMember = "Nombre";
            cbxRespuesta9.SelectedItem = null;

            var escala10 = negocio.ObtenerEscalaX();
            cbxRespuesta10.DataSource = escala10;
            cbxRespuesta10.DisplayMember = "Nombre";
            cbxRespuesta10.SelectedItem = null;

            var escala11 = negocio.ObtenerEscalaX();
            cbxRespuesta11.DataSource = escala11;
            cbxRespuesta11.DisplayMember = "Nombre";
            cbxRespuesta11.SelectedItem = null;

            var escala12 = negocio.ObtenerEscalaX();
            cbxRespuesta12.DataSource = escala12;
            cbxRespuesta12.DisplayMember = "Nombre";
            cbxRespuesta12.SelectedItem = null;

            var escala13 = negocio.ObtenerEscalaX();
            cbxRespuesta13.DataSource = escala13;
            cbxRespuesta13.DisplayMember = "Nombre";
            cbxRespuesta13.SelectedItem = null;

            var escala14 = negocio.ObtenerEscalaX();
            cbxRespuesta14.DataSource = escala14;
            cbxRespuesta14.DisplayMember = "Nombre";
            cbxRespuesta14.SelectedItem = null;

            var escala15 = negocio.ObtenerEscalaX();
            cbxRespuesta15.DataSource = escala15;
            cbxRespuesta15.DisplayMember = "Nombre";
            cbxRespuesta15.SelectedItem = null;

            var escala16 = negocio.ObtenerEscalaX();
            cbxRespuesta16.DataSource = escala16;
            cbxRespuesta16.DisplayMember = "Nombre";
            cbxRespuesta16.SelectedItem = null;

            var escala17 = negocio.ObtenerEscalaX();
            cbxRespuesta17.DataSource = escala17;
            cbxRespuesta17.DisplayMember = "Nombre";
            cbxRespuesta17.SelectedItem = null;

            var escala18 = negocio.ObtenerEscalaX();
            cbxRespuesta18.DataSource = escala18;
            cbxRespuesta18.DisplayMember = "Nombre";
            cbxRespuesta18.SelectedItem = null;

            var escala19 = negocio.ObtenerEscalaX();
            cbxRespuesta19.DataSource = escala19;
            cbxRespuesta19.DisplayMember = "Nombre";
            cbxRespuesta19.SelectedItem = null;

            var escala20 = negocio.ObtenerEscalaX();
            cbxRespuesta20.DataSource = escala20;
            cbxRespuesta20.DisplayMember = "Nombre";
            cbxRespuesta20.SelectedItem = null;

            var escala21 = negocio.ObtenerEscalaX();
            cbxRespuesta21.DataSource = escala21;
            cbxRespuesta21.DisplayMember = "Nombre";
            cbxRespuesta21.SelectedItem = null;

        }


        private void btnResultado_Click_1(object sender, EventArgs e)
        {
            int sumaDepresion; int sumaAnsiedad; int sumaEstres;

            sumaDepresion = cbxRespuesta3.SelectedIndex + cbxRespuesta5.SelectedIndex + cbxRespuesta10.SelectedIndex + cbxRespuesta13.SelectedIndex + cbxRespuesta16.SelectedIndex + cbxRespuesta17.SelectedIndex + cbxRespuesta21.SelectedIndex;
            sumaAnsiedad = cbxRespuesta2.SelectedIndex + cbxRespuesta4.SelectedIndex + cbxRespuesta7.SelectedIndex + cbxRespuesta9.SelectedIndex + cbxRespuesta15.SelectedIndex + cbxRespuesta19.SelectedIndex + cbxRespuesta20.SelectedIndex;
            sumaEstres = cbxRespuesta1.SelectedIndex + cbxRespuesta6.SelectedIndex + cbxRespuesta8.SelectedIndex + cbxRespuesta11.SelectedIndex + cbxRespuesta12.SelectedIndex + cbxRespuesta14.SelectedIndex + cbxRespuesta18.SelectedIndex;


            //Determinar grado de depresión
            if (sumaDepresion >= 5 && sumaDepresion <= 6)
            {
                TxtResultadoDepresion.Text = "Depresión leve";
            }

            else if (sumaDepresion > 6 && sumaDepresion <= 10)
            {
                TxtResultadoDepresion.Text = "Depresión moderada";
            }

            else if (sumaDepresion > 10 && sumaDepresion <= 13)
            {
                TxtResultadoDepresion.Text = "Depresión severa";
            }

            else if (sumaDepresion >= 14)
            {
                TxtResultadoDepresion.Text = "Depresión extremadamente severa";
            }

            else
            {
                TxtResultadoDepresion.Text = "No presenta sintomas de depresión";
            }

            //Determinar grado de ansiedad
            if (sumaAnsiedad == 4)
            {
                TxtResultadoAnsiedad.Text = "Ansiedad leve";
            }

            else if (sumaAnsiedad > 4 && sumaAnsiedad <= 7)
            {
                TxtResultadoAnsiedad.Text = "Ansiedad moderada";
            }

            else if (sumaAnsiedad > 7 && sumaAnsiedad <= 9)
            {
                TxtResultadoAnsiedad.Text = "Ansiedad severa";
            }

            else if (sumaAnsiedad >= 10)
            {
                TxtResultadoAnsiedad.Text = "Ansiedad extremadamente severa";
            }

            else
            {
                TxtResultadoAnsiedad.Text = "No presenta sintomas de Ansiedad";
            }

            //Determinar grado de estrés
            if (sumaEstres >= 8 && sumaEstres <= 9)
            {
                TxtResultadoEstres.Text = "Estrés leve";
            }

            else if (sumaEstres > 9 && sumaEstres <= 12)
            {
                TxtResultadoEstres.Text = "Estrés moderada";
            }

            else if (sumaEstres > 12 && sumaEstres <= 16)
            {
                TxtResultadoEstres.Text = "Estrés severo";
            }

            else if (sumaEstres >= 17)
            {
                TxtResultadoEstres.Text = "Estrés extremadamente severo";
            }

            else
            {
                TxtResultadoEstres.Text = "No presenta sintomas de estrés";
            }
        }

        private void btnGuardarCerrarS_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCamposCuestionario())
            {
                Entidad.Cuestionario cuestionario= new Entidad.Cuestionario();
                cuestionario.Respuesta = cbxRespuesta1.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta2.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta3.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta4.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta5.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta6.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta7.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta8.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta9.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta10.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta11.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta12.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta13.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta14.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta15.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta16.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta17.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta18.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta19.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta20.SelectedItem as Entidad.Respuesta;
                cuestionario.Respuesta = cbxRespuesta21.SelectedItem as Entidad.Respuesta;


                ingreso ingreso = new ingreso();
                ingreso.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Hay errores en el cuestionario. Por favor revise",
                   "¡Atención!", MessageBoxButtons.OK,
                   MessageBoxIcon.Error
                   );
            }
        }
           
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private bool ValidarCamposCuestionario()
        {
            var valido = true;
            if (cbxRespuesta1.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta1, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta1, null);
            }

            if (cbxRespuesta2.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta2, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta2, null);
            }

            if (cbxRespuesta3.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta3, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta3, null);
            }

            if (cbxRespuesta4.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta4, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta4, null);
            }

            if (cbxRespuesta5.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta5, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta5, null);
            }

            if (cbxRespuesta6.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta6, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta6, null);
            }

            if (cbxRespuesta7.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta7, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta7, null);
            }

            if (cbxRespuesta8.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta8, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta8, null);
            }

            if (cbxRespuesta9.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta9, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta9, null);
            }

            if (cbxRespuesta10.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta10, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta10, null);
            }

            if (cbxRespuesta11.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta11, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta11, null);
            }

            if (cbxRespuesta12.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta12, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta12, null);
            }

            if (cbxRespuesta13.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta13, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta13, null);
            }

            if (cbxRespuesta14.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta14, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta14, null);
            }

            if (cbxRespuesta15.SelectedIndex < 0)
            
            {
                valido = false;
                erpError1.SetError(cbxRespuesta15, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta15, null);
            }

            if (cbxRespuesta16.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta16, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta16, null);
            }

            if (cbxRespuesta17.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta17, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta17, null);
            }

            if (cbxRespuesta18.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta18, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta18, null);
            }

            if (cbxRespuesta19.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta19, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta19, null);
            }

            if (cbxRespuesta20.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta20, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta20, null);
            }

            if (cbxRespuesta21.SelectedIndex < 0)
            {
                valido = false;
                erpError1.SetError(cbxRespuesta21, "Por favor, seleccione una respuesta");
            }

            else
            {
                erpError1.SetError(cbxRespuesta21, null);
            }

            return valido;

        }

        private void btnRegresarCuest_Click(object sender, EventArgs e)
        {
            RequisitosPaciente requisitosPaciente = new RequisitosPaciente();
            requisitosPaciente.Show();
            Hide();
        }

    }
}
