using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OoIHaveThat2._1.Models;

namespace OoIHaveThat2._1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OoIHaveThat2._1.Models.Response> Response { get; set; } = default!;
        public DbSet<OoIHaveThat2._1.Models.ToolRequest> ToolRequest { get; set; } = default!;
        public DbSet<OoIHaveThat2._1.Models.User> User { get; set; } = default!;
    }
}