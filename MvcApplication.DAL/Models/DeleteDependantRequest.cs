namespace MvcApplication.DAL.Models
{
    public partial class DeleteDependantRequest
    {
        public Guid Id { get; set; }
        public string MemberNumber { get; set; }
        public string PrincipalNumber { get; set; }
        public string CreatedBy { get; set; }
        public byte Status { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
