namespace HRMS.Services.Dto;

public class UserDto
{
    public Guid Id { get; set;  }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    public override string ToString()
    {
        return $"Id = {Id}\n" +
               $"FirstName = {FirstName}\n" +
               $"LastName = {LastName}\n" +
               $"BirthDate = {BirthDate}\n" ;
    }
}