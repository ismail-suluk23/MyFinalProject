﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constrain
    //calss: referans tip
    //IEntity : IEntity olabilir veya IEntity Implente
    //new() : new2lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter=null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
       
    }
}
