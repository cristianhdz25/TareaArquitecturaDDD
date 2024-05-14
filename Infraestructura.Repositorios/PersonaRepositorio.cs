using Dominio.Entidades;
using Dominio.Repositorios;
using Infraestructura.Bases;
using Infraestructura.Modelos;
using Infraestructura.Persistencia;

namespace Infraestructura.Repositorios
{
    public class PersonaRepositorio : EntidadBase<PersonaModelo>, IPersonaRepositorio
    {
        public PersonaRepositorio(BDArquitecturaDDDContext context) : base(context)
        {
        }

    
    }

}

