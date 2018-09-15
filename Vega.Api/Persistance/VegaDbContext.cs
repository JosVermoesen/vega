using Microsoft.EntityFrameworkCore;
using Vega.Api.models;

namespace Vega.Api.Persistance
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
        {
        }
        public DbSet<Make> Makes { get; set; }
    }
}