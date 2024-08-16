using SqlClientBackend.Models;
namespace SqlClientBackend.Models
{
    public class QueryHistory
    {
        public required int id { get; set; }
        public required User query_by { get; set; }
        public required DateTime query_at { get; set; }
        public required ConnectedDb database { get; set; }
        public required string command { get; set; }
    }
}