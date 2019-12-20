using System;
using System.Collections.Generic;
namespace SwaggerWebAPI.Models
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEmployeeList();
        Employee GetEmployee(int Id);
    }
}