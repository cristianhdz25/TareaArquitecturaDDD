using Dominio.Entidades;
using Infraestructura.Modelos;

namespace Aplicacion.Adaptadores
{
    public class PersonaMapper
    {
        public static PersonaDTO Map(PersonaEntidad persona)
        {
            return new PersonaDTO
            {
                Id = persona.Id,
                Nombre = persona.Nombre,
                Apellido = persona.Apellido,
                Edad = persona.Edad
            };
        }

        public static PersonaEntidad Map(PersonaDTO persona)
        {
            return new PersonaEntidad
            {
                Id = persona.Id,
                Nombre = persona.Nombre,
                Apellido = persona.Apellido,
                Edad = persona.Edad
            };
        }

        public static IEnumerable<PersonaDTO> Map(IEnumerable<PersonaEntidad> personas)
        {
            return personas.Select(p => Map(p));
        }

        public static IEnumerable<PersonaEntidad> Map(IEnumerable<PersonaDTO> personas)
        {
            return personas.Select(p => Map(p));
        }

        public static PersonaModelo MapPersonaModelo(PersonaEntidad persona)
        {
            return new PersonaModelo
            {
                Id = persona.Id,
                Nombre = persona.Nombre,
                Apellido = persona.Apellido,
                Edad = persona.Edad
            };
        }

        public static PersonaEntidad Map(PersonaModelo persona)
        {
            return new PersonaEntidad
            {
                Id = persona.Id,
                Nombre = persona.Nombre,
                Apellido = persona.Apellido,
                Edad = persona.Edad
            };
        }

        public static IEnumerable<PersonaModelo> MapPersonaModelo(IEnumerable<PersonaEntidad> personas)
        {
            return personas.Select(p => MapPersonaModelo(p));
        }

        public static IEnumerable<PersonaEntidad> Map(IEnumerable<PersonaModelo> personas)
        {
            return personas.Select(p => Map(p));
        }
    }
}
