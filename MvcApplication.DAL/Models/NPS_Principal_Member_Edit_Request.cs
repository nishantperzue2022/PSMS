using System.ComponentModel.DataAnnotations;

namespace MvcApplication.DAL.Models
{
    public partial class NPS_Principal_Member_Edit_Request
    {
        public Guid Id { get; set; }

        [StringLength(450)]
        public string MemberNumber { get; set; }

        [StringLength(450)]
        public string? PrincipalNumber { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public string? DocumentTypeCode { get; set; }
        public string? DocumentNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Relation { get; set; }
        public string? PhoneNumber { get; set; }
        public string? JobGroup { get; set; }
        public string? Country { get; set; }
        public string? Occupation { get; set; }
        public string? Email { get; set; }
        public string? FullAddress { get; set; }
        public string? Pin { get; set; }
        public string? EmployerRegistrationNumber { get; set; }
        public string? NHIFNumber { get; set; }
        public byte Status { get; set; }
        public string? CreatedBy { get; set; }
        public string? Remarks { get; set; }
        public DateTime CreateDate { get; set; }
        public string? ApprovedBy { get; set; }
        public DateTime? DateOfApproval { get; set; }
    }
}
