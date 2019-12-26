using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using SwaggerWebAPI.Models;
namespace SwaggerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class HomeController: ControllerBase
    {
        private IEmployeeRepository _employeeRepository {get;}
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository=employeeRepository;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {
            return _employeeRepository.GetEmployeeList();
        }
         // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Employee> GetById(int id)
        {
           Employee EmpDetails =_employeeRepository.GetEmployee(id);
           return EmpDetails;
        }
    }
}