using System.ComponentModel.DataAnnotations;

namespace SqlClientBackend.Models
{
    public class EmailCode
    {
        public int id { get; set; }
        [Required]
        [StringLength(20)]
        [EmailAddress]
        public required string email { get; set; }
        public string? code { get; set; }
    }


    public class EmailCodeInit
    {
        public int id { get; set; }
        [Required]
        [StringLength(20)]
        [EmailAddress]
        public string email { get; set; }
        public string code { get; set; }
        public EmailCodeInit(string email, string code)
        {
            this.email = email;
            this.code = code;
        }
    }
}