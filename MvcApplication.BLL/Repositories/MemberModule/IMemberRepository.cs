using MvcApplication.DTO.MvcModule;

namespace MvcApplication.BLL.Repositories.MemberModule
{
    public interface IMemberRepository
    {
        Task<MemberDTO> GenerateMVC(MemberDTO mvcMemberDTO);
        Task<List<MemberDTO>> GetByMemberNo(string MemberNo, decimal SchemeNo);
    }
}