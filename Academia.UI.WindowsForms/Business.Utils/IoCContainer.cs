using Business.Logic;
using ResourceAccess.Repository;
using StructureMap;
using StructureMap.Graph;
using StructureMap.Graph.Scanning;

namespace Business.Utils
{
    internal class AllInterfacesConvention<TPluginType> : IRegistrationConvention
    {
        public void ScanTypes(TypeSet types, Registry registry)
        {
            foreach (var type in types.FindTypes(TypeClassification.Concretes | TypeClassification.Closed))
            {
                foreach (var @interface in type.GetInterfaces())
                {
                    if (typeof(TPluginType).IsAssignableFrom(@interface))
                    {
                        registry.For(@interface).Use(type);
                    }
                }
            }
        }
    }

    public sealed class IoCContainer : IIoCContainer
    {
        #region Patron Singleton

        private static readonly IoCContainer instance = new IoCContainer();

        private readonly IContainer iocContainer;

        private IoCContainer()
        {
            this.iocContainer = new Container();
        }

        private IoCContainer(IContainer container)
        {
            this.iocContainer = container;
        }

        public static IoCContainer Instance { get { return instance; } }
        #endregion

        public void Register()
        {
            this.RegisterAssembly<ILogicBase>("Business.Logic");
            this.RegisterAssembly<IDataAccessBase>("ResourceAccess.Repository");
        }

        public void RegisterAssembly<TPluginType>(string assemblyName)
        {
            this.iocContainer.Configure(x =>
                                        x.Scan(_ =>
                                        {
                                            _.Assembly(assemblyName);
                                            _.Convention<AllInterfacesConvention<TPluginType>>();
                                        }));
        }

        public T TryResolve<T>()
        {
            return this.iocContainer.TryGetInstance<T>();
        }

        public void Dispose()
        {
            this.iocContainer.Dispose();
        }
    }
}
