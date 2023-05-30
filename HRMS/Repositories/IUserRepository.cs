using HRMS.Entities;

namespace HRMS.Repositories;

public interface IUserRepository
{
    public void Create(User user);
    public List<User> GetAll();
    public User GetById(Guid id);
    public void Delete(User user);
}