using HRMS.Services.Exception;
using System.Text.RegularExpressions;

namespace HRMS.Entities;

public class User
{
    public User() {}

    public User(string firstName, string lastName, DateTime birthDate, string phoneNumber)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        SetUserBirthDate(birthDate);
        SetUserPhoneNumber(phoneNumber);
    }

    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; private set; }
    public string PhoneNumber { get; private set; }

    public void SetUserBirthDate(DateTime birthDate)
    {
        if (birthDate > DateTime.Now)
            throw new NotValidAgeException();

        BirthDate = birthDate;
    }

    public void SetUserPhoneNumber(string phoneNumber)
    {
        Regex regex = new Regex(@"^09([1[0-9]|3[1-9]|2[1-9])-?[0-9]{3}-?[0-9]{4}$");
        if (!regex.IsMatch(phoneNumber))
            throw new WrongPhoneNumberFormatException();

        PhoneNumber = phoneNumber;
    }
}