using HRMS.Entities;

namespace HRMS.Repositories;

public interface IEmployeeRepository
{
    public void Create(Employee employee);
    public List<Employee> GetAll();
}