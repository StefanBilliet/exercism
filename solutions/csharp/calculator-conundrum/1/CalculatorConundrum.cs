public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        try
        {
            return operation switch
            {
                "+" => $"{operand1} + {operand2} = {SimpleOperation.Addition(operand1, operand2)}",
                "*" => $"{operand1} * {operand2} = {SimpleOperation.Multiplication(operand1, operand2)}",
                "/" => $"{operand1} / {operand2} = {SimpleOperation.Division(operand1, operand2)}",
                null => throw new ArgumentNullException(nameof(operation)),
                "" => throw new ArgumentException(nameof(operation)),
                _ => throw new ArgumentOutOfRangeException("Invalid operation", nameof(operation))
            };
        }
        catch (DivideByZeroException exception)
        {
            return exception.Message;
        }
    }
}
