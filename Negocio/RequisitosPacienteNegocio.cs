using Entidad;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class RequisitosPacienteNegocio:IRequisitosPacienteNegocio
    {
        IRepositorioRequisitosPaciente repositorioRequisitosPaciente;

        public RequisitosPacienteNegocio(IRepositorioRequisitosPaciente repositorioRequisitosPaciente)
        {
            this.repositorioRequisitosPaciente = repositorioRequisitosPaciente;
        }

        public void guardarRequisitosPaciente(Paciente requisitospaciente)
        {
            repositorioRequisitosPaciente.guardarRequisitosPaciente(requisitospaciente);
        }
    }
}
