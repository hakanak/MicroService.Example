using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogService.Data.Entities
{
    public class Log
    {
        public string Id { get; set; } = null!;
        public string ServiceName { get; set; } = null!;
        public string LogType { get; set; } = null!;
        public string LogException { get; set; } = null!;
        public DateTime LogDate { get; set; }
    }
}
