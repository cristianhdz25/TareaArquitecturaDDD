using Aplicacion.Adaptadores;
using Aplicacion.Servicios;
using Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TareaArquitecturaDDDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly PersonaServicio _personaServicio;

        public PersonaController(PersonaServicio personaServicio)
        {
            _personaServicio = personaServicio;
        }

        [HttpGet]
        [Route("ObtenerTodos")]
        public async Task<IActionResult> ObtenerTodos()
        {
            PersonaDTO[] personas = (await _personaServicio.ObtenerTodos()).Select(p => PersonaMapper.Map(p)).ToArray();
            return Ok(personas);
        }

        [HttpGet]
        [Route("Obtener/{id}")]
        public async Task<IActionResult> Obtener(int id)
        {
            PersonaDTO persona = PersonaMapper.Map(await _personaServicio.Obtener(id));
            return Ok(persona);
        }

        [HttpPost]
        [Route("Agregar")]
        public async Task<IActionResult> Agregar(PersonaDTO persona)
        {
            PersonaEntidad personaEntidad = PersonaMapper.Map(persona);
            return Ok(await _personaServicio.Agregar(personaEntidad));
        }

        [HttpPut]
        [Route("Actualizar")]
        public async Task<IActionResult> Actualizar(PersonaDTO persona)
        {
            PersonaEntidad personaEntidad = PersonaMapper.Map(persona);
            return Ok(await _personaServicio.Actualizar(personaEntidad));
        }

        [HttpDelete]
        [Route("Eliminar")]
        public async Task<IActionResult> Eliminar(PersonaDTO persona)
        {
            PersonaEntidad personaEntidad = PersonaMapper.Map(persona);
            return Ok(await _personaServicio.Eliminar(personaEntidad));
        }

        [HttpGet]
        [Route("OrdenarPorEdad")]
        public async Task<IActionResult> OrdenarPorEdad()
        {
            PersonaDTO[] personas = (await _personaServicio.OrdenarPersonasPorEdad()).Select(p => PersonaMapper.Map(p)).ToArray();
            return Ok(personas);
        }
    }
}
