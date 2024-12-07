using System;
using System.Data;
using System.Data.SqlClient;
using InstantRemote.Repositories.Context;
using Microsoft.Extensions.Configuration;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Contracts.Repositories.Common;

namespace InstantRemote.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private IDbConnection connection = null;

        private bool _disposed;
        private IDbTransaction transaction = null;

        private IRepositoryParameter repositoryParameter = null;
        private IRepositoryAuth repositoryAuth = null;
     
        public UnitOfWork(IConfiguration configuration)
        {
            connection = new SqlConnection(configuration.GetConnectionString("ConexionComunes"));
            if (string.IsNullOrEmpty(connection.ConnectionString))
                connection.ConnectionString = configuration["ConexionComunes"];
            connection.Open();
        }

        public IRepositoryAuth RepositoryAuth => repositoryAuth ??= new RepositoryAuth(connection, () => transaction);

        public IRepositoryParameter RepositoryParameter => throw new NotImplementedException();

        //   public IRepositoryParameter RepositoryParameter => repositoryParameter ??= new RepositoryParameter(connection, () => transaction);

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    if (transaction != null)
                    {
                        transaction.Dispose();
                        transaction = null;
                    }
                    if (connection != null)
                    {
                        connection.Dispose();
                        connection = null;
                    }
                }
                _disposed = true;
            }
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }
        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void CommitChanges()
        {
            transaction.Commit();
            transaction = null;
        }

        public void RollbackChanges()
        {
            transaction.Rollback();
            transaction = null;
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
