using Lorem_PayRoll_System.Data;
using Lorem_PayRoll_System.Models;
using Lorem_PayRoll_System.Repository.Base;

namespace Lorem_PayRoll_System.Repository.RepositoryCasualEmployees
{
    public class CasualEmployeesRepository : RepositoryBase<Casualemployee, EmployeeContext>, ICasualEmployeesRepository
    {
        public CasualEmployeesRepository(EmployeeContext context) : base(context)
        {
        }
    }
}
