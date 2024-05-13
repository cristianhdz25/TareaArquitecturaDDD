using Dominio.Bases;
using Infraestructura.Persistencia;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Bases
{
    public class EntidadBase<T> : IEntidadBase<T> where T : class
    {
        // generar contecto
        protected BDArquitecturaDDDContext context;

        public EntidadBase(BDArquitecturaDDDContext context) { 
            //agregar contexto por injeccion
            this.context = context;
        }

        public async Task<bool> Actualizar(T entidad)
        {
            try
            {
                this.context.Entry(entidad).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Agregar(T entidad)
        {
            try
            {
                await this.context.Set<T>().AddAsync(entidad);
                await this.context.SaveChangesAsync();
                return true;
            } 
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> Eliminar(T entidad)
        {
            try
            {
                context.Set<T>().Remove(entidad);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<T?> Obtener(int id)
        {
            return this.context.Set<T>().Find(id);
        }

        public async Task<IEnumerable<T>> ObtenerTodos()
        {
            return await context.Set<T>().ToListAsync();
        }
    }
}
