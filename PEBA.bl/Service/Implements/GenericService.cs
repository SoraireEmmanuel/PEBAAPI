using System.Collections.Generic;
using System.Threading.Tasks;
using PEBA.bl.Repositories;

namespace PEBA.bl.Service.Implements
{
    public class GenericService<TEntity> : IGenericService<TEntity> where TEntity : class
    {
        private IGenericRepository<TEntity> genericRepository;

        public GenericService(IGenericRepository<TEntity> genericRepository)
        {
            this.genericRepository = genericRepository;
        }


        public async Task Delete(int id)
        {
            await genericRepository.Delete(id);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await genericRepository.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await genericRepository.GetById(id);
        }
        /// <summary>
        /// trae pacientes por profesional
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<IEnumerable<TEntity>> GetByProfesional(int id)
        {
            return await genericRepository.GetByProfesional(id);
        }


        public async Task<TEntity> Insert(TEntity entity)
        {
            return await genericRepository.Insert(entity);
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            return await genericRepository.Update(entity);
        }
    }
}
