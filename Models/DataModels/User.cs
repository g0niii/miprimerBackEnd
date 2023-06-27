using System.ComponentModel.DataAnnotations;

namespace myFirstBackend.Models.DataModels
{
    public class User : BaseEntity
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(100)]
        public string LastNamer { get; set; } = string.Empty;
        [Required, EmailAddress]
        public string EmailAddress { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; }
    }
}
