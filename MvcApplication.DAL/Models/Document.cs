using System.ComponentModel.DataAnnotations;

namespace MvcApplication.DAL.Models
{
    public partial class Document
    {
        public Guid Id { get; set; }

        [StringLength(450)]
        public string MemberNumber { get; set; }
        public string Name { get; set; }
        [StringLength(450)]
        public string? DocumentUrl { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
