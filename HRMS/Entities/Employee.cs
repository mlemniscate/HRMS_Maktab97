namespace HRMS.Entities;

public class Employee
{
    public Employee(string firstName, string lastName, DateTime birthDate, string nationalCode)
    {
        Id = Guid.NewGuid();
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
        NationalCode = nationalCode;
    }

    public Guid Id { get; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string NationalCode { get; set; }
    public List<string> PhoneNumbers { get; set; }

    public override string ToString()
    {
        return $"Id = {Id}\n" +
               $"FirstName = {FirstName}\n" +
               $"LastName = {LastName}\n" +
               $"BirthDate = {BirthDate}\n" +
               $"NationalCode = {NationalCode}\n";
    }
}