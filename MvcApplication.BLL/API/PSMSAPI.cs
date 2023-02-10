using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApplication.BLL.API
{
    public class PSMSAPI
    {
        public HttpClient Initial()
        {
            try
            {
                var client = new HttpClient();

                client.BaseAddress = new Uri("https://api.makl-psms.com/");

                return client;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }
    }
}
