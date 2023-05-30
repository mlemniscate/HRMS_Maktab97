
using HRMS.Database;using HRMS.Entities;
using HRMS.Repositories;
using HRMS.Services;
using HRMS.Services.Dto;

var dbContext = new DbContext();
var userRepository = new UserRepository(dbContext);
var cartRepository = new CartRepository(dbContext);
IUserService userService = new UserService(userRepository, cartRepository, dbContext);

var userCreateDto = new UserCreateDto
{
    FirstName = "Milad",
    LastName = "Abdi",
    BirthDate = DateTime.Now - TimeSpan.FromDays(365 * 28),
    PhoneNumber = "09352899119",
    Products = new List<string> {}
};

userService.Create(userCreateDto);



// var user = new User("Hossein", "Besharati", DateTime.Now - TimeSpan.FromDays(365 * 26),
//     "09326548798");

// var userUpdateDto = new UserUpdateDto
// {
//     Id = new Guid("9b55a10e-8b6c-4a60-bc0f-36ad9c368da4"),
//     FirstName = "Milad",
//     LastName = "Abdi",
//     BirthDate = DateTime.Now - TimeSpan.FromDays(365 * 28),
//     PhoneNumber = "09352899119",
// };
//
// userService.Update(userUpdateDto);

// var userDeleteDto = new UserDeleteDto {Id = new Guid("9b55a10e-8b6c-4a60-bc0f-36ad9c368da4") };
// userService.Delete(userDeleteDto);


// var employee = new Employee("Reza", "Dehgan", DateTime.Now - TimeSpan.FromDays(365 * 24), "5154658741");

// employeeService.Create(employee);

userService.GetAll().ForEach(Console.WriteLine);
