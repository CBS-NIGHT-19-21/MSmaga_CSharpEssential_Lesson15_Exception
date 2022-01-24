struct Worker : IComparable
{
    // Declare default values of fields of an instance. 
    private string _name = "None";
    private string _surname = "None";
    private string _position = "None";
    private int _year = 1900;
    
    // Declare properties of an object. 
    public string Name    { get { return _name; }     set { _name = value;     } }
    public string Surname { get { return _surname; }  set { _surname = value;  } }
    public string Position{ get { return _position; } set { _position = value; } }
    public int Year       { get { return _year; }     set { _year = value;     } }

    public Worker (string name, string surname, string position, int year)
    {
        _name = name;
        _surname = surname;
        _position = position;
        _year = year;
    }

    // Implement IComparable interface to realize method CompareTo()
    // to compare Worker objects by their properties values.
    /// <summary>
    /// Compares objects Worker by  Name property.
    /// </summary>
    /// <param name="otherObj"></param>
    /// <returns> 
    /// Less than zero - This instance precedes obj in the sort order.
    /// Zero - This instance occurs in the same position in the sort order as obj.
    /// Greater than zero - This instance follows obj in the sort order. 
    /// </returns>

    public int CompareTo(object? otherObj)
    {
        Worker other = (Worker)otherObj;
        if (otherObj == null)
        {
            return 0;
        }
        return (int)string.Compare(this.Name, other.Name);
    }
}

