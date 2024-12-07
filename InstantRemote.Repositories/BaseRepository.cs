using System;
using System.Data;

namespace InstantRemote.Repositories
{
    public class BaseRepository
    {
        protected readonly Func<IDbTransaction> transaction = null;
        protected IDbConnection Connection { get; private set; }
        protected IDbTransaction Transaction => transaction();
        protected BaseRepository(IDbConnection connection, Func<IDbTransaction> transaction)
        {
            Connection = connection;
            this.transaction = transaction;
        }
    }
}
