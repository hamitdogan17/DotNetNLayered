﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Northwind.Entities.Abstract;

namespace Northwind.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntitiy, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T product);
        void Update(T product);
        void Delete(T product);
    }
}