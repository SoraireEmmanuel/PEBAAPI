using System.Collections.Generic;
using System.Threading.Tasks;

namespace PEBA.bl.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        /// <summary>
        /// Trae paciente por profesional
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> GetByProfesional(int id);
        Task<TEntity> Insert(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task Delete(int id);
    }
}
