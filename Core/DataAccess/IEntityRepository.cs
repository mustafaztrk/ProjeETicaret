using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //generic constraint
    //class: referans tip demek
    //IEntity ile işaretlenen ref tip türündeki nesne olmalı
    //IEntity interface ve bizim işimize yaramayacagı için new şartını getirdik
    //bu sayede ınterfaceler verilemez
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//****filitre vermemek için
        T Get(Expression<Func<T, bool>> filter);//örnk tek kullanıcı alma, id ye göre gibi
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

     
    }
}
