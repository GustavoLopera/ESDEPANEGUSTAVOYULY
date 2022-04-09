using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class MaestroRepositorio : IMaestroRepositorio
    {

        public List<TipoDocumento> ObtenerTiposDocumento()
        {
            var tiposDocumento = new List<TipoDocumento>()
            {
                new TipoDocumento() {Id=1, Nombre = "Tarjeta de Identidad"},
                new TipoDocumento() {Id=2, Nombre = "Cédula de guntaanía"},
                new TipoDocumento() {Id=3, Nombre = "Registro Civil"},
                new TipoDocumento() {Id=4, Nombre = "Pasaporte"},
                new TipoDocumento() {Id=5, Nombre = "Cédula de Extranjería"}

            };

            return tiposDocumento;

        }
        public List<Genero> ObtenerGeneros()
        {
            var generos = new List<Genero>()
            {
                new Genero() {Id=1, NombreGenero = "Femenino"},
                new Genero() {Id=2, NombreGenero = "Masculino"},
                new Genero() {Id=2, NombreGenero = "No binario"}

            };

            return generos;
        }

        public List<EstadoCivil> ObtenerEstadoC()
        {
            var estadoC = new List<EstadoCivil>()
            {
                new EstadoCivil() {Id=1, NombreEstadoC = "Soltero/a"},
                new EstadoCivil() {Id=2, NombreEstadoC = "Unión Libre"},
                new EstadoCivil() {Id=3, NombreEstadoC = "Casado/a"},
                new EstadoCivil() {Id=4, NombreEstadoC = "Divorciado/a"},
                new EstadoCivil() {Id=5, NombreEstadoC = "Viudo/a"}

            };

            return estadoC;
        }

        public List<Ocupacion> ObtenerOcupacionX()
        {
            var ocupacion = new List<Ocupacion>()
            {
                new Ocupacion() {Id=1, NombreOcupacion = "Empleado/a"},
                new Ocupacion() {Id=2, NombreOcupacion = "Desempleado/a"},
                new Ocupacion() {Id=3, NombreOcupacion = "Estudiante"}


            };

            return ocupacion;
        }

        public List<NivelEscolaridad> ObtenerEscolaridadN()
        {
            var escolaridad = new List<NivelEscolaridad>()
            {
                new NivelEscolaridad() {Id=1, NombreEscolaridad = "Prescolar"},
                new NivelEscolaridad() {Id=2, NombreEscolaridad = "Básica Primaria"},
                new NivelEscolaridad() {Id=3, NombreEscolaridad = "Básica Secundaria"},
                new NivelEscolaridad() {Id=4, NombreEscolaridad = "Educación Media"},
                new NivelEscolaridad() {Id=5, NombreEscolaridad = "Educación Superior"},
                new NivelEscolaridad() {Id=6, NombreEscolaridad = "Ninguna"}

            };

            return escolaridad;
        }
        public List<Regimen> ObtenerRegimenX()
        {
            var regimen = new List<Regimen>()
            {
                new Regimen() {Id=1, NombreRegimen = "Subsidiado"},
                new Regimen() {Id=2, NombreRegimen = "Contributivo"},
                new Regimen() {Id=3, NombreRegimen = "Especial"}


            };

            return regimen;
        }

        public List<EPS> ObtenerEPSX()
        {
            var eps = new List<EPS>()
            {
                new EPS() {Id=1, NombreEPS = "Cruz Blanca EPS"},
                new EPS() {Id=2, NombreEPS = "Salud vida EPS"},
                new EPS() {Id=3, NombreEPS = "EPS SURA"},
                new EPS() {Id=4, NombreEPS = "Asmet Salud EPS"},
                new EPS() {Id=5, NombreEPS = "Aliansalud"},
                new EPS() {Id=6, NombreEPS = "Coosalud"},
                new EPS() {Id=7, NombreEPS = "MUTUAL SER"},
                new EPS() {Id=8, NombreEPS = "Servicio Occidental de Salud (SOS)"},
                new EPS() {Id=9, NombreEPS = "Cafam"},
                new EPS() {Id=10, NombreEPS = "Emssanar"},
                new EPS() {Id=11, NombreEPS = "Capital Salud"},
                new EPS() {Id=12, NombreEPS = "Comfandi"},
                new EPS() {Id=13, NombreEPS = "Medimás EPS"},
                new EPS() {Id=14, NombreEPS = "Colsubsidio"},
                new EPS() {Id=15, NombreEPS = "EPS Sanitas"},
                new EPS() {Id=16, NombreEPS = "Compensar"},
                new EPS() {Id=17, NombreEPS = "Coomeva EPS"},
                new EPS() {Id=18, NombreEPS = "Salud total"},
                new EPS() {Id=19, NombreEPS = "Nueva EPS"},
                new EPS() {Id=20, NombreEPS = "Famisanar"},
                new EPS() {Id=21, NombreEPS = "Otra"}


            };

            return eps;
        }
        public List<Ciudad> ObtenerCiudadX()
        {
            var ciudad = new List<Ciudad>()
            {
                new Ciudad() {Id=1, NombreCiudad = "Bogotá"},
                new Ciudad() {Id=2, NombreCiudad = "Medellín"},
                new Ciudad() {Id=3, NombreCiudad = "Cali"},
                new Ciudad() {Id=4, NombreCiudad = "Barranquilla"},
                new Ciudad() {Id=5, NombreCiudad = "Cartagena de Indias"},
                new Ciudad() {Id=6, NombreCiudad = "Soacha"},
                new Ciudad() {Id=7, NombreCiudad = "Cúcuta"},
                new Ciudad() {Id=8, NombreCiudad = "Soledad"},
                new Ciudad() {Id=9, NombreCiudad = "Bucaramanga"},
                new Ciudad() {Id=10, NombreCiudad = "Bello"},
                new Ciudad() {Id=11, NombreCiudad = "Villavicencio"},
                new Ciudad() {Id=12, NombreCiudad = "Ibagué"},
                new Ciudad() {Id=13, NombreCiudad = "Santa Marta "},
                new Ciudad() {Id=14, NombreCiudad = "Valledupar"},
                new Ciudad() {Id=15, NombreCiudad = "Manizales "},
                new Ciudad() {Id=16, NombreCiudad = "Pereira"},
                new Ciudad() {Id=17, NombreCiudad = "Montería"},
                new Ciudad() {Id=18, NombreCiudad = "Nieva"},
                new Ciudad() {Id=19, NombreCiudad = "Pasto"},
                new Ciudad() {Id=20, NombreCiudad = "Armenia"}

            };

            return ciudad;

        }
        public List<Respuesta> ObtenerEscalaX()
        {
            var escala = new List<Respuesta>()
            {
                new Respuesta() {Id=1, Nombre = "No me ha ocurrido", PuntajeEscala = 0 },
                new Respuesta() {Id=2, Nombre = "Me ha ocurrido un poco, o durante parte del tiempo", PuntajeEscala = 1},
                new Respuesta() {Id=3, Nombre = "Me ha ocurrido bastante, o durante una buena parte del tiempo", PuntajeEscala = 2},
                new Respuesta() {Id=4, Nombre = "Me ha ocurrido mucho, o la mayor parte del tiempo", PuntajeEscala = 3}
            };

            return escala;
        }

        public List<Pregunta> ObtenerPregunta()
        {
            var pregunta = new List<Pregunta>()
            {
                new Pregunta() { Id = 1, Nombre = "Me ha costado mucho descargar la tensión" },
                new Pregunta() { Id = 2, Nombre = "Me di cuenta que tenía la boca seca" },
                new Pregunta() { Id = 3, Nombre = "No podía sentir ningún sentimiento positivo" },
                new Pregunta() { Id = 4, Nombre = "Se me hizo difícil respirar" },
                new Pregunta() { Id = 5, Nombre = "Se me hizo difícil tomar la iniciativa para hacer cosas" },
                new Pregunta() { Id = 6, Nombre = "Reaccioné exageradamente en ciertas situaciones" },
                new Pregunta() { Id = 7, Nombre = "Sentí que mis manos temblaban" },
                new Pregunta() { Id = 8, Nombre = "He sentido que estaba gastando una gran cantidad de energía" },
                new Pregunta() { Id = 9, Nombre = "Estaba preocupado por situaciones en las cuales podía tener pánico o en las que podríahacer el ridículo" },
                new Pregunta() { Id = 10, Nombre = "He sentido que no había nada que me ilusionara" },
                new Pregunta() { Id = 11, Nombre = "Me he sentido inquieto" },
                new Pregunta() { Id = 12, Nombre = "Se me hizo difícil relajarme" },
                new Pregunta() { Id = 13, Nombre = "Me sentí triste y deprimido" },
                new Pregunta() { Id = 14, Nombre = "No toleré nada que no me permitiera continuar con lo que estaba haciendo" },
                new Pregunta() { Id = 15, Nombre = "Sentí que estaba al punto de pánico" },
                new Pregunta() { Id = 16, Nombre = "No me pude entusiasmar por nada" },
                new Pregunta() { Id = 17, Nombre = "Sentí que valía muy poco como persona" },
                new Pregunta() { Id = 18, Nombre = "He tendido a sentirme enfadado con facilidad" },
                new Pregunta() { Id = 19, Nombre = "Sentí los latidos de mi corazón a pesar de no haber hecho ningún esfuerzo físico" },
                new Pregunta() { Id = 20, Nombre = "Tuve miedo sin razón" },
                new Pregunta() { Id = 21, Nombre = "Sentí que la vida no tenía ningún sentido" },
            };

            return pregunta;
        }
    }
}
