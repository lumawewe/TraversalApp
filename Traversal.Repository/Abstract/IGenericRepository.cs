using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Traversal.Repository.Abstract
{
    public interface IGenericRepository<T>
    {
        void Add(T t);
        void Update(T t);
        void Delete(T t);

        List<T> GetList();
        List<T> GetListByFilter(Expression<Func<T, bool>> filter);

        T GetById(int id);

    }
}
