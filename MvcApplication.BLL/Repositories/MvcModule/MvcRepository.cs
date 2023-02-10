

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MvcApplication.BLL.API;
using MvcApplication.DAL.DbContext;
using MvcApplication.DTO.MvcModule;
using Newtonsoft.Json;
using System.Net.Http.Headers;


namespace MvcApplication.BLL.Repositories.MvcModule
{
    public class MvcRepository : IMvcRepository
    {
        PSMSAPI _api = new PSMSAPI();

        private readonly IMapper mapper;
        public MvcRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }

        //public async Task<List<SearchMvc>> GetByMvcNo(string MvcNumber)
        //{
        //    try
        //    {
        //        HttpClient client = _api.Initial();

        //        client.DefaultRequestHeaders.Accept.Clear();

        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        HttpResponseMessage getData = await client.GetAsync("api/SearchMember/SearchMvc?Mvc=" + MvcNumber + "");

        //        if (getData.IsSuccessStatusCode)
        //        {
        //            string results = getData.Content.ReadAsStringAsync().Result;

        //            var data = JsonConvert.DeserializeObject<List<SearchMvc>>(results);

        //            var mcvDetails = mapper.Map<List<SearchMvc>>(data);

        //            return mcvDetails;
        //        }

        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);

        //        return null;
        //    }
        //}    


        public async Task<List<MvcDTO>> GetByMvcNo(decimal MvcNumber)
        {
            try
            {
                using (SATAContext context = new SATAContext())
                {
                    var data = await context.MvcGeneration.AsNoTracking().Where(x => x.MvcNumber == MvcNumber).ToListAsync();

                    var mvcData = mapper.Map<List<MvcDTO>>(data);

                    return mvcData;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        public async Task<List<MvcDTO>> GetMvc(decimal HospitalCode)
        {
            try
            {
                using (SATAContext context = new SATAContext())
                {
                    var data = await context.MvcGeneration.AsNoTracking().Where(x => x.HospitalCode == 649).Take(100).OrderBy(x => Guid.NewGuid()).ToListAsync();

                    var mvcData = mapper.Map<List<MvcDTO>>(data);

                    return mvcData;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

    }
}


