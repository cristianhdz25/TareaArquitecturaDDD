using Aplicacion.Adaptadores;
using Dominio.Entidades;
using Dominio.Repositorios;
using Infraestructura.Modelos;


namespace Aplicacion.Servicios
{
    public class PersonaServicio
    {
        private readonly IPersonaRepositorio _personaRepositorio;

        public PersonaServicio(IPersonaRepositorio personaRepositorio)
        {
            _personaRepositorio = personaRepositorio;
        }

        public async Task<IEnumerable<PersonaEntidad>> ObtenerTodos()
        {
            IEnumerable<PersonaEntidad> personas = PersonaMapper.Map(await _personaRepositorio.ObtenerTodos());
            return personas;
        }

        public async Task<PersonaEntidad> Obtener(int id)
        {
            PersonaModelo personaModelo = await _personaRepositorio.Obtener(id);
           PersonaEntidad persona = PersonaMapper.Map(personaModelo);

            return persona;
        }

        public async Task<bool> Agregar(PersonaEntidad persona)
        {
            PersonaModelo personaModelo = PersonaMapper.MapPersonaModelo(persona);
            return await _personaRepositorio.Agregar(personaModelo);
        }


        public async Task<bool> Actualizar(PersonaEntidad persona)
        {
            PersonaModelo personaModelo = PersonaMapper.MapPersonaModelo(persona);
            return await _personaRepositorio.Actualizar(personaModelo);
        }


        public async Task<bool> Eliminar(PersonaEntidad persona)
        {
            PersonaModelo personaModelo = PersonaMapper.MapPersonaModelo(persona);
            return await _personaRepositorio.Eliminar(personaModelo);
        }


    }
}
