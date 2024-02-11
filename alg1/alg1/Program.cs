//int d = 0;
//Console.WriteLine("введите значение a");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("введите значение b");
//int b = Convert.ToInt32(Console.ReadLine());
//if (a + b > 10)
//{
//    d = a + b;
//    Console.WriteLine(d);
//}
//else
//{
//    d = a * b;
//    Console.WriteLine(d);
//}

Console.WriteLine("Привет, введи стоимость билета");
int bilet = Convert.ToInt32(Console.ReadLine());
while (bilet >= 5000)
{
    Console.WriteLine("Другой билет");
    bilet = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("стоимость билета ", bilet);
Console.WriteLine("Купить билет?");
string en = Console.ReadLine();
if (en == "да")
{
    Console.WriteLine("Покупка осуществленна");
    Console.WriteLine("Пока");
}
else
{
    Console.WriteLine("Покупка прервана, повторите операцию ещё раз.");
}