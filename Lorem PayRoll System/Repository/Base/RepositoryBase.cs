using Lorem_PayRoll_System.Data;
using Lorem_PayRoll_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Linq.Expressions;

namespace Lorem_PayRoll_System.Repository.Base
{
    public abstract class RepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity> 
        where TEntity : class, IEntity
    {
        protected EmployeeContext _context { get; set; }
        public RepositoryBase(EmployeeContext context) => _context = context;

        public async Task<List<TEntity>> GetAll() => await _context.Set<TEntity>().AsNoTracking().ToListAsync();

        public async Task<List<TEntity>> FindByCondition(Expression<Func<TEntity, bool>> expression) => await _context.Set<TEntity>().Where(expression).AsNoTracking().ToListAsync();

        public async Task<TEntity> Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Update(TEntity entity) 
        {
            _context.Set<TEntity>().Update(entity);

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Delete(int id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
