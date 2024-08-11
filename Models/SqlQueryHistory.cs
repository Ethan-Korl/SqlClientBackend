using SqlClientBackend.Models;

namespace SqlClientBackend.Models
{
    public class SqlQueryHistory
    {
        public required User query_by { get; set; }
        public required DateTime query_at { get; set; }
        public required string query  { get; set; }
    }
}