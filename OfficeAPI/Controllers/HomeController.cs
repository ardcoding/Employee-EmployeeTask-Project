using BusinessServicess.Layer.Interface;
using Microsoft.AspNetCore.Mvc;
using OfficeDb.Entities;
using Microsoft.EntityFrameworkCore; 
public class HomeController : ControllerBase
{
    private readonly IEmployeeBusiness _employeeBusiness;
    private readonly IEmployeeTaskBusiness _employeeTaskBusiness;

    public HomeController(
        IEmployeeBusiness employeeBusiness,
        IEmployeeTaskBusiness employeeTaskBusiness)
    {
        _employeeBusiness = employeeBusiness;
        _employeeTaskBusiness = employeeTaskBusiness;
    }

    [HttpGet("Employees")]
    public async Task<List<Employee>> GetValue()
    {
        return await _employeeBusiness.GetEmployee();

    }

    [HttpGet("Tasks")]
    public async Task<List<EmployeeTask>> GetValue2()
    {
        return await _employeeTaskBusiness.GetTask();
    }

    [HttpPost("AddEmployee")]

    public async Task<Employee> AddEmployee(Employee employee)
    {
        return await _employeeBusiness.AddEmployee(employee);
    }

    [HttpPost("CreateProject")]

    public async Task<EmployeeTask> CreateProject(EmployeeTask task)
    {
        return await _employeeTaskBusiness.AddTask(task);
    }
}
