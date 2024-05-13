using Dominio.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public interface IPersonaRepositorio<T> : IEntidadBase<T> where T : class
    {
    }
}
