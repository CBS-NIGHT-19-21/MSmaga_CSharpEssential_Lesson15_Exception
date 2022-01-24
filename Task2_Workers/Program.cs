class Program
{
    static void Main()
    {
        #region Задание 2 Workers

        // Требуется: Описать структуру с именем Worker, содержащую следующие поля:
        //• фамилия и инициалы работника; 
        //• название занимаемой должности; 
        //• год поступления на работу. 
        // Написать программу, выполняющую следующие действия: 
        //• ввод с клавиатуры данных в массив, состоящий из пяти элементов типа Worker(записи должны
        // быть упорядочены по алфавиту); 
        //• если значение года введено не в соответствующем формате выдает исключение. 
        //• вывод на экран фамилии работника, стаж работы которого превышает введенное значение. 

        #endregion

        // Create array of Worker objects.
        WorkerDB workerDB = new(5);

        // Show elements of array.
        workerDB.Show();

        // Sort elements of array by ABC.
        workerDB.SortABC();

        // Show workers who is experienced greater than 2005.
        workerDB.ShowExperienced(2005);

        // Show the best worker by indexer.
        workerDB.ShowBest(1);


        //Delay.
        Console.ReadLine();
    }
}
