using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApplication.DAL.Models
{
    public partial class Scheme
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public decimal auto_id { get; set; }
        public decimal? Control_no { get; set; }
        public decimal? branchcode { get; set; }
        public decimal? cust_code { get; set; }
        public string? pre { get; set; }
        public string? officer { get; set; }
        public string? insurer { get; set; }
        public decimal? insurer_code { get; set; }
        public string? policy_stat { get; set; }
        public string? policy_cat { get; set; }
        public string? policy_type { get; set; }
        public string? policy_no { get; set; }
        public DateTime? start_date { get; set; }
        public DateTime? exp_date { get; set; }
        public decimal? premium { get; set; }
        public string? remarks { get; set; }
        public DateTime? i_date { get; set; }
        public string? userid { get; set; }
        public string? commission { get; set; }
        public decimal? dispatch { get; set; }
        public DateTime? disp_date { get; set; }
        public decimal? billing { get; set; }
        public DateTime? bill_date { get; set; }
        public string? vb { get; set; }
        public string? photo { get; set; }
        public decimal? BrokerCode { get; set; }
        public decimal? PreControl_no { get; set; }
        public string? PreControlAll { get; set; }
        public string? PaymentMode { get; set; }
        public decimal? LotNo { get; set; }
        public string? CardType { get; set; }
        public decimal? BuffSumInsured { get; set; }
        public string? MobileCard { get; set; }
        public DateTime? Policy_Idate { get; set; }
        public string? Previouspolicyno { get; set; }
        public string? ClaimPartycode { get; set; }
        public string? CoPayType { get; set; }
        public string? TPABranch { get; set; }
    }
}
