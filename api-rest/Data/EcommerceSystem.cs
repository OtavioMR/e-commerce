using Microsoft.EntityFrameworkCore;

namespace api_rest.Data
{
    public class EcommerceSystem : DbContext
    {
        public EcommerceSystem(DbContextOptions<EcommerceSystem> options)
            : base(options)
        {
        }
    }
}
