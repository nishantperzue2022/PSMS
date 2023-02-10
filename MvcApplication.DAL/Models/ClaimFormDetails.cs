using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication.DAL.Models
{
    public class ClaimFormDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public decimal? Auto_id { get; set; }
        public decimal? MVCNO { get; set; }
        public string? Member_No { get; set; }
        public decimal? UHID { get; set; }
        public string? RemarksType { get; set; }
        public string? Remarks { get; set; }
        public string? Status { get; set; }
        public string? MediClaimRemarks { get; set; }
        public string? MedicfinalClaimRemarks { get; set; }
        public string? HospitalPreviousClaimStatus { get; set; }
    }
}
