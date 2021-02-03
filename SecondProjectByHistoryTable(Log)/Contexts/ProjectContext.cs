using Microsoft.EntityFrameworkCore;
using SecondProjectByHistoryTable_Log_.Models;
using SecondProjectEFCoreAttributes.Models;

namespace SecondProjectEFCoreAttributes.Contexts
{
    public class ProjectContext : DbContext
    {
        public ProjectContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Vendor> Vendor { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<History> History { get; set; }
    }
}
