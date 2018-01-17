using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
    // generic constraints, means can only replace T be a class 
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        IEnumerable<T> GetAll();
        IQueryable<T> GetQuerable();
        T Get(Expression <Func<T, bool>> where);
        void SaveChanges();
    }
}
