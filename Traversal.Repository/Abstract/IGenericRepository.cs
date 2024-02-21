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
        //hangi rotasyona yorum yapıldıysa yorumu o rotasyona taşıyacak metod

        T GetById(int id); 
        //destination rotaların detayı için eklendi.

    }
}
