using Lorem_PayRoll_System.Data;
using Lorem_PayRoll_System.Repository.RepositoryAdminstrator;
using Lorem_PayRoll_System.Repository.RepositoryCasualEmployees;
using Lorem_PayRoll_System.Repository.RepositoryFullTimeEmployees;
using Lorem_PayRoll_System.Repository.RepositoryPartTimeEmployees;

namespace Lorem_PayRoll_System.Repository.RepositoryWrapper
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly EmployeeContext _context;
        private IAdminstratorRepository _adminstratorRepository;
        private IFullTimeEmployeesRepository _fullTimeEmployeesRepository;
        private IPartTimeEmployeesRepository _partTimeEmployeesRepository;
        private ICasualEmployeesRepository _casualEmployeesRepository;

        public RepositoryWrapper(EmployeeContext context) => _context = context;

        public IAdminstratorRepository AdministratorRepository
        {
            get
            {
                if (_adminstratorRepository == null)
                {
                    _adminstratorRepository = new AdministratorRepository(_context);
                }

                return _adminstratorRepository;
            }
        }



        public IFullTimeEmployeesRepository FullTimeEmployeesRepository
        {
            get
            {
                if (_fullTimeEmployeesRepository == null)
                {
                    _fullTimeEmployeesRepository = new FullTimeEmployeesRepository(_context);
                }

                return _fullTimeEmployeesRepository;
            }
        }

        public IPartTimeEmployeesRepository PartTimeEmployeesRepository
        {
            get
            {
                if (_partTimeEmployeesRepository == null)
                {
                    _partTimeEmployeesRepository = new PartTimeEmployeesRepository(_context);
                }

                return _partTimeEmployeesRepository;
            }
        }

        public ICasualEmployeesRepository CasualEmployeesRepository
        {
            get
            {
                if (_casualEmployeesRepository == null)
                {
                    _casualEmployeesRepository = new CasualEmployeesRepository(_context);
                }

                return _casualEmployeesRepository;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
