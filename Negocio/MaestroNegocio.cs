using Entidad;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class MaestroNegocio : IMaestroNegocio
    {
        IMaestroRepositorio maestroRepositorio;

        public MaestroNegocio(IMaestroRepositorio maestroRepositorio)
        {
            this.maestroRepositorio = maestroRepositorio;
        }

        public List<TipoDocumento> ObtenerTiposDocumento()

        {
            return maestroRepositorio.ObtenerTiposDocumento();
        }



        public List<Genero> ObtenerGeneros()

        {
            return maestroRepositorio.ObtenerGeneros();
        }

        public List<EstadoCivil> ObtenerEstadoC()

        {
            return maestroRepositorio.ObtenerEstadoC();
        }

        public List<Ocupacion> ObtenerOcupacionX()

        {
            return maestroRepositorio.ObtenerOcupacionX();
        }

        public List<NivelEscolaridad> ObtenerEscolaridadN()

        {
            return maestroRepositorio.ObtenerEscolaridadN();
        }

        public List<Regimen> ObtenerRegimenX()

        {
            return maestroRepositorio.ObtenerRegimenX();
        }

        public List<EPS> ObtenerEPSX()

        {
            return maestroRepositorio.ObtenerEPSX();
        }

        public List<Ciudad> ObtenerCiudadX()

        {
            return maestroRepositorio.ObtenerCiudadX();
        }

        public List<Respuesta> ObtenerEscalaX()
        {
            return maestroRepositorio.ObtenerEscalaX();
        }

        public List<Pregunta> ObtenerPregunta()
        {
            return maestroRepositorio.ObtenerPregunta();
        }
    }
}
