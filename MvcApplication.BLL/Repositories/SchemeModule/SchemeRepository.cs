using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MvcApplication.DAL.DbContext;
using MvcApplication.DTO.SchemeModule;

namespace MvcApplication.BLL.Repositories.SchemeModule
{
    public class SchemeRepository : ISchemeRepository
    {
        private IMapper mapper;
        public SchemeRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }
        public async Task<List<SchemeDTO>> GetAll()
        {
            try
            {
                using (SATAContext db = new SATAContext())
                {
                    var schemes = (from k in db.gene_master.AsNoTracking()

                                   select new SchemeDTO
                                   {
                                       auto_id = k.auto_id,

                                       policy_type = k.policy_type

                                   }).ToListAsync();

                    return await schemes;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }
        }

        public async Task<SchemeDTO> GetByAutoId(decimal AutoId)
        {
            try
            {
                using (SATAContext db = new SATAContext())
                {
                    var data = await db.gene_master.FirstOrDefaultAsync(x => x.auto_id == AutoId);

                    var schemes = mapper.Map<SchemeDTO>(data);

                    return schemes;
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
