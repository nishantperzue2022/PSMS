using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication.DAL.Models
{
    public class PREAUTHCIRNDETAILS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public decimal AutoId { get; set; }
        public decimal UHID { get; set; }
        public string? PatientName { get; set; }
        public string? Claimcatagary { get; set; }
        public decimal? ApproxClaimAmount { get; set; }
        public decimal? HospitalCode { get; set; }
        public string? HospitalName { get; set; }
        public string? DoctorName { get; set; }
        public string? firstDoctorCunslted { get; set; }
        public DateTime? Date { get; set; }
        public string? PresentComplaints { get; set; }
        public string? PresentHistory { get; set; }
        public string? Duration { get; set; }
        public string? lineoftreatment { get; set; }
        public string? RelevantClinicFind { get; set; }
        public string? TreatmentPlan { get; set; }
        public string? RelevantpastHistory { get; set; }
        public string? FaxNo { get; set; }
        public DateTime? FaxIndate { get; set; }
        public string? HyperTension { get; set; }
        public string? HyperTensionSince { get; set; }
        public string? IHD { get; set; }
        public string? IHDSince { get; set; }
        public string? Ostrothrits { get; set; }
        public string? OstrothritsSince { get; set; }
        public string? Copd { get; set; }
        public string? CopdSince { get; set; }
        public string? OtherChronidisorder { get; set; }
        public string? OtherChronidisorderSince { get; set; }
        public string? Diabities { get; set; }
        public string? DiabitiesSince { get; set; }
        public string? Heartdisease { get; set; }
        public string? HeartdiseaseSince { get; set; }
        public string? cancer { get; set; }
        public string? cancerSince { get; set; }
        public string? Alcohal { get; set; }
        public string? AlcohalSince { get; set; }
        public string? Abortion { get; set; }
        public string? AbortionSince { get; set; }
        public string? living { get; set; }
        public string? Para { get; set; }
        public string? Gravida { get; set; }
        public string? Lmp { get; set; }
        public DateTime? Admdate { get; set; }
        public string? AcmmdationClass { get; set; }
        public decimal? InvestiCharge { get; set; }
        public decimal? Packagerate { get; set; }
        public decimal DoctorsurgFee { get; set; }
        public decimal? OTCharge { get; set; }
        public decimal? Medicines { get; set; }
        public decimal? TotalCharge { get; set; }
        public string? AproxStay { get; set; }
        public decimal? Roomrent { get; set; }
        public decimal? ApproxExpenses { get; set; }
        public string? ICDCode { get; set; }
        public string? ICDCode2 { get; set; }
        public string? ICDCode3 { get; set; }
        public string? ICDCode4 { get; set; }
        public string? ICDCode5 { get; set; }
        public string? ParentCode { get; set; }
        public string? ParentCode2 { get; set; }
        public string? ParentCode3 { get; set; }
        public string? ParentCode4 { get; set; }
        public string? ParentCode5 { get; set; }
        public string? Diagnosis { get; set; }
        public string? Diagnosis2 { get; set; }
        public string? Diagnosis3 { get; set; }
        public string? Diagnosis4 { get; set; }
        public string? Diagnosis5 { get; set; }
        public string? Remarks { get; set; }
        public decimal? AprvdAmount { get; set; }
        public decimal? MVCNO { get; set; }
        public string? MedicalStatus { get; set; }
        public string? SourceofAdmission { get; set; }
        public DateTime? TenTativeDischarge { get; set; }
        public DateTime? DischargeDate { get; set; }
        public string? NHIFNO { get; set; }
        public string? NHIFStatus { get; set; }
        public string? NHIFRebate { get; set; }
        public string? NHIFApprovedRebate { get; set; }
        public string? InvoiceNo { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public decimal? PulseRate { get; set; }
        public decimal? ReservationRate { get; set; }
        public decimal? Temperature { get; set; }
        public string? ApprovalStatus { get; set; }
        public string? DischargeStatus { get; set; }
        public DateTime? IDATE { get; set; }
        public string? PreviousStatus { get; set; }
        public string? FinalRemarks { get; set; }
        public DateTime? Extensiondate { get; set; }
        public string? ExtensionDay { get; set; }
        public string? IUSER { get; set; }
        public string? ApprovedDay { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string? Extensionremarks { get; set; }
        public string? Referralhospital { get; set; }
        public decimal? ReferralHospitalCode { get; set; }
        public string? ICcdCode6 { get; set; }
        public string? ICcdCode7 { get; set; }
        public string? ICcdCode8 { get; set; }
        public string? ICcdCode9 { get; set; }
        public string? ICcdCode10 { get; set; }
        public string? ICcdCode11 { get; set; }
        public string? ICcdCode12 { get; set; }
        public string? ICcdCode13 { get; set; }
        public string? ICcdCode14 { get; set; }
        public string? ICcdCode15 { get; set; }
        public string? ICcdCode16 { get; set; }
        public string? ICcdCode17 { get; set; }
        public string? ICcdCode18 { get; set; }
        public string? ICcdCode19 { get; set; }
        public string? ICcdCode20 { get; set; }
        public string? SchoolingProof { get; set; }
        public decimal? TotalRequestAmount { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? PreviousHospitalStatus { get; set; }
        public string? PreviousHospitalHospitalRemarks { get; set; }
        public string? ActionTakenBy { get; set; }
        public decimal? TotalApprovedAmount { get; set; }
        public string? PageName { get; set; }
        public string? HospitalCategory { get; set; }
        public bool? IsFreeTreatment { get; set; }
        public string? Stage { get; set; }
        public string? ReopenAction { get; set; }
        public decimal? ReopenAmount { get; set; }
        public decimal? FirstAmount { get; set; }
        public decimal? TotalAmountTaken { get; set; }
    }
}
