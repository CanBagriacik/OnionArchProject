using OnionArch.APPLICATION.Dtos;
using OnionArch.DOMAIN.Entities.Abstratcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OnionArch.APPLICATION.Managers
{
    public interface IManager<D, T> where D : class, IEntity where T : class, IDto
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        IQueryable<T> Where(Expression<Func<D, bool>> exp);
        Task<T> FirstOrDefaultAsync(Expression<Func<D, bool>> exp);
        Task <bool> AnyAsync(Expression<Func<D, bool>> exp);

        Task MakePassiveAsync(T entity);
        Task<string> CreateAsync(T entity); 
        Task<string> UpdateAsync(T entity);
        Task<string> DeleteAsync(T entity);
        Task<string> RemoveAsync(T entity);
    }
}
