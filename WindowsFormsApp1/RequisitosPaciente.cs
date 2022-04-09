using Entidad;
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
using System.Text.RegularExpressions;


namespace WindowsFormsApp1
{
    public partial class RequisitosPaciente : Form
    {
        public RequisitosPaciente()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            { 
                if (ValidarCampos())
                {

                    Entidad.Paciente requisitosPaciente = new Entidad.Paciente();
                    requisitosPaciente.NombresCompletos = txtNombres.Text;
                    requisitosPaciente.TipoDocumento = cbxTipoID.SelectedItem as Entidad.TipoDocumento;
                    requisitosPaciente.NumeroDocumento = txtNumID.Text;
                    requisitosPaciente.FechaNacimiento = dtpFechaNacimiento.Value;
                    requisitosPaciente.Edad = txtEdad.Text;
                    requisitosPaciente.Genero = cbxGenero.SelectedItem as Entidad.Genero;
                    requisitosPaciente.EstadoCivil = cbxEstadoCiv.SelectedItem as Entidad.EstadoCivil;
                    requisitosPaciente.Ocupacion = cbxOcupacion.SelectedItem as Entidad.Ocupacion;
                    requisitosPaciente.NivelEscolaridad = cbxNivelEsco.SelectedItem as Entidad.NivelEscolaridad;
                    requisitosPaciente.EPS = cbxEPS.SelectedItem as Entidad.EPS;
                    requisitosPaciente.Regimen = cbxRegimen.SelectedItem as Entidad.Regimen;
                    requisitosPaciente.DireccionRes = txtDirecRes.Text;
                    requisitosPaciente.Ciudad = cbxCiudad.SelectedItem as Entidad.Ciudad;
                    requisitosPaciente.Telefono = txtTelCont.Text;
                    requisitosPaciente.TelefonoContEmerg = txtContEmerg.Text;
                    requisitosPaciente.Email = txtEmail.Text;

                    IRepositorioRequisitosPaciente repositorio = new RepositorioRequisitosPacienteDB();
                    IRequisitosPacienteNegocio negocio = new RequisitosPacienteNegocio(repositorio);
                    negocio.guardarRequisitosPaciente(requisitosPaciente);

                    Cuestionario cuestionario = new Cuestionario();
                    cuestionario.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Hay errores en el formulario. Por favor revise",
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

        private bool ValidarCampos()
        {
            var valido = true;
            if (string.IsNullOrEmpty(txtNombres.Text))
            {
                valido = false;
                erpError.SetError(txtNombres, "El campo está vacío debe ingresar el nombre completo");
            }
            else 
            {
                erpError.SetError(txtNombres, null);

            }
            if (txtNumID.Text.Length < 6)
            {
                valido = false;
                erpError.SetError(txtNumID, "El número de documento debe tener al menos 6 dígitos");
            }
            else
            {
                erpError.SetError(txtNumID, null);
            }
            if (cbxTipoID.SelectedIndex < 0)
            {
                valido = false;
                erpError.SetError(cbxTipoID, "Selecciona un tipo de identificación");
            }
            else
            {
                erpError.SetError(cbxTipoID, null);
            }
            if (txtTelCont.Text.Length < 7)
            {
                valido=false;
                erpError.SetError(txtTelCont, "El número debe tener al menos 7 dígitos");
            }
            else
            {   
                erpError.SetError(txtTelCont, null);
            }
            DateTime fechaActual = DateTime.Today;
            if (dtpFechaNacimiento.Value.Date > fechaActual)
            {   
                valido = false;
                erpError.SetError(dtpFechaNacimiento, "Fecha invalida, no puedes seleccionar una fecha futura");
            }
            else
            {
                erpError.SetError(dtpFechaNacimiento, null);
            }
            if (string.IsNullOrEmpty(txtDirecRes.Text))
            {   
                valido=false;
                erpError.SetError(txtDirecRes, "El campo está vacío debe ingresar su dirección de residencia");
            }
            else
            {
                erpError.SetError(txtDirecRes, null);
            }
            if (cbxGenero.SelectedIndex < 0)
            {   
                valido = false;
                erpError.SetError(cbxGenero, "Selecciona el género");
            }
            else
            {
                erpError.SetError(cbxGenero, null);
            }
            if (txtContEmerg.Text.Length < 7)
            {   
                valido=false;   
                erpError.SetError(txtContEmerg, "El número debe tener al menos 7 dígitos");
            }
            else
            {
                erpError.SetError(txtContEmerg, null);
            }
            if (cbxEstadoCiv.SelectedIndex < 0)
            {  
                valido=false;
                erpError.SetError(cbxEstadoCiv, "Selecciona el estado civil");
            }
            else
            {
                erpError.SetError(cbxEstadoCiv, null);
            }
            if (cbxEstadoCiv.SelectedIndex < 0)
            {
                valido = false;
                erpError.SetError(cbxOcupacion, "Selecciona el tipo de ocupación");
            }
            else
            {
                erpError.SetError(cbxOcupacion, null);
            }
            if (cbxNivelEsco.SelectedIndex < 0)
            {
                valido = false;
                erpError.SetError(cbxNivelEsco, "Selecciona el tipo de nivel escolar");
            }
            else
            {
                erpError.SetError(cbxNivelEsco, null);
            }
            if (cbxEPS.SelectedIndex < 0)
            {
                valido = false;
                erpError.SetError(cbxEPS, "Selecciona el tipo de EPS"); ;
            }
            else
            {
                erpError.SetError(cbxEPS, null);
            }
            if (cbxRegimen.SelectedIndex < 0)
            {
                valido = false;
                erpError.SetError(cbxRegimen, "Selecciona el tipo de régimen");
            }
            else
            {
                erpError.SetError(cbxRegimen, null);
            }
            if (cbxCiudad.SelectedIndex < 0)
            {
                valido=false;
                erpError.SetError(cbxCiudad, "Selecciona la ciudad de residencia");
            }
            else
            {
                erpError.SetError(cbxCiudad, null);
            }

            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                valido = false;
                erpError.SetError(txtEmail, "ingresa un Email valido, ejemplo: pepito@gmail.com");
            }
            else
            {
                erpError.SetError(txtEmail, null);
            }

            return valido;

        }

        private void RequisitosPaciente_Load(object sender, EventArgs e)
        {
            {
                var negocio = new MaestroNegocio(new MaestroRepositorio());
                var tiposDocumento = negocio.ObtenerTiposDocumento();
                cbxTipoID.DataSource = tiposDocumento;
                cbxTipoID.DisplayMember = "Nombre";
                cbxTipoID.SelectedItem = null;


                var Generos = negocio.ObtenerGeneros();
                cbxGenero.DataSource = Generos;
                cbxGenero.DisplayMember = "NombreGenero";
                cbxGenero.SelectedItem = null;

                var EstadosC = negocio.ObtenerEstadoC();
                cbxEstadoCiv.DataSource = EstadosC;
                cbxEstadoCiv.DisplayMember = "NombreEstadoC";
                cbxEstadoCiv.SelectedItem = null;

                var ocupacion = negocio.ObtenerOcupacionX();
                cbxOcupacion.DataSource = ocupacion;
                cbxOcupacion.DisplayMember = "NombreOcupacion";
                cbxOcupacion.SelectedItem = null;

                var escolaridad = negocio.ObtenerEscolaridadN();
                cbxNivelEsco.DataSource = escolaridad;
                cbxNivelEsco.DisplayMember = "NombreEscolaridad";
                cbxNivelEsco.SelectedItem = null;

                var regimen = negocio.ObtenerRegimenX();
                cbxRegimen.DataSource = regimen;
                cbxRegimen.DisplayMember = "NombreRegimen";
                cbxRegimen.SelectedItem = null;

                var eps = negocio.ObtenerEPSX();
                cbxEPS.DataSource = eps;
                cbxEPS.DisplayMember = "NombreEPS";
                cbxEPS.SelectedItem = null;

                var ciudad = negocio.ObtenerCiudadX();
                cbxCiudad.DataSource = ciudad;
                cbxCiudad.DisplayMember = "NombreCiudad";
                cbxCiudad.SelectedItem = null;
            }
        }

        private void txtNumID_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)

            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }

        private void txtTelCont_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void txtContEmerg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
        }

        private void txtNombres_KeyDown(object sender, KeyEventArgs e)
        {
            if (!((e.KeyValue >= 65 && e.KeyValue <= 90) ||
                  (e.KeyValue >= 97 && e.KeyValue <= 122) ||
                   e.KeyValue == 8 || e.KeyValue == 127 || e.KeyValue == 37
                   || e.KeyValue == 39
                   || e.KeyValue == 46 || e.KeyValue == 16 || e.KeyValue == 32))

            {
                e.SuppressKeyPress = true;
            }
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime FechaActual = DateTime.Today;
            int edad = FechaActual.Year - dtpFechaNacimiento.Value.Year;
            if (FechaActual < dtpFechaNacimiento.Value.AddYears(edad)) edad--;
            txtEdad.Text = edad.ToString();

        }

    }
}