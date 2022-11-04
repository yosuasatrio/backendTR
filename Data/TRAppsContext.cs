using Microsoft.EntityFrameworkCore;
using backendTR.Models;

namespace backendTR.Data
{
    public class TRAppsContext : DbContext
    {
        public TRAppsContext(DbContextOptions<TRAppsContext> options) : base(options)
        {

        }
        public DbSet<tr_bpkb> tr_bpkbs { get; set; }
        public DbSet<ms_storage_location> ms_storage_locations { get; set; }
    }
}
