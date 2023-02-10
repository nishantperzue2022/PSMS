using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MvcApplication.BLL.API;
using MvcApplication.DAL.DbContext;
using MvcApplication.DTO.MvcModule;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace MvcApplication.BLL.Repositories.MemberModule
{
    public class MemberRepository : IMemberRepository
    {
        PSMSAPI _api = new PSMSAPI();

        private readonly IMapper mapper;
        public MemberRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }

        //public async Task<List<MvcMemberDTO>> GetByMemberNo(string MemberNo, string SchemeNo)
        //{
        //    try
        //    {
        //        HttpClient client = _api.Initial();

        //        client.DefaultRequestHeaders.Accept.Clear();

        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        HttpResponseMessage getData = await client.GetAsync("api/SearchMember/SearchMemberByScheme?MemberNo=" + MemberNo + "&SchemeNo=" + SchemeNo + "");

        //        if (getData.IsSuccessStatusCode)
        //        {
        //            string results = getData.Content.ReadAsStringAsync().Result;

        //            var getDependants = JsonConvert.DeserializeObject<List<MvcMemberDTO>>(results);

        //            var dependants = mapper.Map<List<MvcMemberDTO>>(getDependants);

        //            return dependants;
        //        }

        //        return null;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);

        //        return null;
        //    }
        //}  

        public async Task<List<MemberDTO>> GetByMemberNo(string MemberNo, decimal SchemeNo)
        {
            try
            {
                using (SATAContext context = new SATAContext())
                {
                    var data = context.Insured_Details.AsNoTracking().Where(x => x.emp_code.Trim() == MemberNo && x.control_no == SchemeNo);

                    var memberDate = (from member in data

                                      join scheme in context.gene_master on member.control_no equals scheme.Control_no

                                      select new MemberDTO
                                      {
                                          AutoId = Convert.ToInt64(member.auto_id),

                                          MemberNo = member.emp_code,

                                          MemberName = member.Name,

                                          Relation = member.relation,

                                          Gender = member.Sex,

                                          PhoneNumber = member.Mobile,

                                          JobGroup = member.JobGroup,

                                          Scheme = scheme.policy_type,

                                          BiometricStatus = member.FingerprintEnrollment,

                                          ActiveStatus = (bool)member.IsActive,

                                      }).ToListAsync();

                    return await memberDate;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }
        public async Task<MemberDTO> GenerateMVC(MemberDTO mvcMemberDTO)
        {
            try
            {
                HttpClient client = _api.Initial();

                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage getData = await client.GetAsync("api/SearchMember/GenerateMVC?MemberNo="+ mvcMemberDTO.MemberNo + "&MemberName="+ mvcMemberDTO.MemberName + "&Scheme="+ mvcMemberDTO.Scheme+ "&Department="+ mvcMemberDTO.Department+ "&SubDepartment="+ mvcMemberDTO.SubDepartment + "&HospitalCode=649&CapitationAmount=0");

                if (getData.IsSuccessStatusCode)
                {
                    string results = getData.Content.ReadAsStringAsync().Result;

                    var data = JsonConvert.DeserializeObject<List<MemberDTO>>(results);

                    var mvcDetails = data.FirstOrDefault();

                    mvcDetails.MemberName = mvcMemberDTO.MemberName;

                    mvcDetails.Department = mvcMemberDTO.Department;

                    mvcDetails.SubDepartment = mvcMemberDTO.SubDepartment;

                    return mvcDetails;
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }
    }
}
