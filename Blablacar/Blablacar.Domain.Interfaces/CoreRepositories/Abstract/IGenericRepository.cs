using System;
using System.Collections.Generic;

namespace Blablacar.Domain.Interfaces
{
    public interface IGenericRepository<T, TDto> : IDisposable
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        void Create(T item);

        void Update(T item);

        void Delete(int id);

        void Save();
    }
}
