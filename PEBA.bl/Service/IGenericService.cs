using System.Collections.Generic;
using System.Threading.Tasks;

namespace PEBA.bl.Service
{
    public interface IGenericService<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        /// <summary>
        /// trae pacientes de un profesional
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IEnumerable<TEntity>> GetByProfesional(int id);
        Task<TEntity> Insert(TEntity entity);
        Task<TEntity> Update(TEntity entity);
        Task Delete(int id);
    }
}
