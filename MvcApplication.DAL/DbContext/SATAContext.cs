using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MvcApplication.DAL.Models;

namespace MvcApplication.DAL.DbContext
{
    public partial class SATAContext : IdentityDbContext
    {
        public SATAContext()
        {
        }
        public SATAContext(DbContextOptions<SATAContext> options) : base(options)
        {
        }
        public virtual DbSet<Insured_Detail> Insured_Details { get; set; } = null!;
        public virtual DbSet<Support_Desk> SupportDesk { get; set; } = null!;
        public virtual DbSet<Hospital> hospital_master { get; set; } = null!;
        public virtual DbSet<MvcGeneration> MvcGeneration { get; set; } = null!;
        public virtual DbSet<PREAUTHCIRNDETAILS> PREAUTHCIRNDETAILS { get; set; } = null!;
        public virtual DbSet<tbl_claimProcess> tbl_claimProcess { get; set; } = null!;
        public virtual DbSet<ClaimFormDetails> ClaimFormDetails { get; set; } = null!;
        public virtual DbSet<TATmaster> TATmaster { get; set; } = null!;
        public virtual DbSet<Scheme> gene_master { get; set; } = null!;
        public virtual DbSet<MvcReport> MvcReport { get; set; } = null;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

                optionsBuilder.UseSqlServer(config.GetConnectionString("sataDbConnection"));

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}
