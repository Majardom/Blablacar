using System;
using System.Collections.Generic;

namespace DependenciesResolver.Core
{
    public interface IContainer
    {
        void Register<TService, TImplementation>(Func<TImplementation> creator) where TImplementation : TService;

        TService Get<TService>();

        IEnumerable<TService> GetAllRegistered<TService>();
    }
}
