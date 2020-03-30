using AutoMapper;
using Blablacar.Domain.Core;
using Blablacar.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Blablacar.Infrastructure.Data
{
    public abstract class GenericRepository<T, TDto> : IGenericRepository<T, TDto>
        where T : class
        where TDto : class
    {
        #region Fields

        protected readonly BlablacarDbContext DbContext;
        protected readonly DbSet<TDto> Entities;
        protected readonly IMapper Mapper;

        #endregion

        #region Constructors 

        public GenericRepository(BlablacarDbContext context, IMapper maper)
        {
            DbContext = context.CheckForNull();
            Mapper = maper.CheckForNull();

            Entities = DbContext.Set<TDto>();
           
            Entities.Load();
        }

        #endregion

        #region CRUD

        public void Create(T item)
        {
            var mappedItem = Mapper.Map<TDto>(item.CheckForNull());
            Entities.Add(mappedItem);
        }

        public void Delete(int id)
        {
            var entityToDelete = Entities.Find(id);

            if (entityToDelete != null)
                Entities.Remove(entityToDelete);
        }

        public T Get(int id)
        {
            var mappedItem = Mapper.Map<T>(Entities.Find(id));
            return mappedItem;
        }

        public IEnumerable<T> GetAll()
        {
            return Mapper.Map<IEnumerable<T>>(Entities);
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
