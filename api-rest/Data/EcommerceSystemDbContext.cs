using Microsoft.EntityFrameworkCore;

namespace api_rest.Data
{
    public class EcommerceSystemDbContext : DbContext
    {
        public EcommerceSystemDbContext(DbContextOptions<EcommerceSystemDbContext> options)
            : base(options)
        {
        }
    }
}
