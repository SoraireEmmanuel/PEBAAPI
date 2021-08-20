using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using PEBA.bl.Data;
using System.Linq;
using System.Data.Entity.Infrastructure;


namespace PEBA.bl.Repositories.Implements
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly PEBAContext PEBAContext;

        public GenericRepository(PEBAContext PEBAContext)
        {
            this.PEBAContext = PEBAContext;
        }

        public async Task Delete(int id)
        {
            var entity = await GetById(id);

            if (entity == null)
                throw new Exception("The entity is null");     

            PEBAContext.Set<TEntity>().Remove(entity);
            await PEBAContext.SaveChangesAsync();
        }



        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await PEBAContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            
            return await PEBAContext.Set<TEntity>().FindAsync(id);
        }
        /// <summary>
        /// Trae pacientes de un profesional
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IEnumerable<TEntity>> GetByProfesional(int id)
        {
//            return await PEBAContext.Set<TEntity>().Where(x => { });
            //            return await PEBAContext.Pacientes.Where(b => b.Id_Profesional == id).ToListAsync();
            // var model2 = await PEBAContext.Pacientes.Where(b => b.Id_Profesional == id).ToListAsync();
            // return model2;
            return await PEBAContext.Set<TEntity>().ToListAsync();
        }


        public async Task<TEntity> Insert(TEntity entity)
        {
            PEBAContext.Set<TEntity>().Add(entity);
            await PEBAContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            PEBAContext.Entry(entity).State = EntityState.Modified;
            //universityContext.Set<TEntity>().AddOrUpdate(entity);
            await PEBAContext.SaveChangesAsync();
            return entity;
        }
    }
}
