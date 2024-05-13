using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Bases
{
    public interface IEntidadBase<TEntidad> where TEntidad : class
    {
        Task<bool> Agregar(TEntidad entidad);

        Task<bool> Actualizar(TEntidad entidad);

        Task<TEntidad> Obtener(int id);

        Task<IEnumerable<TEntidad>> ObtenerTodos();

        Task<bool> Eliminar(TEntidad entidad);

    }
}
