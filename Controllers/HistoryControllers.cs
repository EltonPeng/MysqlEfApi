using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using mysqlEfApi.Models;

namespace mysqlEfApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HistoryController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<HistoryRecord> Get()
        {
            return new List<HistoryRecord> { new HistoryRecord { UserId = "1" } };
        }
    }
}
