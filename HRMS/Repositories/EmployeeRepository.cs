using System.Text.Json;
using HRMS.Database;
using HRMS.Entities;

namespace HRMS.Repositories;

public class EmployeeRepository : BaseRepository<Employee>,IEmployeeRepository
{
    private readonly DbContext dbContext;


    public EmployeeRepository(DbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public void Create(Employee employee)
    {
        dbContext.employees.Add(employee);
    }

    public List<Employee> GetAll()
    {
        return dbContext.employees;
    }
}