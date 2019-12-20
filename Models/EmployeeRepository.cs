using System;
using System.Collections.Generic;
using System.Linq;
namespace SwaggerWebAPI.Models
{
    public class EmployeeRepository:IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public EmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() { Id = 1, Name = "Mary", Department = "HR", Email = "mary@pragimtech.com" },
                new Employee() { Id = 2, Name = "John", Department = "IT", Email = "john@pragimtech.com" },
                new Employee() { Id = 3, Name = "Sam", Department = "IT", Email = "sam@pragimtech.com" },
            };
        }

        public List<Employee> GetEmployeeList()
        {
            return this._employeeList;
        }
        public Employee GetEmployee(int Id)
        {
            return this._employeeList.FirstOrDefault(e => e.Id == Id);
        }
    }
}