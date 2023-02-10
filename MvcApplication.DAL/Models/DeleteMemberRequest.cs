using System.ComponentModel.DataAnnotations;


namespace MvcApplication.DAL.Models
{
    public partial class DeleteMemberRequest
    {
        public Guid Id { get; set; }

        [StringLength(450)]
        public string MemberNumber { get; set; }
        public byte Status { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
