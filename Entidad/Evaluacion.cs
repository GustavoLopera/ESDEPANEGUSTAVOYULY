using System.Collections.Generic;

namespace Entidad
{
    public class Evaluacion
    {
        public Paciente Paciente { get; set; }
        public List<PreguntaRespuesta> Preguntas { get; set; }   
    }
}