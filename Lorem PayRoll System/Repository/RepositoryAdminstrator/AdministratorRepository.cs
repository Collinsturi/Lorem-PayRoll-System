using Lorem_PayRoll_System.Data;
using Lorem_PayRoll_System.Models;
using Lorem_PayRoll_System.Repository.Base;

namespace Lorem_PayRoll_System.Repository.RepositoryAdminstrator
{
    public class AdministratorRepository : RepositoryBase<Adminstrator, EmployeeContext>, IAdminstratorRepository
    {
        public  AdministratorRepository(EmployeeContext context) : base(context) {  }
    }
}
