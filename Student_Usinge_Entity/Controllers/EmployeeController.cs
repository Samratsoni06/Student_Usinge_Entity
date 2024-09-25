using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_Usinge_Entity.Models;
using Student_Usinge_Entity.Service;

namespace Student_Usinge_Entity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public IActionResult GetAllEmp()
        {
            var emp = _employeeService.GetAllEmployee();
            return Ok(emp);
        }

        [HttpGet("{id}")]
        public IActionResult GetEmpByID(int id)
        {
            var emp = _employeeService.GetEmployeeById(id);
            return Ok(emp);

        }

        //[HttpGet("{name}")]
        //public IActionResult GetEmpByName(string name)
        //{
        //    var employee = _employeeService.GetEmployeeByName(name);
        //    return Ok(employee);
        //}

        [HttpPost]
        public IActionResult SaveEmp(Employee emp)
        {
            var employee = _employeeService.SaveEditEmployee(emp);
            return Ok(employee);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateEmp([FromBody] Employee emp, int id)
        {
            var employee = _employeeService.SaveEditEmployee(emp);
            return Ok(employee);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmp(int id)
        {
            var employee = _employeeService.DeleteEmployee(id);
            return Ok(employee);
        }
    }
}
