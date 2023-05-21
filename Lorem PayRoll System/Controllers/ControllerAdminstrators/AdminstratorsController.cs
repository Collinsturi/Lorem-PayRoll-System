using Lorem_PayRoll_System.Models;
using Lorem_PayRoll_System.Repository.RepositoryWrapper;
using Microsoft.AspNetCore.Mvc;

namespace Lorem_PayRoll_System.Controllers.ControllerAdminstrators
{
    [ApiController]
    [Route("api/[Controller]")]
    public class AdminstratorsController : ControllerBase
    {
   
        private readonly RepositoryWrapper _repositoryWrapper;

        public AdminstratorsController(RepositoryWrapper repositoryWrapper) => _repositoryWrapper = repositoryWrapper;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Adminstrator>>> Get()
        {
            return await _repositoryWrapper.AdministratorRepository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Adminstrator>>> Get(int id)
        {
            var admin = await _repositoryWrapper.AdministratorRepository.FindByCondition(emp => emp.Id == id);

            if (admin.Count == 0)
            {
                return NotFound();
            }

            return Ok(admin.First());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Adminstrator admin)
        {
            if (id != admin.Id)
            {
                return BadRequest();
            }

            await _repositoryWrapper.AdministratorRepository.Update(admin);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Adminstrator admin)
        {
            await _repositoryWrapper.AdministratorRepository.Add(admin);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var admin = await _repositoryWrapper.AdministratorRepository.FindByCondition(emp => emp.Id == id);

            if (admin.Count == 0) { return NotFound(); }

            await _repositoryWrapper.CasualEmployeesRepository.Delete(admin.First().Id);

            return NoContent();
        }

        }
    }
