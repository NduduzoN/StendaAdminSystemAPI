using Microsoft.EntityFrameworkCore;
using StendaAdminSystemAPI.Models;

namespace StendaAdminSystemAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Address> Address { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Medical> Medical { get; set; }
        public DbSet<License> License { get; set; }
        public DbSet<Induction> Induction { get; set; }
        public DbSet<BankingDetails> BankingDetails { get; set; }
        public DbSet<EmergencyContact> EmergencyContact { get; set; }
    }
}
