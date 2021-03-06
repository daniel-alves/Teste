﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knewin.Core.Repositories
{
    public interface IRepository<TEntity>
        where TEntity : class
    {
        void Add(TEntity entity);

        void AddAsync(TEntity obj);

        Task<TEntity> GetByIdAsync(long id);

        TEntity Get(long id);

        List<TEntity> GetPage(int limit, int offset);

        IQueryable<TEntity> GetAll();

        List<TEntity> GetAllById(long[] ids);

        void Update(TEntity entity);

        void Remove(long id);

        bool Add(IEnumerable<TEntity> items);

        bool Update(IEnumerable<TEntity> entities);

        bool Exists(long id);
    }
}
