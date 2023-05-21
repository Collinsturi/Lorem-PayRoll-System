using Lorem_PayRoll_System.Repository.RepositoryAdminstrator;
using Lorem_PayRoll_System.Repository.RepositoryCasualEmployees;
using Lorem_PayRoll_System.Repository.RepositoryFullTimeEmployees;
using Lorem_PayRoll_System.Repository.RepositoryPartTimeEmployees;

namespace Lorem_PayRoll_System.Repository.RepositoryWrapper
{
    public interface IRepositoryWrapper
    {
        IAdminstratorRepository AdministratorRepository { get; }
        ICasualEmployeesRepository CasualEmployeesRepository { get; }
        IFullTimeEmployeesRepository FullTimeEmployeesRepository { get; }
        IPartTimeEmployeesRepository PartTimeEmployeesRepository { get; }
        void Save();
    }
}
