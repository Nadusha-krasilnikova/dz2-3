// записать номер четверти, показать диапазон для возможных координат
Console.WriteLine("введите номер четверти");
int a= int.Parse(Console.ReadLine()?? "0");
if (a==1)
{
    Console.WriteLine(" x>0 и y>0");
}
else if (a==2)
{
    Console.WriteLine(" x<0 и y>0");
}
else if (a==3)
{
    Console.WriteLine(" x<0 и y<0");
}
else if (a==4)
{
    Console.WriteLine(" x>0 и y<0");
}
else 
{
    Console.WriteLine("такой четверти не существует");
}
