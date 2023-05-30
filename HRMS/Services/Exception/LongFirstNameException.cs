namespace HRMS.Services.Exception;

public class LongFirstNameException : ApplicationException
{
    public override string Message => "FirstName cannot be more then 30 character.";
}