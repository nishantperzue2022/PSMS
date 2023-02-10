using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication.DAL.Models
{
    public class tbl_claimProcess
    {
        public int Id { get; set; }
        public decimal MvcNumber { get; set; }
        public string? Member_No { get; set; }
        public decimal? Claim_Request_Amount { get; set; }
        public DateTime? Claim_Request_Date { get; set; }
        public string? Claim_Request_Remarks { get; set; }
        public string? Claim_RequestedBy { get; set; }
        public string? Status { get; set; }
        public string? HospitalPreviousClaimStatus { get; set; }
        public decimal? Claim_Approved_Amount { get; set; }
        public DateTime? Claim_Approved_Date { get; set; }
        public string? Claim_Approved_Remarks { get; set; }
        public string? Claim_ApprovedBy { get; set; }
    }
}
