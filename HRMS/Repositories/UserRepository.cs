using System.Text.Json;
using HRMS.Database;
using HRMS.Entities;

namespace HRMS.Repositories;

public class UserRepository : BaseRepository<User>,IUserRepository
{
    private readonly DbContext dbContext;

    public UserRepository(DbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public void Create(User user)
    {
        dbContext.Users.Add(user);
    }

    public List<User> GetAll()
    {
        return dbContext.Users;
    }

    public User GetById(Guid id)
    {
        return dbContext.Users.SingleOrDefault(u => u.Id == id);
    }

    public void Delete(User user)
    {
        dbContext.Users.Remove(user);
    }
}