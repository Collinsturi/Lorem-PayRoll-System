using Lorem_PayRoll_System.Models;
using System.Linq.Expressions;

namespace Lorem_PayRoll_System.Repository.Base
{
    public interface IRepositoryBase<T> where T : class, IEntity
    {
        Task<List<T>> GetAll();
        Task<List<T>> FindByCondition(Expression<Func<T, bool>> expression);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
    }
}
