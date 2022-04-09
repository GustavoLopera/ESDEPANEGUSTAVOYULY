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
    public class RepositorioCuestionarioDB : IRepositorioCuestionario
    {
        //Guardar datos 

        public void guardarCuestionario(Cuestionario cuestionario)
        {
            using (var conection = new SqlConnection(ConfigurationManager.ConnectionStrings["RequisitosPaciente"].ConnectionString))
            {
                conection.Open();
                SqlCommand cmd = conection.CreateCommand();
                cmd.CommandText = "IngresarPreguntasRespuestas";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();
            }
        }

        //Recuperar datos

    }
}
