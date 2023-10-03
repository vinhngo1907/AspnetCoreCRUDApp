using Microsoft.EntityFrameworkCore;

namespace AspnetCoreCRUDApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
        {

        }
    }
}