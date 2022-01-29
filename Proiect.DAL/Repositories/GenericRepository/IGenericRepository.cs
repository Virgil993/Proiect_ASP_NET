﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Repositories.GenericRepository
{
    public interface IGenericRepository<TEntity>
    {
        // Get Data

        IQueryable<TEntity> GetAll();

        Task<TEntity> GetByIdAsync(int Id);

        // Create

        void Create(TEntity entity);
        void CreateRange(IEnumerable<TEntity> entities);

        // Update

        void Update(TEntity entity);

        // Delete

        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);

        // Save

        Task<bool> SaveAsync();
    }
}
