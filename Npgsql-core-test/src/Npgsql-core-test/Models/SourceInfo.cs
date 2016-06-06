using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Npgsql_core_test.Models
{
    public class SourceInfo
    {
        public long SourceInfoId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Timestamp { get; set; }
        public List<DataEventRecord> DataEventRecords { get; set; }
    }
}
