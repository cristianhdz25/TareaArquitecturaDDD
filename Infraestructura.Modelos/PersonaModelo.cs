using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Modelos
{
    public class PersonaModelo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad {  get; set; }

        public PersonaModelo() 
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
        }
    }
}
