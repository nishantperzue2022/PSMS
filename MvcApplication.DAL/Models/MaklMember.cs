namespace MvcApplication.DAL.Models
{
    public partial class MaklMember
    {
        public Guid Id { get; set; }
        public Guid BatchNo { get; set; }
        public string? MemberNumber { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Relation { get; set; }
        public string? PhoneNumber { get; set; }
        public string? JobGroup { get; set; }
        public byte Status { get; set; }
        public string? CreatedBy { get; set; }
        public string? ApprovedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public decimal SchemeId { get; set; }
    }
}
