namespace HRMS.Services.Exception;

public class WrongPhoneNumberFormatException : ApplicationException
{
    public override string Message => "PhoneNumber must be something like this -> 09354658797";
}