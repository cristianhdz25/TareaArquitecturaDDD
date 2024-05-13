using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructura.Modelos;

namespace Infraestructura.Persistencia
{
    public class BDArquitecturaDDDContext: DbContext
    {

        public BDArquitecturaDDDContext(DbContextOptions<BDArquitecturaDDDContext> options) : base(options)
        { 
        }

        public DbSet<PersonaModelo> Personas { get; set; }
    }
}
