using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CloudMVCApplication.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string FullName { get; set; } = string.Empty;

        public int CompanyId { get; set; }

        public PropertyManagementCompany? Company { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}