
class Program
{
    static void Main()
    {
        #region Задание Дополнительное
        // Создайте класс Calculator.
        // В теле класса создайте четыре метода для арифметических действий: (Add – сложение, Sub – вычитание,
        // Mul – умножение, Div – деление).
        // Метод деления должен делать проверку деления на ноль, если проверка не проходит, сгенерировать исключение.
        // Пользователь вводит значения, над которыми хочет произвести операцию и выбрать саму операцию.
        // При возникновении ошибок должны выбрасываться исключения.

        // https://www.intel.com/content/www/us/en/developer/articles/technical/intel-sdm.html

        // DivideByZeroException: представляет исключение, которое генерируется при делении на ноль
        // ArgumentOutOfRangeException: генерируется, если значение аргумента находится вне диапазона допустимых значений
        // ArgumentException: генерируется, если в метод для параметра передается некорректное значение
        // IndexOutOfRangeException: генерируется, если индекс элемента массива или коллекции находится вне диапазона допустимых значений
        // InvalidCastException: генерируется при попытке произвести недопустимые преобразования типов
        // NullReferenceException: генерируется при попытке обращения к объекту, который равен null(то есть по сути неопределен)

        #endregion


        Calculator calculator = new();

        calculator.Add(13, 19);
        Console.WriteLine(new string('=', 30));

        calculator.Sub(13, 19);
        Console.WriteLine(new string('=', 30));

        calculator.Mul(13, 19);
        Console.WriteLine(new string('=', 30));

        calculator.Div(13, 19);
        Console.WriteLine(new string('=', 30));

        calculator.Div("13", "19");
        Console.WriteLine(new string('=', 30));

        calculator.Div("13", "19qwety");
        Console.WriteLine(new string('=', 30));

        calculator.Div("13", 0);
        Console.WriteLine(new string('=', 30));


        //Delay.
        Console.ReadLine();
    }
}
