using Dominio.Entidades;
using Dominio.Repositorios;
using Infraestructura.Bases;
using Infraestructura.Modelos;
using Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Repositorios
{
    public class PersonaRepositorio : EntidadBase<PersonaModelo>, IPersonaRepositorio
    {
        private readonly BDArquitecturaDDDContext _context;
        public PersonaRepositorio(BDArquitecturaDDDContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PersonaModelo>> OrdenarPersonasPorEdad()
        {
            IEnumerable<PersonaModelo> personas = await _context.Personas.ToListAsync();
            personas = personas.OrderBy(p => p.Edad);
            return personas;
        }
    }

}

