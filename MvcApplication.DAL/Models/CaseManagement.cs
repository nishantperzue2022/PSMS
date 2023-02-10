namespace MvcApplication.DAL.Models
{
    public partial class CaseManagement
    {
        public Guid Id { get; set; }
        public string? MemberNo { get; set; }
        public string? PreauthNo { get; set; }
        public string? PatientName { get; set; }
        public string? PatientAge { get; set; }
        public string? HospitalName { get; set; }
        public DateTime? DateofAdmission { get; set; }
        public string? County { get; set; }
        public string? ELOS { get; set; }
        public int? OccupiedBedDay { get; set; }
        public string? ReasonsforAdmission { get; set; }
        public string? Diagnosis { get; set; }
        public string? ReasonsforVariance { get; set; }
        public DateTime? DateofDischarge { get; set; }
        public string? InterimBills { get; set; }
        public string? NHIFLimits { get; set; }
        public string? CSMName { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string? Regions { get; set; }
        public string? NoneCaseNotes { get; set; }
        public string? CaseNotes { get; set; }
        public string? VitalSigns { get; set; }
        public string? Medications { get; set; }
        public string? Recommendations { get; set; }
        public string? InvestigationsAndResults { get; set; }
        public DateTime ReceivedDate { get; set; }
    }
}
