using System;

public class ErrorHandling
{
    public static void HandleErrorByThrowingException() { throw new Exception(); }
    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(ErrorHandlingTest.DisposableResource disposableResource)
    {
        using (disposableResource)
        {
            throw new Exception();
        }
    }

    public static int? HandleErrorByReturningNullableType(string value)
    {
        int parsed;
        return (int.TryParse(value, out parsed)) ? (int?)parsed : null;
    }

    public static bool HandleErrorWithOutParam(string value, out int parsed)
    {
        return int.TryParse(value, out parsed);
    }
}