using CrossExchange.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrossExchange.Repository
{
    public interface ITradeRepository : IGenericRepository<Trade>
    {
        Task<List<Trade>> GetAllTradings(int portFolioId);
    }
}