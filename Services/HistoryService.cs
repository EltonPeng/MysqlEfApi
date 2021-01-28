using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using mysqlEfApi.Models;

namespace mysqlEfApi.Services
{
    public class HistoryService : IHistoryService
    {
        private AppContext context;

        public HistoryService() 
        {
            context = new AppContext();
            context.Database.EnsureCreated();
        }

        public void AddRecord(HistoryRecord historyRord)
        {
            context.History.Add(historyRord);
            context.SaveChanges();
        }

        public IEnumerable<HistoryRecord> GetAll()
        {
            return context.History.Include(h => h.Line);
        }
    }
}