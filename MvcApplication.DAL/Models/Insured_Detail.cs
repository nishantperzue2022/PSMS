using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcApplication.DAL.Models
{
    public partial class Insured_Detail
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public decimal? auto_id { get; set; }
        public decimal? control_no { get; set; }
        public decimal? sno { get; set; }
        public string? emp_code { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public string? Sex { get; set; }
        public string? relation { get; set; }
        public decimal? sum_insured { get; set; }
        public decimal? comm { get; set; }
        public decimal? dhl { get; set; }
        public decimal? prem { get; set; }
        public decimal? card_stat { get; set; }
        public decimal? dispatch { get; set; }
        public DateTime? datejoin { get; set; }
        public string? BarCode { get; set; }
        public string? Society { get; set; }
        public string? Region { get; set; }
        public string? State { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? NameRL { get; set; }
        public string? Address { get; set; }
        public string? addressRL { get; set; }
        public string? ImagePath { get; set; }
        public DateTime? EntryDate { get; set; }
        public string? Class { get; set; }
        public decimal? PreCardNo { get; set; }
        public string? PreCardNoAll { get; set; }
        public DateTime? iDate { get; set; }
        public int Deleted { get; set; }
        public int ZoneCode { get; set; }
        public int DcsCode { get; set; }
        public int DcsSrNo { get; set; }
        public string? BankIFSC { get; set; }
        public string? BankCity { get; set; }
        public string? BankName { get; set; }
        public string? AccountNo { get; set; }
        public string? AccountType { get; set; }
        public string? BankBranch { get; set; }
        public string? Mobile { get; set; }
        public DateTime? ResignDate { get; set; }
        public DateTime? DOB { get; set; }
        public decimal? Height { get; set; }
        public decimal? Weight { get; set; }
        public string? EndoType { get; set; }
        public DateTime EndoDate { get; set; }
        public string? NomineeName { get; set; }
        public string? NomineeRelation { get; set; }
        public string? PreExistD { get; set; }
        public int? IdNo { get; set; }
        public decimal? FamilyID { get; set; }
        public string? MaritalStatus { get; set; }
        public decimal? EndoNo { get; set; }
        public string? Remarks { get; set; }
        public string? BloodGroup { get; set; }
        public decimal? OccupationCode { get; set; }
        public string? Email { get; set; }
        public string? Location { get; set; }
        public string? VerificationCode { get; set; }
        public string? Password { get; set; }
        public string? MemberId { get; set; }
        public string? VIPClient { get; set; }
        public decimal? BalSumInsured { get; set; }
        public decimal? EntityId { get; set; }
        public decimal? BANNo { get; set; }
        public string? BRCode { get; set; }
        public DateTime? InceptionDate { get; set; }
        public string? SuperTopUp { get; set; }
        public string? SpouseName { get; set; }
        public string? Status { get; set; }
        public string? Pin { get; set; }
        public string? IntegrationKey { get; set; }
        public string? NationalIDPassportNo { get; set; }
        public string? HudumaNumber { get; set; }
        public string? BirthCertificateNumber { get; set; }
        public string? SpouseNationalIDPassportNo { get; set; }
        public string? JobGroup { get; set; }
        public string? Fingerprint { get; set; }
        public string? FingerprintEnrollment { get; set; }
        public bool? IsActive { get; set; }
        public string? ActivateBy { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateOfActivation { get; set; }
    }

}
