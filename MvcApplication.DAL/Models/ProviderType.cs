using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication.DAL.Models
{
    public partial class ProviderType
    {
        public Guid Id { get; set; }
        public string? Region { get; set; }
        public string? County { get; set; }
        public string? SubCounty { get; set; }
        public string? Town { get; set; }
        public string? ProviderCode { get; set; }
        public string? NameofServiceProvider { get; set; }
        public string? Category { get; set; }
        public string? Access { get; set; }
        public string? Department { get; set; }
        public string? CapitationAmount { get; set; }
        public string? ProviderStatus { get; set; }
        public string? HospitalLevels { get; set; }
        public string? Contact { get; set; }
        public string? Email { get; set; }
        public string? Status { get; set; }
        public string? CoPayStatus { get; set; }
        public string? CoPayAmount { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
