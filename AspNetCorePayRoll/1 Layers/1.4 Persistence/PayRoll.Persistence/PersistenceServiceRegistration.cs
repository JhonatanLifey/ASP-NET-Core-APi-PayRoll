using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PayRoll.CrossCutting.Common.Interfaces;
using PayRoll.CrossCutting.Common.Repository;
using PayRoll.CrossCutting.Common.Settings;
using PayRoll.Domain.Common;
using PayRoll.Domain.Interfaces;
using PayRoll.Persistence.Data;
using PayRoll.Persistence.Repositories;

namespace PayRoll.Persistence
{
    public static class PersistenceServiceRegistration
    {

        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<DB_PayRollContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DBPayRoll")));

            //services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            services.Configure<SettingEmail>(c => configuration.GetSection("EmailSettings"));
            services.AddTransient<IEmailService, EmailService>();

            return services;
        }

    }
}
