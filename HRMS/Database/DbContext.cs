using HRMS.Entities;
using System.Text.Json;

namespace HRMS.Database;

public class DbContext
{
    private string workingDirectory;
    private string projectDirectory;

    public DbContext()
    {
        workingDirectory = Environment.CurrentDirectory;
        projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
        employees = new List<Employee>();
        FileStream employeeJsonFile = File.Open($"{projectDirectory}/../Database/employees.json", FileMode.OpenOrCreate);
        employees = JsonSerializer.Deserialize<List<Employee>>(employeeJsonFile);
        employeeJsonFile.Close();
    }

    public List<Employee> employees { get; set; }

    public void SaveChanges()
    {
        var employeesJsonString = JsonSerializer.Serialize(employees);
        File.WriteAllText(@$"{projectDirectory}/../Database/employees.json", employeesJsonString);
    }
}