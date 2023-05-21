using Lorem_PayRoll_System.Data;
using Microsoft.EntityFrameworkCore;

namespace Lorem_PayRoll_System.ServiceExtension
{
    public static class ServiceExtensions
    {
        public static void ConfigureMysql(IServiceCollection service)
        {
            service.AddDbContext<EmployeeContext>(options =>
            {
                options.UseMySQL("ConnectionString");
            });
        }
    }
}
