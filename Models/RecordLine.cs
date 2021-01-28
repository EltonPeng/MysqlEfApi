using System.Collections.Generic;

namespace mysqlEfApi.Models
{
    public class RecordLine
    {
        public RecordLine()
        {
        }

        public string Token { get; set; }
        public int Index { get; set; }
        public bool Finished { get; set; }
    }
}
