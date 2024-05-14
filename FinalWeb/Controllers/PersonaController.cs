using Aplicacion.Adaptadores;
using Aplicacion.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace FinalWeb.Controllers
{
    public class PersonaController : Controller
    {
        private readonly PersonaServicio _personaServicio;

        public PersonaController(PersonaServicio personaServicio)
        {
            _personaServicio = personaServicio;
        }

        public IActionResult Index()
        {
            var personas = _personaServicio.ObtenerTodos();
            return View(personas);
        }

        public IActionResult Crear(PersonaDTO persona)
        {
            _ = _personaServicio.Agregar(persona);
            return View();
        }

        public IActionResult Editar(int id)
        {
            var persona = _personaServicio.Obtener(id);
            return View(persona);
        }

        public IActionResult Actualizar(PersonaDTO persona)
        {
            _personaServicio.Actualizar(persona);
            return View();
        }
    }


}
