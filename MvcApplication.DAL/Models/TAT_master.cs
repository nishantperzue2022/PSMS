using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApplication.DAL.Models
{
    public partial class TAT_master
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public long AutoId { get; set; }
        public long ClaimId { get; set; }
        public string Stags { get; set; }
        public string IUser { get; set; }
        public DateTime Idate { get; set; }
        public string StageTAT { get; set; }
        public int InstNo { get; set; }
        public DateTime TATDate { get; set; }
        public string PageName { get; set; }
        public string CreatedBy { get; set; }
        public string Remarks { get; set; }
        public decimal RequestedAmount { get; set; }
        public decimal ApprovedAmount { get; set; }
        public long PreAuthLogID { get; set; }
    }
}
