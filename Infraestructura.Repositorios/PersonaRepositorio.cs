using Dominio.Bases;
using Dominio.Repositorios;
using Infraestructura.Bases;
using Infraestructura.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Repositorios
{
    internal class PersonaRepositorio<TEntidad> : EntidadBase<TEntidad>, IPersonaRepositorio<TEntidad> where TEntidad : class
    {
        public PersonaRepositorio(BDArquitecturaDDDContext context) : base(context)
        {
        }
    }
}
