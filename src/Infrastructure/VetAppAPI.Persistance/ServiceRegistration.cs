using VetAppAPI.Domain.Entities.Identity;
using VetAppAPI.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace VetAppAPI.Persistance;
public static class ServiceRegistration
{
    public static void AddPersistanceRegistration(this IServiceCollection services, IConfiguration configuration)
    {
        var assembly = Assembly.GetExecutingAssembly();

        services.AddDbContext<VetAppDbContext>(options => 
                options.UseSqlServer(configuration["ConnectionStrings:SqlConnection"], options => options.EnableRetryOnFailure()));

        services.AddIdentity<AppUser, AppRole>(options =>
        {
            options.Password.RequiredLength = 6;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
            options.User.RequireUniqueEmail = true;
            //options.User.AllowedUserNameCharacters 
        }).AddEntityFrameworkStores<VetAppDbContext>();
    }
}