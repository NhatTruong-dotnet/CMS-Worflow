using CMSWorkflowService.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace CMSWorkflowService.API.Extension
{
    public static class Extensions
    {
        public static void AddApplicationServices(this IHostApplicationBuilder builder, IConfiguration configuration)
        { 
            var services = builder.Services;
            
        }

        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CMSWorkflowContext>(options => options
                    .UseSqlServer(configuration.GetConnectionString("CMSWorkflow")));
            var debugConnectionString = configuration.GetConnectionString("CMSWorkflow");
            Console.WriteLine("===========debugConnectionString=============" + debugConnectionString);
            return services;
        }
    }
}
