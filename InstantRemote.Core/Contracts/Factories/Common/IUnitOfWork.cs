using InstantRemote.Core.Contracts.Repositories.Common;

namespace InstantRemote.Core.Contracts.Factories.Common
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryAuth RepositoryAuth { get; }
        IRepositoryParameter RepositoryParameter{ get; }
        void BeginTransaction();
        void CommitChanges();
        void RollbackChanges();

    }
}
