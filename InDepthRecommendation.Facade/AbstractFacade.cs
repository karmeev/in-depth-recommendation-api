using InDepthRecommendation.Data.Repositories;

namespace InDepthRecommendation.Facade;

public abstract class AbstractFacade(RepositoryManager repositoryManager)
{
    protected RepositoryManager RepositoryManager { get; set; } = repositoryManager;
}