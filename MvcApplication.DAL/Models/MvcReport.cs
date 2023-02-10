using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication.DAL.Models
{
    public class MvcReport
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string? MvcNumber { get; set; }
        public string? MemberNo { get; set; }
        public string? MvcDate { get; set; }
        public string? MemberName { get; set; }
        public string? Scheme { get; set; }
        public string? Department { get; set; }
        //  public string? Status { get; set; }
        public string? SubDepartment { get; set; }
        //public decimal? HospitalCode { get; set; }
        public string? HospitalCatagory { get; set; }
        public string? Dob { get; set; }
        public string? Relation { get; set; }
        public string? JobGroup { get; set; }
        public string? HospitalName { get; set; }
        public string? County { get; set; }
        public string? Subcounty { get; set; }
        public string? SourceOfAdmission { get; set; }
        public string? PresentComplaints { get; set; }
        public string? PresentHistory { get; set; }
        public string? MVCcreatedBy { get; set; }
        public string? preauthcreatedate { get; set; }
        public decimal? TotalRequestAmount { get; set; }
        public decimal? TotalApprovedAmount { get; set; }
        public string? ApprovalStatus { get; set; }
        public string? ActionTakenBy { get; set; }
        public string? DischargeDate { get; set; }
        public string? DischargeStatus { get; set; }
        public decimal? Claim_Request_Amount { get; set; }
        public string? Claim_Request_Date { get; set; }
        public string? Claim_Request_Remarks { get; set; }
        public string? Claim_RequestedBy { get; set; }
        public decimal? Claim_Approved_Amount { get; set; }
        public string? Claim_Approved_Date { get; set; }
        public string? Claim_Approved_Remarks { get; set; }
        public string? Claim_ApprovedBy { get; set; }
        public string? ClaimNo { get; set; }
        public string? ClaimStatus { get; set; }
        public string? MedicalStatus { get; set; }
        public string? Diagnosis { get; set; }
    }
}

