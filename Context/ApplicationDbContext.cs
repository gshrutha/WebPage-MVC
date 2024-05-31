using Microsoft.EntityFrameworkCore;
using WebPage.Models;

namespace WebPage.Context
{
    public class ApplicationDbContext :DbContext
    { 
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions)
        :base(contextOptions) 
        { 

        }

        public DbSet<Customers> TestCustomer1 { get; set; }

        public DbSet<CustomerKeys> GetCustomerKeysAll { get; set; }



    }
}
