using Lorem_PayRoll_System.Data;
using Lorem_PayRoll_System.Models;
using Lorem_PayRoll_System.Repository.Base;

namespace Lorem_PayRoll_System.Repository.RepositoryPartTimeEmployees
{
    public class PartTimeEmployeesRepository : RepositoryBase<Parttimeemployee, EmployeeContext>, IPartTimeEmployeesRepository
    {
        public PartTimeEmployeesRepository(EmployeeContext context) : base(context)
        {
        }
    }
}
