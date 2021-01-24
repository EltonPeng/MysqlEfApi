using System.Collections.Generic;
using mysqlEfApi.Models;

namespace mysqlEfApi.Services
{
    public interface IHistoryService
    {
        void AddRecord(HistoryRecord historyRord);

        IEnumerable<HistoryRecord> GetAll();
    }
}