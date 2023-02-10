using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication.DAL.Models
{
    public partial class PSMSActivate_DeactivateRequest
    {
        public Guid Id { get; set; }
        public string AutoId { get; set; }
        public string MemberNumber { get; set; }
        public string Relation { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public bool IsActive { get; set; }
    }
}
