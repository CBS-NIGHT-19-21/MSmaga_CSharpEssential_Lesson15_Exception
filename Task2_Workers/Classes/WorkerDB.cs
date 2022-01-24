class WorkerDB
{   // Declare internal instance array of Worker objects.
    // Initiate by one Worker object.
    private readonly Worker[] _arrWorker = new Worker[1];

    // Declare internal array index.
    public Worker this[int index]
    {
        get
        {
            return _arrWorker[index];

        }
    }

    /// <summary>
    /// Creates an object as an array of workers, read data, 
    /// check property Year with Exception.
    /// </summary>
    /// <param name="numWorkers"></param>
    public WorkerDB(int numWorkers)
    {
        _arrWorker = new Worker[numWorkers];

        for (int i = 0; i < _arrWorker.Length; i++)
        {
            _arrWorker[i] = new Worker();

            Console.Write($"Worker{i + 1}.Name:");
            _arrWorker[i].Name = Console.ReadLine();
            Console.WriteLine();

            Console.Write($"Worker{i + 1}.Surename:");
            _arrWorker[i].Surname = Console.ReadLine();
            Console.WriteLine();

            Console.Write($"Worker{i + 1}.Position:");
            _arrWorker[i].Position = Console.ReadLine();
            Console.WriteLine();

            Console.Write($"Worker{i + 1}.Year:");

            // Check property Year with Exception.
            try
            {
                _arrWorker[i].Year = Convert.ToInt16(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine($"Year should be Int32: {e.Message}");
                _arrWorker[i].Year = 1900;
            }

            Console.WriteLine("");

            Console.Clear();
        }
    }

    /// <summary>
    /// Shows elements of the object array.
    /// </summary>
    public void Show()
    {
        Console.WriteLine($"WorkerDB consists {_arrWorker.Length} workers.");
        Console.WriteLine(new string('=', 100));
        for (int i = 0; i < _arrWorker.Length; i++)
        {
            Console.WriteLine($"Worker {i + 1} - Name: {_arrWorker[i].Name}\tSurename: {_arrWorker[i].Surname}" +
                $" \tPosition: {_arrWorker[i].Position} \tYear: {_arrWorker[i].Year}  ");
            Console.WriteLine(new string('=', 100));
        }
    }

    /// <summary>
    /// Sorts elements of array of the object 
    /// by alphabetical order of Name property.
    /// </summary>
    public void SortABC()
    {
        int numPass = _arrWorker.Length - 1;
        int adressLastBuble = _arrWorker.Length - 1;
        int replace = 1;
        int chSmaller;

        for (int k = 0; k < numPass; k++)
        {
            for (int i = 0; i < numPass; i++)
            {
                if (replace != 0) //If there was replaces
                {
                    replace = 0;
                    for (int j = 0; j < adressLastBuble; j++)
                    {
                        chSmaller = _arrWorker[j].CompareTo(_arrWorker[j + 1]);

                        if (chSmaller > 0)
                        {
                            Worker buffer = _arrWorker[j + 1];
                            _arrWorker[j + 1] = _arrWorker[j];
                            _arrWorker[j] = buffer;
                            replace++;
                        }
                    }
                }
            }
        }
        Show();

        Console.WriteLine($"WorkerDB has been sorted by alphabetical order successfully!");
    }

    /// <summary>
    /// Shows worker elements what has experienced than the year.
    /// </summary>
    /// <param name="year"></param>
    public void ShowExperienced(int year)
    {

        Console.WriteLine($"\nWorkerDB consists workers who has experience greater older than since {year}:");
        Console.WriteLine(new string('=', 100));
        for (int i = 0; i < _arrWorker.Length; i++)
        {
            if (_arrWorker[i].Year <= year)
            {
                Console.WriteLine($"Worker {i + 1} - Name: {_arrWorker[i].Name}");
            }
        }
    }

    /// Shows the best worker by indexer.
    public void ShowBest(int indexWorker)
    {
        if (indexWorker > 0 && indexWorker < _arrWorker.Length)
        {
            Console.WriteLine($"\n\nThe best worker of the year is: " +
                        $"{this[indexWorker].Name} {this[indexWorker].Surname}  {this[indexWorker].Year}!");
        }
        else
        {
            Console.WriteLine($"The index of the best worker is wrong!");
        }
    }
}


