using AuthClasses.Models;
using CSWork21_WebAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Context
{
    public class CrmDbContext : IdentityDbContext<AuthCRMUser>
    {
        DbSet<Order> Orders { get; set; }

        public CrmDbContext(DbContextOptions options) : base(options) { }
    }
}
