using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapiDotNet8.Dtos.Stock;
using webapiDotNet8.Extensions;
using webapiDotNet8.Models;

namespace webapiDotNet8.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stock>> GetAllAsync(QueryObject query);
        Task<Stock?> GetByIdAsync(int id);
        Task<Stock?> GetBySymbolAsync(string symbol);
        Task<Stock> CreateAsync(Stock stockModel);
        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        Task<Stock?> DeleteAsync(int id);
        Task<bool> StockExists(int id);
    }
}