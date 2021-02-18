﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //generic constraint
    //class : refernas tip
    // IEntity : IEntity olabilir ya da onu implemente eden bir şey olabilir
    //new () : new'lenebilir olabilir
    public interface IEntityRepository<T>where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter );
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
