// Задать номер четверти, показать диапазоны для возможных координат
//metka:
int quartNum = 0;
string range = "";

do
{
   Console.Write("Введите число в диапазоне от 1 до 4, обозначающее номер четверти : "); 
   quartNum = Convert.ToInt32(Console.ReadLine());
}
while ((quartNum < 1) | (quartNum >4));
//Console.WriteLine("Введено число: " + quartNum);

if (quartNum == 1)      range = "x > 0, y > 0";
else if (quartNum == 2) range = "x < 0, y > 0";
else if (quartNum == 3) range = "x < 0, y < 0";
else                    range = "x > 0, y < 0";

Console.WriteLine($"Для {quartNum}-й четверти диапазон для возможных координат ( {range} )");
Console.WriteLine();
//goto metka;
