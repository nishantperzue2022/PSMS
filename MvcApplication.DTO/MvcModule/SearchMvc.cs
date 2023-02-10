using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication.DTO.MvcModule
{
    public class SearchMvc
    {
            public string mvcNumber { get; set; }
            public string memberNumber { get; set; }
            public string memberName { get; set; }
            public DateTime mvcDate { get; set; }
            public string scheme { get; set; }
            public string department { get; set; }
            public string subDepartment { get; set; }
            public string hospitalCode { get; set; }
            public object modeName { get; set; }
            public object capitationAmount { get; set; }       
    }
}
