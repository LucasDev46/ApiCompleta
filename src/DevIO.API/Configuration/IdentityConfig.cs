

using DevIO.API.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DevIO.API.Configuration
{
    public static class IdentityConfig
    {
     
        public static WebApplicationBuilder ResolveIdentity(this WebApplicationBuilder builder, IConfiguration configuration)
        {
            builder.Services.AddDbContext<ApplicationDbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddDefaultIdentity<IdentityUser>()
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            return builder;
        }
    }
}
