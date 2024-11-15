using CSFinal.Auth;
using CSFinal.Interfaces;
using CSFinal_WebAPI.Context;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CSFinal_WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("DBCRM");

            const string signingSecurityKey = "11111222223333344444555556666677777888889999900000";
            SigningSymmetricKey signingKey = new SigningSymmetricKey(signingSecurityKey);
            services.AddSingleton<IJwtSigningEncodingKey>(signingKey);
            services.AddDbContext<CrmDbContext>(options => options.UseSqlServer(connectionString));
            //services.AddDbContext<PhoneBookDbContext>(options => options.UseSqlServer(connectionString));
            //services.AddScoped<IPhoneBookEntries, PhoneBookEntriesTest>();
            //services.AddScoped<IPhoneBookEntries, PhoneBookEntries>();

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            //app.UseAuthentication();
            //app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
