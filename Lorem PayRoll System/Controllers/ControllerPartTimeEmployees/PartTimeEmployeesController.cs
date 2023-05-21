using Lorem_PayRoll_System.Models;
using Lorem_PayRoll_System.Repository.RepositoryWrapper;
using Microsoft.AspNetCore.Mvc;

namespace Lorem_PayRoll_System.Controllers.ControllerPartTimeEmployees
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PartTimeEmployeesController : ControllerBase
    {
        private readonly RepositoryWrapper _repositoryWrapper;

        public PartTimeEmployeesController(RepositoryWrapper repositoryWrapper) => _repositoryWrapper = repositoryWrapper;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Parttimeemployee>>> Get()
        {
            return await _repositoryWrapper.PartTimeEmployeesRepository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Parttimeemployee>>> Get(int id)
        {
            var employee = await _repositoryWrapper.PartTimeEmployeesRepository.FindByCondition(emp => emp.Id == id);

            if(employee.Count == 0)
            {
                return NotFound();
            }

            return Ok(employee.First());
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, Parttimeemployee parttimeemployee)
        {
            if(id != parttimeemployee.Id)
            {
                return BadRequest();
            }

            await _repositoryWrapper.PartTimeEmployeesRepository.Update(parttimeemployee);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Parttimeemployee parttimeemployee)
        {
            await _repositoryWrapper.PartTimeEmployeesRepository.Add(parttimeemployee);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var employee = await _repositoryWrapper.PartTimeEmployeesRepository.FindByCondition(emp => emp.Id == id);

            if(employee.Count == 0) { return NotFound(); }

            await _repositoryWrapper.PartTimeEmployeesRepository.Delete(employee.First().Id);

            return NoContent();

        }

    }
}
