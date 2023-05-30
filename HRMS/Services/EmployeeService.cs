using HRMS.Database;
using HRMS.Entities;
using HRMS.Repositories;
using HRMS.Services.Exception;

namespace HRMS.Services;

public class EmployeeService : IEmployeeService
{
    private readonly IEmployeeRepository employeeRepository;
    private readonly DbContext dbContext;
    
    public EmployeeService(IEmployeeRepository employeeRepository, DbContext dbContext)
    {
        this.employeeRepository = employeeRepository;
        this.dbContext = dbContext;
    }

    public void Create(Employee employee)
    {
        CheckNullEmployee(employee);
        CheckEmployeeFirstName(employee);
        CheckEmployeeAge(employee);

        employeeRepository.Create(employee);
        dbContext.SaveChanges();
    }

    public List<Employee> GetAll()
    {
        return employeeRepository.GetAll();
    }

    private void CheckNullEmployee(Employee employee)
    {
        if (employee == null)
            throw new ArgumentNullException();
    }

    private void CheckEmployeeFirstName(Employee employee)
    {
        if (employee.FirstName.Length > 30)
            throw new LongFirstNameException();
    }

    private void CheckEmployeeAge(Employee employee)
    {
        var employeeAge = (DateTime.Now - employee.BirthDate).Days / 365;
        if ((employeeAge < 18 || employeeAge > 50))
            throw new NotValidAgeException();
    }

    
}