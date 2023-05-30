namespace HRMS.Services.Exception;

public class NotValidAgeException : ApplicationException
{
    public override string Message => "User Age must be lower then now.";
}

public class UserNotFoundException : ApplicationException
{
    private readonly Guid userId;

    public UserNotFoundException(Guid userId)
    {
        this.userId = userId;
    }

    public override string Message => $"User with id {userId} Not Found";
}