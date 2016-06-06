using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Npgsql_core_test.Models
{
    public class DataEventRecord
    {
        public long DataEventRecordId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
        public SourceInfo SourceInfo { get; set; }
        public int SourceInfoId { get; set; }
    }
}
