using HRMS.Database;
using HRMS.Entities;
using HRMS.Repositories;
using HRMS.Services.Exception;
using HRMS.Services.Dto;

namespace HRMS.Services;

public class UserService : IUserService
{
    private readonly IUserRepository userRepository;
    private readonly ICartRepository cartRepository;
    private readonly DbContext dbContext;
    
    public UserService(IUserRepository userRepository,
        ICartRepository cartRepository,
        DbContext dbContext)
    {
        this.userRepository = userRepository;
        this.cartRepository = cartRepository;
        this.dbContext = dbContext;
    }

    public void Create(UserCreateDto userDto)
    {
        var user = new User(userDto.FirstName, userDto.LastName, userDto.BirthDate, userDto.PhoneNumber);
        userRepository.Create(user);

        var cart = new Cart(userDto.Products);
        cartRepository.Create(cart);

        dbContext.SaveChanges();
    }

    public void Update(UserUpdateDto updateUserDto)
    {
        var user = userRepository.GetById(updateUserDto.Id);
        if (user == null) 
            throw new UserNotFoundException(updateUserDto.Id);

        user.FirstName = updateUserDto.FirstName;
        user.LastName = updateUserDto.LastName;
        user.SetUserBirthDate(updateUserDto.BirthDate);
        user.SetUserPhoneNumber(updateUserDto.PhoneNumber);

        dbContext.SaveChanges();
    }

    public void Delete(UserDeleteDto deleteUserDto)
    {
        var user = userRepository.GetById(deleteUserDto.Id);
        if (user == null)
            throw new UserNotFoundException(deleteUserDto.Id);

        userRepository.Delete(user);
        dbContext.SaveChanges();
    }

    public List<UserDto> GetAll()
    {
        var users = userRepository.GetAll();
        return MapToDto(users);
    }

    private List<UserDto> MapToDto(List<User> users)
    {
        var userDtos = new List<UserDto>();
        users.ForEach(u =>
        {
            userDtos.Add(new UserDto
            {
                Id = u.Id,
                FirstName = u.FirstName,
                LastName = u.LastName,
                BirthDate = u.BirthDate,
            });
        });
        return userDtos;
    }

    

}