using System;
using System.Collections.Generic;
using System.Linq;

namespace DependenciesResolver.Core
{
    public class BaseContainer : IContainer
    {
        private Dictionary<Type, ICollection<Func<object>>> _instanceCreators;

        public BaseContainer()
        {
            _instanceCreators = new Dictionary<Type, ICollection<Func<object>>>();
        }

        public void Register<TService, TImplementation>(Func<TImplementation> creator = null)            
        {
            var serviceType = typeof(TService);
            var implementationType = typeof(TImplementation).CheckForSubClassWithException(serviceType);

            if (implementationType.IsAbstract)
                throw new InvalidOperationException("Unable to perform registration of abstract class");

            var objCreator = creator as Func<object>;
            if (creator == null)
                objCreator = () => Activator.CreateInstance(implementationType);

            if (_instanceCreators.ContainsKey(serviceType))
                _instanceCreators[serviceType].Add(objCreator);
            else
                _instanceCreators.Add(serviceType, new List<Func<object>> { objCreator });
        }

        public TService Get<TService>()
        {
            var targetType = typeof(TService);

            if (_instanceCreators.TryGetValue(targetType, out var creator))
                return (TService)creator.Last()();

            return default;
        }

        public IEnumerable<TService> GetAllRegistered<TService>()
        {
            var targetType = typeof(TService);
            if (_instanceCreators.TryGetValue(targetType, out var creator))
                return creator.Select(x => (TService)x());

            return default;
        }
    }
}
