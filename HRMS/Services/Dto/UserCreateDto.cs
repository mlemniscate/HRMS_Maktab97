namespace HRMS.Services.Dto;

public class UserCreateDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string PhoneNumber { get; set; }
    public List<string> Products { get; set; }
}