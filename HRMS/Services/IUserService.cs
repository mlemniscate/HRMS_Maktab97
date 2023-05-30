using HRMS.Entities;
using HRMS.Services.Dto;

namespace HRMS.Services;

public interface IUserService
{
    public void Create(UserCreateDto user);
    public void Update(UserUpdateDto updateUserDto);
    public void Delete(UserDeleteDto user);
    public List<UserDto> GetAll();
}