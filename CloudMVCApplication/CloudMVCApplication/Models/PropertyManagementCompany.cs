using System.ComponentModel.DataAnnotations;

namespace CloudMVCApplication.Models
{
    public class PropertyManagementCompany
    {
        [Key]
        public int CompanyId { get; set; }

        [Required]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        public string CompanyEmail { get; set; } = string.Empty;

        public string? CompanyPhone { get; set; }

        public string? CompanyAddress { get; set; }

        public string Status { get; set; } = "Active";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<ApplicationUser> Users { get; set; } = new List<ApplicationUser>();
    }
}