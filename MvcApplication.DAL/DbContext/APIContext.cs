using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MvcApplication.DAL.Models;
namespace MvcApplication.DAL.DbContext
{
    public partial class APIContext : IdentityDbContext
    {
        public APIContext()
        {

        }
        public APIContext(DbContextOptions<SATAContext> options) : base(options)
        {

        }
        public virtual DbSet<MaklMember> MaklMembers { get; set; } = null!;
        public virtual DbSet<CaseManagement> CaseManagements { get; set; } = null!;
        public virtual DbSet<Insured_Detail> Insured_Details_New { get; set; } = null!;
        public virtual DbSet<Member> Members { get; set; } = null!;
        public virtual DbSet<Relationship> Relationships { get; set; } = null!;
        public virtual DbSet<Dependant> Dependants { get; set; } = null!;
        public virtual DbSet<MemberDocument> MemberDocuments { get; set; } = null!;
        public virtual DbSet<DocumentType> DocumentTypes { get; set; } = null!;
        public virtual DbSet<ProviderType> ProviderTypes { get; set; } = null!;
        public virtual DbSet<PSMSMember> PSMSMembers { get; set; } = null!;
        public virtual DbSet<PSMSDependant> PSMSDependants { get; set; } = null!;
        public virtual DbSet<Document> Documents { get; set; } = null!;
        public virtual DbSet<DeleteDependantRequest> DeleteDependantRequests { get; set; } = null!;
        public virtual DbSet<DeleteMemberRequest> DeleteMemberRequests { get; set; } = null!;
        public virtual DbSet<EditMemberRequest> EditMemberRequests { get; set; } = null!;
        public virtual DbSet<EditDependantRequest> EditDependantRequests { get; set; } = null!;
        public virtual DbSet<PoliceServiceDependant> PoliceServiceDependants { get; set; } = null!;
        public virtual DbSet<PoliceServicePrincipalMember> PoliceServicePrincipalMembers { get; set; } = null!;
        public virtual DbSet<PoliceServiceDocument> PoliceServiceDocuments { get; set; } = null!;
        public virtual DbSet<NPS_Dependant_Edit_Request> NPS_Dependant_Edit_Requests { get; set; } = null!;
        public virtual DbSet<NPS_Principal_Member_Edit_Request> NPS_Principal_Member_Edit_Requests { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

                optionsBuilder.UseSqlServer(config.GetConnectionString("apiConnection"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }


    }
}
