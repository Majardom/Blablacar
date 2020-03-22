using AutoMapper;
using Blablacar.Domain.Core;
using Blablacar.Domain.Interfaces;
using System;

namespace Blablacar.Infrastructure.Business
{
    public abstract class BaseService : IDisposable
    {
        #region Fields 

        protected readonly IUnitOfWork UnitOfWork;
        protected readonly IMapper Mapper;

        #endregion

        #region Constructors 

        public BaseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork.CheckForNull();
            Mapper = mapper.CheckForNull();
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
                UnitOfWork.Dispose();
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~BaseService()
        {
            Dispose(false);
        }

        #endregion
    }
}
