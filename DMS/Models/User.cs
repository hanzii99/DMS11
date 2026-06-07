using System.ComponentModel.DataAnnotations;

namespace DMS.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;

        public string AssignRole { get; set; } = string.Empty;

        public string PhoneNumber { get; set; } = "";
    }
}