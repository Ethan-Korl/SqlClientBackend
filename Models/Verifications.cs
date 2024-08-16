namespace SqlClientBackend.Models
{
    public class EmailCode
    {   
        public int id { get; set; }
        public required string email { get; set; }
        public required string code { get; set; }
    }
}