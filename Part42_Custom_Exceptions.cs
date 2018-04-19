using System;
using System.Runtime.Serialization;

// Part 42 - Custom Exceptions

public class CustomExceptionsDemo
{
    public static void Main()
    {
        try
        {
            throw new UserAlreadyLoggedInException("User is alerady logged in.No duplicate sessions allowed.");
        }
        catch (UserAlreadyLoggedInException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

[Serializable]
public class UserAlreadyLoggedInException : Exception
{
    public UserAlreadyLoggedInException()
        : base()
    {
    }
    public UserAlreadyLoggedInException(string message)
        : base(message)
    {
    }
    public UserAlreadyLoggedInException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
    public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context)
        : base(info, context)
    {
    }
}
