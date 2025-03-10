using System.Data;
using System.Data.SqlClient;
using InstantRemote.Repositories.Context;
using Microsoft.Extensions.Configuration;
using InstantRemote.Core.Contracts.Factories.Common;
using InstantRemote.Core.Contracts.Repositories.Common;
using AutoMapper;

namespace InstantRemote.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {

        private IDbConnection connection = null;
        private IDbConnection connectionSQL = null;
        private bool _disposed;
        private IDbTransaction transaction = null;
        private IDbTransaction transactionSQL = null;
        private readonly IMapper mapper = null;

        private IRepositoryParameter repositoryParameter = null;
        private IRepositoryCommon repositoryCommon = null;
        private IRepositoryAuth repositoryAuth = null;
        private IRepositoryReports repositoryReports = null;
     
        public UnitOfWork(IConfiguration configuration, IMapper mapper)
        {
            this.mapper = mapper;
            connection = new SqlConnection(configuration.GetConnectionString("ConexionComunes"));
            connectionSQL = new SqlConnection(configuration.GetConnectionString("ConexionComunesSQL"));
            if (string.IsNullOrEmpty(connection.ConnectionString))
                connection.ConnectionString = configuration["ConexionComunes"];
            if (string.IsNullOrEmpty(connectionSQL.ConnectionString))
                connectionSQL.ConnectionString = configuration["ConexionComunesSQL"];
            
            WakeUpDatabase(connection.ConnectionString).Wait();
            connection.Open();
            connectionSQL.Open();
        }
        private async Task WakeUpDatabase(string connectionString)
        {
            int maxRetries = 2;
            for (int attempt = 1; attempt <= maxRetries; attempt++)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        await conn.OpenAsync();
                        using (SqlCommand cmd = new SqlCommand("SELECT 1", conn))
                        {
                            await cmd.ExecuteScalarAsync();
                        }
                    }
                    return; 
                }
                catch (SqlException ex)
                {
                    if (attempt == maxRetries)
                        throw; 
                    await Task.Delay(2000); 
                }
            }
        }
        public IRepositoryAuth RepositoryAuth => repositoryAuth ??= new RepositoryAuth(connection, () => transaction,connectionSQL, () => transactionSQL
            ,mapper);
        public IRepositoryCommon RepositoryCommon => repositoryCommon ??= new RepositoryCommon(connection, () => transaction,connectionSQL, () => transactionSQL,mapper);
        public IRepositoryParameter RepositoryParameter => repositoryParameter ??= new RepositoryParameter(connection, () => transaction,connectionSQL, () => transactionSQL, mapper);
        public IRepositoryReports RepositoryReports => repositoryReports ??= new RepositoryReports(connection, () => transaction,connectionSQL, () => transactionSQL, mapper);

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
                    if (transactionSQL != null)
                    {
                        transactionSQL.Dispose();
                        transactionSQL = null;
                    }
                    if (connection != null)
                    {
                        connection.Dispose();
                        connection = null;
                    }
                    if (connectionSQL != null)
                    {
                        connectionSQL.Dispose();
                        connectionSQL = null;
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
            transactionSQL = connectionSQL.BeginTransaction();
        }

        public void CommitChanges()
        {
            transaction.Commit();
            transaction = null;
            transactionSQL.Commit();
            transactionSQL = null;
        }

        public void RollbackChanges()
        {
            transaction.Rollback();
            transaction = null;
            transactionSQL.Rollback();
            transactionSQL = null;
        }
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
