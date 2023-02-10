using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApplication.DAL.Models
{
    public class MvcGeneration
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public decimal? MvcNumber { get; set; }
        public decimal? MamberNo { get; set; }
        public DateTime? MvcDate { get; set; }
        public string? MemberName { get; set; }
        public string? Scheme { get; set; }
        public string? Department { get; set; }
        public string? Status { get; set; }
        public string? SubDepartment { get; set; }
        public decimal? HospitalCode { get; set; }
        public bool? IsMvcLocked { get; set; }
        public bool? IsPreAuthLocked { get; set; }
        public bool? IsClaimLocked { get; set; }
        public DateTime? LockedDate { get; set; }
        public DateTime? MvcValidToDate { get; set; }
        public string? LockRemark { get; set; }
        public DateTime? UnlockedDate { get; set; }
        public string? UnlockRemark { get; set; }

    }
}
