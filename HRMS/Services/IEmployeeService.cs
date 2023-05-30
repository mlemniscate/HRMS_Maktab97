using HRMS.Entities;

namespace HRMS.Services;

public interface IEmployeeService
{
    public void Create(Employee employee);
    public List<Employee> GetAll();
}