using System;
using System.Collections.Generic;

namespace Business.Utils
{
    public interface IIoCContainer : IDisposable
    {
        object Resolve(Type pluginType);

        object TryResolve(Type pluginType);

        IEnumerable<object> ResolveAll(Type pluginType);

        IIoCContainer GetNestedContainer();
    }
}