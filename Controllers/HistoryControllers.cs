using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using mysqlEfApi.Models;
using mysqlEfApi.Services;

namespace mysqlEfApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HistoryController : ControllerBase
    {
        private IHistoryService historyService;

        public HistoryController(IHistoryService service)
        {
            historyService = service;
        }

        [HttpGet]
        public IEnumerable<HistoryRecord> Get()
        {
            return historyService.GetAll();
        }
    }
}
