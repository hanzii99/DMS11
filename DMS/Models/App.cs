using System.ComponentModel.DataAnnotations;

namespace DMS.Models
{
    public class App
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Category is required")]
        public string Catogary { get; set; } = string.Empty;
        public string Storage { get; set; } = string.Empty;

        public string CreatedBy { get; set; } = string.Empty;
        



        public string DocumentStatus { get; set; } = string.Empty;
        public string Client { get; set; } = string.Empty;

        public string MetaTags { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }

        public string AssignRole { get; set; } = string.Empty;
        public string AssignUser { get; set; } = string.Empty;

        public string IP { get; set; } = string.Empty;
        [Required(ErrorMessage = "Name is required")]
        public string? FilePath { get; set; } 

    }
}