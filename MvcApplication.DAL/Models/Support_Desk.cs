using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApplication.DAL.Models
{

    public class Support_Desk
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public decimal? Auto_id { get; set; }
        public decimal? Member_autoId { get; set; }
        public decimal? MemberNo { get; set; }
        public decimal? MvcNo { get; set; }
        public decimal? Hospitalcode { get; set; }
        public DateTime? UploadedAt { get; set; }
        public string? Iuser { get; set; }
        public string? Listofissue { get; set; }
        public string? Remarks { get; set; }
        public string? Filename { get; set; }
        public string? Department { get; set; }
        public string? Subdepartment { get; set; }
        public string? Status { get; set; }
        public string? MedicRemarks { get; set; }
        public string? MinetRemarks { get; set; }
        public string? MaklRemarks { get; set; }
        public DateTime? MinetDatetime { get; set; }
        public DateTime? ResolveDatetime { get; set; }
        public string? TotalTime { get; set; }
        public string? AssignedTo { get; set; }
        public string? ResolvedBy { get; set; }
        public bool? IsOpen { get; set; }
        public int? EscalationLevel { get; set; }
        public DateTime? EscalationTime { get; set; }
    }
}
