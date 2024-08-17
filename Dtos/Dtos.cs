using System.ComponentModel.DataAnnotations;

namespace SqlClientBackend.Dtos
{
    public record UserDto
    {
        [Required]
        public required string email { get; set; }

        [StringLength(50)]
        public string? username { get; set; }

        [Required]
        public required string password { get; set; }
        public DateTime? date_created { get; set; }
    }

    public record EamilVerificationDto
    {
        [Required]
        [StringLength(20)]
        [EmailAddress]
        public required string email { get; set; }
    }
}