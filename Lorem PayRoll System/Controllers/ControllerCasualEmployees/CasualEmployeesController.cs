using Lorem_PayRoll_System.Models;
using Lorem_PayRoll_System.Repository.RepositoryWrapper;
using Microsoft.AspNetCore.Mvc;

namespace Lorem_PayRoll_System.Controllers.ControllerCasualEmployees
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CasualEmployeesController : ControllerBase
    {
        private readonly RepositoryWrapper _repositoryWrapper;
        
        public CasualEmployeesController(RepositoryWrapper repositoryWrapper) => _repositoryWrapper = repositoryWrapper;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Casualemployee>>> Get()
        {
            return await _repositoryWrapper.CasualEmployeesRepository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Casualemployee>>> Get(int id)
        {
            var employee = await _repositoryWrapper.CasualEmployeesRepository.FindByCondition(emp => emp.Id == id);

            if(employee.Count == 0)
            {
                return NotFound();
            }

            return Ok(employee.First());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Casualemployee casualemployee)
        {
            if(id != casualemployee.Id)
            {
                return BadRequest();
            }

            await _repositoryWrapper.CasualEmployeesRepository.Update(casualemployee);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Casualemployee casualemployee)
        {
            await _repositoryWrapper.CasualEmployeesRepository.Add(casualemployee);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var employee = await _repositoryWrapper.CasualEmployeesRepository.FindByCondition(emp => emp.Id == id);

            if(employee.Count == 0) { return NotFound(); }

            await _repositoryWrapper.CasualEmployeesRepository.Delete(employee.First().Id);

            return NoContent();
        }

    }
}
