class CalcException : Exception
{

    public string DivByZero = "Division by Zero!";

    //Принимает сообщение с описание ошибки, и код ошибки
    public CalcException() : base( ) { } //Вызываем конструктор базового класса
    
  
}

