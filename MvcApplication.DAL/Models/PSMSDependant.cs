using System.ComponentModel.DataAnnotations;


namespace MvcApplication.DAL.Models
{
    public partial class PSMSDependant
    {
        public Guid Id { get; set; }
        public string? EmpCode { get; set; }
        public string? PrincipalNo { get; set; }
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public string? SchemeName { get; set; }
        public string? JobGroup { get; set; }
        public string? Relation { get; set; }
        public string? Pin { get; set; }
        public string? DOB { get; set; }
        public string? NationalIDPassportNo { get; set; }
        public string? Mobile { get; set; }
        public string? DateJoin { get; set; }
        public string? Status { get; set; }
        public DateTime CreateDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? UniqueNo { get; set; }

    }
}
