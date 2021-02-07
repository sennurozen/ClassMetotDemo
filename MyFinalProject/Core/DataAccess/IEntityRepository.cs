using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{   //Core evrensel katman 
    // Core katmanı diğer katmanları referans almaz, 
    //alırsa o katmana bağımlı olur o zaman evrenselliğin anlamı kalmaz
    public interface IEntityRepository<T> where T:class,IEntity,new()  //new() nemwlwnwbilir demek
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
