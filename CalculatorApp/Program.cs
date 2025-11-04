/* temel veri tipleri
 
 * int yas = 30;
 * double fiyat = 45.99;
 * string ad = "Ahmet";
 * bool aktif = true;
 * char ilkHarf = 'A';
 */

/* konsol giriş/çıkış
 * yazdırma: Console.WriteLine("Mesaj");
 * girdi alma: string input = Console.ReadLine();
 */

/* veri tipi dönüşümleri
 * konsoldan gelen her şey stringtir.
 * string yasString = Console.ReadLine();
 * int yasNumber = Convert.ToInt32(yasNumber);
 */

double res = 0;

Console.WriteLine("Welcome to the CalApp");

Console.WriteLine("First number:");
double firstNum = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Second number:");
double secondNum = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Select one of them (+, -, *, /)");
string operate = Console.ReadLine();

//Console.WriteLine("Girdiğiniz İşlem: " + firstNum + " " + operate + " " + secondNum);

if(operate == "+")
{
    res = firstNum + secondNum;
}
else if(operate == "-")
{
    res = firstNum - secondNum;
}
else if(operate == "*")
{
    res = firstNum * secondNum;
}
else if (operate == "/")
{
    if(secondNum != 0)
    {
        res = firstNum / secondNum;
    }
    else
    {
        Console.WriteLine("Error! A number can not divide to 0!");
        return;
    }  
}
else
{
    Console.WriteLine("Invalid process");
}

Console.WriteLine($"Sonuc: {firstNum} {operate} {secondNum} = {res}");

