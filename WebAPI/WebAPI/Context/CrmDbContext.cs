using CSFinal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CSFinal_WebAPI.Context
{
    public class CrmDbContext : IdentityDbContext<AuthCRMUser>
    {
        DbSet<Order> Orders { get; set; }

        public CrmDbContext(DbContextOptions options) : base(options) { }
    }
}
