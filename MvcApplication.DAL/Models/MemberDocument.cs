using System.ComponentModel.DataAnnotations;

namespace MvcApplication.DAL.Models
{
    public partial class MemberDocument
    {
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public Guid DocumentTypeId { get; set; }
        public string CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }
        public DateTime CreateDate { get; set; }

        [StringLength(450)]
        public string AtachmentFile { get; set; }
        public byte Status { get; set; }

        [StringLength(450)]
        public string ImageUrl { get; set; }
    }
}
