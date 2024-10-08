using System.ComponentModel.DataAnnotations;

namespace SqlClientBackend.Models
{
    public class ConnectedDb
    {
        [Key]
        public required int id { get; set; }
        public required string database_user { get; set; }
        public required string host { get; set; }
        public required int port { get; set; }
        public required string password { get; set; }

    }
}