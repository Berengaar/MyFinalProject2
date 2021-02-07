using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
//Core katmanı diğer katmanları referans almaz
namespace Core.DataAccess       //Core evrensel katmandır
{
    #region Description
    //product dersem product olcak, category dersem category olcak
    //Generic class : Tip belirtilen class'tır
    //Tip belirtilir istenilen tipte işlem yapılır
    //Generic Constraint : Generic kısıt
    //Class : Referans tip olabilir demek, class olabilir demek değil
    //T referans tip olabilir ve IEntity olabilir ya da IEntity implemente eden bir nesne olabilir 
    //new() : new'lenebilir olmalı.
    //IEntity interface olduğundan newlenemez böylece idteiğimiz backend oluşur
    #endregion
    public interface IEntityRepository<T> where T:class,IEntity,new()           //T=type   
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);       //Filtreleme yapısı
        //Filter=null filtre yok demek filtresiz ne var yoksa getirir
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);      //default public
        void Update(T entity);
        void Delete(T entity);

        //Ürünleri kategoriye göre filtrele
       // List<T> GetAllByCategory(int categoryId);     Bu koda ihtiyaç kalmadı
    }
}
