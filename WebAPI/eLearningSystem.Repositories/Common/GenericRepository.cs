﻿using eLearningSystem.Data;
using eLearningSystem.Data.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eLearningSystem.Repositories.Common
{
    public abstract class GenericRepository<T> : IGenericRepository<T>
        where T : BaseEntity
    {
        protected DbContext _entities;
        protected readonly IDbSet<T> _dbset;

        public GenericRepository(DbContext context)
        {
            _entities = context;
            _dbset = context.Set<T>();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbset.AsEnumerable<T>();
        }

        public IEnumerable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> query = _dbset.Where(predicate).AsEnumerable();
            return query;
        }

        public virtual T Add(T entity)
        {
            return _dbset.Add(entity);
        }

        public virtual T Delete(T entity)
        {
            return _dbset.Remove(entity);
        }
        public T FindById(object id)
        {
            return _dbset.Find(id);
        }


        public virtual void Edit(object id, T entity)
        {
            T existEntity = _dbset.Find(id);
            if (existEntity != null)
            {
                _entities.Entry(existEntity).CurrentValues.SetValues(entity);
            }

        }

        public virtual void Save()
        {
            _entities.SaveChanges();
        }


    }
}
