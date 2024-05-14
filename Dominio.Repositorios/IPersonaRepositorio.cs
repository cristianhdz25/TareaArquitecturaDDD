using Dominio.Bases;
using Dominio.Entidades;
using Infraestructura.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dominio.Repositorios.IPersonaRepositorio;

namespace Dominio.Repositorios
{
    public interface IPersonaRepositorio 
    {
        Task<bool> Agregar(PersonaModelo entidad);

        Task<bool> Actualizar(PersonaModelo entidad);

        Task<PersonaModelo> Obtener(int id);

        Task<IEnumerable<PersonaModelo>> ObtenerTodos();

        Task<bool> Eliminar(PersonaModelo entidad);

        Task<IEnumerable<PersonaModelo>> OrdenarPersonasPorEdad();
    }
}
