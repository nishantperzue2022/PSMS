using MvcApplication.DTO.MvcModule;

namespace MvcApplication.BLL.Repositories.MvcModule
{
    public interface IMvcRepository
    {
        Task<List<MvcDTO>> GetByMvcNo(decimal MvcNumber);
        Task<List<MvcDTO>> GetMvc(decimal HospitalCode);
    }
}