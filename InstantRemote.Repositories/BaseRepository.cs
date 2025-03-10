using AutoMapper;
using System.Data;

namespace InstantRemote.Repositories
{
    public class BaseRepository
    {
        protected readonly IMapper mapper;

        protected readonly Func<IDbTransaction> transaction = null;
        protected IDbConnection Connection { get; private set; }
        protected IDbTransaction Transaction => transaction();
        
        protected readonly Func<IDbTransaction> transactionSQL = null;
        protected IDbConnection ConnectionSQL { get; private set; }
        protected IDbTransaction TransactionSQL => transactionSQL();
        protected BaseRepository(IDbConnection connection, Func<IDbTransaction> transaction,IDbConnection connectionSQL, Func<IDbTransaction> transactionSQL , IMapper mapper)
        {
            Connection = connection;
            this.transaction = transaction;
            ConnectionSQL = connectionSQL;
            this.transactionSQL = transactionSQL;
            this.mapper = mapper;
        }
    }
}
