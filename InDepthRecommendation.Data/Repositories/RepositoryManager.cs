using Autofac;
using InDepthRecommendation.Data.Contracts.Repositories;

namespace InDepthRecommendation.Data.Repositories;

public class RepositoryManager(ILifetimeScope lifetimeScope)
{
    public T GetRepository<T>() 
        where T:IRepository
    {
        return lifetimeScope.Resolve<T>();
    }
}