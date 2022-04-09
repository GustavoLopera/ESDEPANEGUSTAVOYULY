using Entidad;
using System.Collections.Generic;

namespace Negocio
{
    public interface IMaestroNegocio
    {
        List<TipoDocumento> ObtenerTiposDocumento();
        List<Genero> ObtenerGeneros();
        List<EstadoCivil> ObtenerEstadoC();
        List<Ocupacion> ObtenerOcupacionX();
        List<NivelEscolaridad> ObtenerEscolaridadN();
        List<Regimen> ObtenerRegimenX();
        List<EPS> ObtenerEPSX();
        List<Ciudad> ObtenerCiudadX();
        List<Respuesta> ObtenerEscalaX();
        List<Pregunta> ObtenerPregunta();
    }
}