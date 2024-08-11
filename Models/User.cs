
namespace SqlClientBackend.Models
{
    public class User
    {
        public required string email { get; set; }
        public required string password { get; set; }
        public DateTime? date_created { get; set; }
        
    }
}