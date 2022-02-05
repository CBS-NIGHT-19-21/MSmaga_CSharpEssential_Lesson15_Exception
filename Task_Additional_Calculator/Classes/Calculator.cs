
class Calculator
{
    private double _operand1 = 0;
    private double _operand2 = 0;
    public void CheckData(object operand1, object operand2)
    {
        FormatException formatException = null;
        try
        {
            _operand1 = Convert.ToDouble(operand1);
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Operand 1: {e.Message}");
            formatException = e;
        }
        finally
        {
            CheckException(formatException!, "Operand 1");
        }

        try
        {
            _operand2 = Convert.ToDouble(operand2);
        }
        catch (FormatException e)
        {
            Console.WriteLine($"Operand 2: {e.Message}");
            formatException = e;
        }
        finally
        {
            CheckException(formatException!, "Operand 2");
        }
    }

    private static void CheckException(Exception exception, string nameOperator)
    {
        if (exception == null)
        {
            Console.WriteLine($"{nameOperator} has been read correctly!");
        }
        else
        {
            Console.WriteLine($"{nameOperator} has not been read!");
        }
    }

    public void Add(object operand1, object operand2)
    {
        CheckData(operand1, operand2);
        Console.WriteLine($"{_operand1} + {_operand2} = {_operand1 + _operand2:F2}");
    }

    public void Sub(object operand1, object operand2)
    {
        CheckData(operand1, operand2);
        Console.WriteLine($"{_operand1} - {_operand2} = {_operand1 - _operand2:F2}");
    }

    public void Mul(object operand1, object operand2)
    {
        CheckData(operand1, operand2);
        Console.WriteLine($"{_operand1} * {_operand2} = {_operand1 * _operand2:F2}");
    }

    public void Div(object operand1, object operand2)
    {
        CheckData(operand1, operand2);

        try
        {
            if (_operand2 == 0) throw new CalcException();
            Console.WriteLine($"{_operand1} / {_operand2} = {_operand1 / _operand2:F2}");
        }

        catch (CalcException exception)
        {
            Console.WriteLine($"Exception Message: {exception.DivByZero}");
        }
    }
}

