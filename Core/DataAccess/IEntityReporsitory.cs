
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityReporsitory<T>where T:class, IEntity,new() //T'yi sınırlandırdık class:referans tip olabilir,IEntity: Ientity yada onu implemente eden bir nesne olabilir, new ise newlenebilir bir nesne olabilir(IEntity'nin kendisi olmaz)
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter = null); //GetAll() yerine bu şeklde yazıyoruz

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

      
    }
}
