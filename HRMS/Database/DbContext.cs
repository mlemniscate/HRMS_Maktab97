using System.Text.Json;
using HRMS.Entities;

namespace HRMS.Database;

public class DbContext
{
    private string workingDirectory;
    private string projectDirectory;

    private readonly DB database;

    public DbContext()
    {
        workingDirectory = Environment.CurrentDirectory;
        projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
        FileStream userJsonFile = File.Open($"{projectDirectory}/../Database/db.json", FileMode.OpenOrCreate);
        database = JsonSerializer.Deserialize<DB>(userJsonFile);
        Users = database.Users;
        Carts = database.Carts;
        userJsonFile.Close();
    }

    public List<User> Users { get; set; }

    public List<Cart> Carts { get; set; }

    public void SaveChanges()
    {
        var userJsonString = JsonSerializer.Serialize(database);
        File.WriteAllText(@$"{projectDirectory}/../Database/db.json", userJsonString);
    }
}