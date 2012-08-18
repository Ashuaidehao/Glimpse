using System.Collections.Generic;

namespace Glimpse.Core2.Extensibility
{
    public interface IProxyFactory
    {
        bool IsProxyable(object obj);
        T CreateProxy<T>(T instance, IEnumerable<IAlternateImplementation<T>> methodImplementations) where T : class;
        T CreateProxy<T>(T instance, IEnumerable<IAlternateImplementation<T>> methodImplementations, object mixin) where T : class;
        T CreateClassProxy<T>(IEnumerable<IAlternateImplementation<T>> methodImplementations, object[] constructorArguments) where T : class;
        T CreateClassProxy<T>(IEnumerable<IAlternateImplementation<T>> methodImplementations, object[] constructorArguments, object mixin) where T : class;
    }
}