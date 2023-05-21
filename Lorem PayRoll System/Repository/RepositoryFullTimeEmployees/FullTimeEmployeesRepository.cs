using Lorem_PayRoll_System.Data;
using Lorem_PayRoll_System.Models;
using Lorem_PayRoll_System.Repository.Base;

namespace Lorem_PayRoll_System.Repository.RepositoryFullTimeEmployees
{
    public class FullTimeEmployeesRepository : RepositoryBase<Fulltimeemployee, EmployeeContext>, IFullTimeEmployeesRepository
    {
        public FullTimeEmployeesRepository(EmployeeContext context) : base(context)
        {
        }
    }
}
