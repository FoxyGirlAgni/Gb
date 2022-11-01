System.Console.WriteLine("Введите два числа");

string num1 = Console.ReadLine();
string num2 = Console.ReadLine();

    if (Int32.Parse(num1) > Int32.Parse(num2)) 
    {
     Console.WriteLine("Большее число:"+num1+", меньше: "+num2);
    }
    else
    {
     Console.WriteLine("Большее число:"+num2+", меньше; "+num1);

    }