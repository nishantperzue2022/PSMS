using MvcApplication.DTO.SchemeModule;

namespace MvcApplication.BLL.Repositories.SchemeModule
{
    public interface ISchemeRepository
    {
        Task<List<SchemeDTO>> GetAll();
        Task<SchemeDTO> GetByAutoId(decimal AutoId);
    }
}