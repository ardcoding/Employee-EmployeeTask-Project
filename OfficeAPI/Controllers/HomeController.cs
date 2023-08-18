using BusinessServicess.Layer.Interface;
using Microsoft.AspNetCore.Mvc;
using OfficeDb.Entities;
using Microsoft.EntityFrameworkCore; // Include metodu için gerekli using

public class HomeController : ControllerBase
{
    private readonly IBaseBusiness<Employee> _employeeBusiness;
    private readonly IBaseBusiness<EmployeeTask> _employeeTaskBusiness;

    public HomeController(
        IBaseBusiness<Employee> employeeBusiness,
        IBaseBusiness<EmployeeTask> employeeTaskBusiness)
    {
        _employeeBusiness = employeeBusiness;
        _employeeTaskBusiness = employeeTaskBusiness;
    }

    [HttpGet("Employees")]
    public async Task<List<Employee>> GetValue()
    {
        return await _employeeBusiness.Get(e=>e.EmployeeTasks);
    }

    [HttpGet("Tasks")]
    public async Task<List<EmployeeTask>> GetValue2()
    {
        return await _employeeTaskBusiness.Get(e => e.Employee);
    }

    [HttpPost("AddEmployee")]

    public async Task<Employee> AddEmployee(Employee employee)
    {
        return await _employeeBusiness.Add(employee);
    }

    [HttpPost("CreateProject")]

    public async Task<EmployeeTask> CreateProject(EmployeeTask task)
    {
        return await _employeeTaskBusiness.Add(task);
    }
}
