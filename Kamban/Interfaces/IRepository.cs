using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Kamban.Interfaces
{
    public interface IRepository
    {
        Task<List<T>> SelectAll<T>() where T : class;
        Task<List<T>> SelectAll<T>(Expression<Func<T, object>> include, Expression<Func<T, bool>> where) where T : class;
        Task<T> SelectById<T>(int id) where T : class;
        Task CreateAsync<T>(T entity) where T : class;
        Task UpdateAsync<T>(T entity) where T : class;
        Task DeleteAsync<T>(T entity) where T : class;
    }
}
