using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Paciente
    {
        public string NombresCompletos { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Edad { get; set; }
        public Genero Genero { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public Ocupacion Ocupacion { get; set; }
        public NivelEscolaridad NivelEscolaridad { get; set; }
        public EPS EPS { get; set; }
        public Regimen Regimen { get; set; }
        public string DireccionRes { get; set; }
        public Ciudad Ciudad { get; set; }
        public string Telefono { get; set; }
        public string TelefonoContEmerg { get; set; }
        public string Email { get; set; }
        public Respuesta Escala { get; set; }

    }
}
