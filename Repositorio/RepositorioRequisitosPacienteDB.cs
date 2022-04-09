using Entidad;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioRequisitosPacienteDB : IRepositorioRequisitosPaciente
    {
        //Guardar datos 

        public void guardarRequisitosPaciente(Paciente requisitospaciente)
        {
            using (var conection = new SqlConnection(ConfigurationManager.ConnectionStrings["RequisitosPaciente"].ConnectionString))
            {
                conection.Open();
                SqlCommand cmd = conection.CreateCommand();
                cmd.CommandText = "IngresarPaciente";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@NombreCompleto",System.Data.SqlDbType.NVarChar,50).SqlValue=requisitospaciente.NombresCompletos;
                cmd.Parameters.Add("@IdTipoDocumento", System.Data.SqlDbType.SmallInt).SqlValue = requisitospaciente.TipoDocumento.Id;
                cmd.Parameters.Add("@NumeroDocumento", System.Data.SqlDbType.NVarChar, 50).SqlValue = requisitospaciente.NumeroDocumento;
                cmd.Parameters.Add("@FechaNacimiento", System.Data.SqlDbType.DateTime2).SqlValue = requisitospaciente.FechaNacimiento;
                cmd.Parameters.Add("@IdSexo", System.Data.SqlDbType.SmallInt).SqlValue = requisitospaciente.Genero.Id;
                cmd.Parameters.Add("@IdEstadoCivil", System.Data.SqlDbType.SmallInt).SqlValue = requisitospaciente.EstadoCivil.Id;
                cmd.Parameters.Add("@IdOcupacion", System.Data.SqlDbType.SmallInt).SqlValue = requisitospaciente.Ocupacion.Id;
                cmd.Parameters.Add("@IdEscolaridad", System.Data.SqlDbType.SmallInt).SqlValue = requisitospaciente.NivelEscolaridad.Id;
                cmd.Parameters.Add("@IdEPS", System.Data.SqlDbType.SmallInt).SqlValue = requisitospaciente.EPS.Id;
                cmd.Parameters.Add("@IdRegimen", System.Data.SqlDbType.SmallInt).SqlValue = requisitospaciente.Regimen.Id;
                cmd.Parameters.Add("@DireccionResidencial", System.Data.SqlDbType.NVarChar, 50).SqlValue = requisitospaciente.DireccionRes;
                cmd.Parameters.Add("@IdCiudad", System.Data.SqlDbType.SmallInt).SqlValue = requisitospaciente.Ciudad.Id;
                cmd.Parameters.Add("@CelularContacto", System.Data.SqlDbType.NVarChar, 50).SqlValue = requisitospaciente.Telefono;
                cmd.Parameters.Add("@TelefonoEmergencia", System.Data.SqlDbType.NVarChar, 50).SqlValue = requisitospaciente.TelefonoContEmerg;
                cmd.Parameters.Add("@Email", System.Data.SqlDbType.NVarChar, 50).SqlValue = requisitospaciente.Email;

                cmd.ExecuteNonQuery();
            }
        }

        //Recuperar datos

        public Paciente ObtenerRequisitosPaciente(long idrequisitospaciente)
        {
            Paciente requisitospaciente = null;

            return requisitospaciente;
        }

    }
}
