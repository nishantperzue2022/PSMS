using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcApplication.DAL.Models
{
    public partial class PSMSMember
    {
        public Guid Id { get; set; }
        public int ControlNo { get; set; }
        [Key]
        public int SNo { get; set; }
        public string? EmpCode { get; set; }
        public string? Name { get; set; }
        public string? Age { get; set; }
        public string? Sex { get; set; }
        public string? Relation { get; set; }
        public string? RumInsured { get; set; }
        public string? Comm { get; set; }
        public string? Dhl { get; set; }
        public string? Prem { get; set; }
        public string? CardStat { get; set; }
        public string? Dispatch { get; set; }
        public string? DateJoin { get; set; }
        public string? BarCode { get; set; }
        public string? Society { get; set; }
        public string? Region { get; set; }
        public string? State { get; set; }
        public string? District { get; set; }
        public string? City { get; set; }
        public string? NameRL { get; set; }
        public string? Address { get; set; }
        public string? AddressRL { get; set; }
        public string? ImagePath { get; set; }
        public string? EntryDate { get; set; }
        public string? Class { get; set; }
        public string? PreCardNo { get; set; }
        public string? PreCardNoAll { get; set; }
        public string? IDate { get; set; }
        public string? Deleted { get; set; }
        public string? ZoneCode { get; set; }
        public string? DcsCode { get; set; }
        public string? DcsSrNo { get; set; }
        public string? BankIFSC { get; set; }
        public string? BankCity { get; set; }
        public string? BankName { get; set; }
        public string? AccountNo { get; set; }
        public string? AccountType { get; set; }
        public string? BankBranch { get; set; }
        public string? Mobile { get; set; }
        public string? ResignDate { get; set; }
        public string? DOB { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public string? EndoType { get; set; }
        public string? EndoDate { get; set; }
        public string? NomineeName { get; set; }
        public string? NomineeRelation { get; set; }
        public string? PreExistD { get; set; }
        public string? IdNo { get; set; }
        public string? FamilyID { get; set; }
        public string? MaritalStatus { get; set; }
        public string? EndoNo { get; set; }
        public string? Remarks { get; set; }
        public string? BloodGroup { get; set; }
        public string? OccupationCode { get; set; }
        public string? Email { get; set; }
        public string? Location { get; set; }
        public string? VerificationCode { get; set; }
        public string? Password { get; set; }
        public string? MemberId { get; set; }
        public string? VIPClient { get; set; }
        public string? BalSumInsured { get; set; }
        public string? EntityId { get; set; }
        public string? BANNo { get; set; }
        public string? BRCode { get; set; }
        public string? InceptionDate { get; set; }
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

    }
}
