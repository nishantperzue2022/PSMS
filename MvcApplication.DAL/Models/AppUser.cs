using Microsoft.AspNetCore.Identity;

namespace MvcApplication.DAL.Models
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CreatedBy { get; set; }
        public bool IsActive { get; set; }
        public bool HasAccessToAdmin { get; set; }
        public bool HasAccessToReport { get; set; }
        public bool HasAccessToEdit { get; set; }
        public bool HasAccessToClaims { get; set; }
        public bool HasAccessToBilling { get; set; }
        public bool HasAccessToAccounts { get; set; }
        public bool ReinstateMember { get; set; }
        public bool UploadMembers { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid DepartmentId { get; set; }
        public Guid BranchId { get; set; }
    }
}
