using Entidad;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioRequisitosPacienteJSON : IRepositorioRequisitosPaciente
    {
        //Guardar datos 
        public void guardarRequisitosPaciente(Paciente requisitospaciente)
        {
            var json = JsonConvert.SerializeObject(requisitospaciente);

            File.WriteAllText("C:\\Datos\\requisitospaciente.json", json);
        }

        //Recuperar datos
        public Paciente ObtenerRequisitosPaciente(long idrequisitospaciente)
        {
            var json = File.ReadAllText("C:\\Datos\\requisitospaciente.json");
            var requisitospaciente = JsonConvert.DeserializeObject<Paciente>(json);

            return requisitospaciente;          
        }

    }
}
