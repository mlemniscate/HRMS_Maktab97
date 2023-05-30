
using HRMS.Database;using HRMS.Entities;
using HRMS.Repositories;
using HRMS.Services;

var dbContext = new DbContext();
IEmployeeService employeeService = new EmployeeService(new EmployeeRepository(dbContext), dbContext);

// var employee = new Employee("Reza", "Dehgan", DateTime.Now - TimeSpan.FromDays(365 * 24), "5154658741");

// employeeService.Create(employee);

employeeService.GetAll().ForEach(Console.WriteLine);
