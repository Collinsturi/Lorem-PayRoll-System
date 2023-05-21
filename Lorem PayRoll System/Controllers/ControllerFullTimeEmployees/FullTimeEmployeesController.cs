using Lorem_PayRoll_System.DTO;
using Lorem_PayRoll_System.Models;
using Lorem_PayRoll_System.Repository.RepositoryWrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lorem_PayRoll_System.Controllers.FullTimeEmployeesController
{
    [ApiController]
    [Route("api/[Controller]")]
    public class FullTimeEmployeesController : ControllerBase
    {
        private readonly RepositoryWrapper _repositoryWrapper;

        public FullTimeEmployeesController(RepositoryWrapper repositoryWrapper) => _repositoryWrapper = repositoryWrapper;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fulltimeemployee>>> Get()
        {
                return await _repositoryWrapper.FullTimeEmployeesRepository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Fulltimeemployee>> Get(int id)
        {

            var employee = await _repositoryWrapper.FullTimeEmployeesRepository.FindByCondition(emp => emp.Id == id);

            if (employee.Count == 0)
            {
                return NotFound();
            }

            return Ok(employee.First());

        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Fulltimeemployee employee)
        {
            if(id != employee.Id)
            {
                return BadRequest();
            }
            await _repositoryWrapper.FullTimeEmployeesRepository.Update(employee);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Fulltimeemployee>> Post(Fulltimeemployee employee)
        {
            await _repositoryWrapper.FullTimeEmployeesRepository.Add(employee);

            return CreatedAtAction("Get", new {id = employee.Id}, employee);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Fulltimeemployee>> Delete(int id)
        {
            var employee = await _repositoryWrapper.FullTimeEmployeesRepository.FindByCondition(emp => emp.Id == id);

            if(employee.Count == 0)
            {
                return NotFound();
            }

            await _repositoryWrapper.FullTimeEmployeesRepository.Delete(employee.First().Id);

            return Ok(employee);
        }






    }
}
