Console.WriteLine("Введите число: ");
int num = Int32.Parse(Console.ReadLine());

while(num > 2)
{
if(num % 2 == 0)
{
   Console.Write(num + ",");    
}
    num--;
}
if(num == 2)
{
   Console.WriteLine("2 ");
}
else 
{ 
   Console.Write("Нет чётных чисел ");
}