// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.Clear();
Console.WriteLine();

int numDay = 0;
string[] WeekDay = {"нулевой", "понедельник", "вторник", "среда", "четверг", "пятница",
                     "Суббота", "Воскресенье"};
//metka:
do
{
   Console.WriteLine("Введите число в диапазоне от 1 до 7, обозначающее номер дня недели : "); 
   numDay = Convert.ToInt32(Console.ReadLine());
}
while ((numDay < 1) | (numDay >7));
//Console.WriteLine("Введено число: " + numDay);

if (numDay >5) 
{
    Console.WriteLine("Ура!!! День недели под номером " + numDay + " - это " 
                        + WeekDay[numDay] +", Выходной день !");
}
else
{
    Console.WriteLine("День недели под номером " + numDay + " - это " 
                        + WeekDay[numDay] +", рабочий день.");
}
Console.WriteLine();
Console.WriteLine();

//goto metka;