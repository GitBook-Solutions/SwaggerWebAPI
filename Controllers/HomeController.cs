using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SwaggerWebAPI.Models;
namespace SwaggerWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController: ControllerBase
    {
        private IEmployeeRepository _employeeRepository;
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
        public ActionResult<string> GetById(int id)
        {
           string name =_employeeRepository.GetEmployee(id).Name;
            return $"{name}";
        }
    }
}