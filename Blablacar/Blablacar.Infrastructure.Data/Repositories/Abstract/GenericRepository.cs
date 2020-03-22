using Blablacar.Domain.Core;
using Blablacar.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Blablacar.Infrastructure.Data
{
    public abstract class GenericRepository<T> : IGenericRepository<T>
        where T : class
    {
        #region Fields

        protected readonly BlablacarDbContext DbContext;
        protected readonly DbSet<T> Entities;

        #endregion

        #region Constructors 

        public GenericRepository(BlablacarDbContext context)
        {
            DbContext = context.CheckForNull();

            Entities = DbContext.Set<T>();

            Entities.Load();
        }

        #endregion

        #region CRUD

        public void Create(T item)
        {
            Entities.Add(item.CheckForNull());
        }

        public void Delete(int id)
        {
            var entityToDelete = Entities.Find(id);

            if (entityToDelete != null)
                Entities.Remove(entityToDelete);
        }

        public T Get(int id)
        {
            return Entities.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return Entities;
        }

        public void Save()
        {
            DbContext.SaveChanges();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region IDisposable

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (this.disposed)
                return;

            if (disposing)
            {
                DbContext.Dispose();
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~GenericRepository()
        {
            Dispose(false);
        }

        #endregion
    }
}
