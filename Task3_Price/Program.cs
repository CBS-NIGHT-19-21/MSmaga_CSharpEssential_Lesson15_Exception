class Program
{
    static void Main()
    {
        #region Задание 3 Price

        // Используя Visual Studio, создайте проект по шаблону Console Application. 
        // Требуется: Описать структуру с именем Price, содержащую следующие поля:
        //• название товара; 
        //• название магазина, в котором продается товар; 
        //• стоимость товара в гривнах. 
        // Написать программу, выполняющую следующие действия: 
        //• ввод с клавиатуры данных в массив, состоящий из двух элементов типа Price(записи должны
        // быть упорядочены в алфавитном порядке по названиям магазинов); 
        //• вывод на экран информации о товарах, продающихся в магазине, название которого введено с
        // клавиатуры(если такого магазина нет, вывести исключение).

        #endregion

        // Create array of Price objects.
        PriceDB PriceDB = new(2);

        // Show elements of array.
        PriceDB.Show();

        // Sort elements of array by ABC.
        PriceDB.SortABC();

        // Show Prices who is experienced greater than 2005.
        PriceDB.ShowExpensive(1319);

        // Show the best Price by indexer.
        PriceDB.ShowBest(1);

        PriceDB.ShowGoods("Main");

        //Delay.
        Console.ReadLine();
    }
}