// 2.2 Условные операторы Вариант 3 - Майборода Анатолий - Сложный 

Console.WriteLine("Введите 2х значное число: ");
ushort n = Convert.ToUInt16(Console.ReadLine());
int x = n % 10;
int y = n / 10;
if ((x == 3 || x == 7) && (y == 3 || y == 7))
{
    Console.WriteLine("Имеет цифры 3 и 7");
}

if ((x == 4 && y == 8) || (x == 8 && y == 4) || x == 9 || y == 9)
{
    Console.WriteLine("Имеет цифры 4 и 8 или 9");
}
