namespace HRMS.Services.Exception;

public class NotValidAgeException : ApplicationException
{
    public override string Message => "Employee Age must be between 18 and 50.";
}