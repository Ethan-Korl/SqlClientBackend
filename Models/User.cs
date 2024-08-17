using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SqlClientBackend.Models
{
    public class User
    {   
        public required int id { get; set; }
        public required string email { get; set; }

        [StringLength(50)]
        public string? username { get; set; }

        [Required]
        public required string password { get; set; }
        public DateTime? date_created { get; set; }

    }
}