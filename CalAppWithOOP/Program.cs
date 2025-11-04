// Object Oriented Programming

/* classes and objects: 
 
 * Sınıf (Class): Bir nesnenin şablonu, planı veya kalıbıdır.
 * Sınıflar, nesnelerin sahip olabileceği özellikleri
 * (Properties / Fields) ve yapabileceği eylemleri (Methods)
 * tanımlar.
 
 * nesne (Object): Sınıfın somut bir örneğidir.
 
 * state (özellik) => fields / properties 
 * davranış (behavior) => methods
    
*/

Calculator calculator = new Calculator();

double res = 0;

Console.WriteLine("Welcome to the CalApp");

Console.WriteLine("First number:");
double firstNum = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Second number:");
double secondNum = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Select one of them (+, -, *, /)");
string operate = Console.ReadLine();


if (operate == "+")
{
    res = calculator.Add(firstNum, secondNum);
}
else if (operate == "-")
{
    res = calculator.Subtract(firstNum, secondNum);
}
else if (operate == "*")
{
    res = calculator.Multiply(firstNum, secondNum);
}
else if (operate == "/")
{

    if (secondNum == 0)
    {
        Console.WriteLine("HATA! Bir sayı sıfıra bölünemez.");
        return; // Programı burada sonlandırın.
    }
    else
    {
        res = calculator.Divide(firstNum, secondNum);
    }

}
else
{
    Console.WriteLine("Invalid process");
}

Console.WriteLine($"Sonuc: {firstNum} {operate} {secondNum} = {res}");

