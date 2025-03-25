using InstantRemote.Core.Contracts.Repositories.Common;

namespace InstantRemote.Core.Contracts.Factories.Common
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryAuth RepositoryAuth { get; }
        IRepositoryParameter RepositoryParameter{ get; }
        IRepositoryCommon RepositoryCommon{ get; }
        IRepositoryReports RepositoryReports{ get; }
        IRepositoryPrincipal RepositoryPrincipal{ get; }
        IRepositorySoporte RepositorySoporte{ get; }
        void BeginTransaction();
        void CommitChanges();
        void RollbackChanges();

    }
}
