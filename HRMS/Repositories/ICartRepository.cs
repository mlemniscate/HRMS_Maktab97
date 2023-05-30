using HRMS.Entities;

namespace HRMS.Repositories;

public interface ICartRepository
{
    public void Create(Cart cart);
}