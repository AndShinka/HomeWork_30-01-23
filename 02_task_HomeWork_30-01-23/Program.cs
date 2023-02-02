// По двум заданным числам проверять является ли одно квадратом другого

//metka:
int[] num = new int[2];
//int[] num = {4, 2};
string Result = "не является";


for (int i = 0; i < 2; i++)
{
    //num[i] = new Random().Next(1, 1000);
    Console.WriteLine($"Введите {i+1} число");
    num[i] = Convert.ToInt32(Console.ReadLine());
}



if (num[0] / num[1] == num[1])
{
     Result = Result.Replace("не ", "");
}


Console.WriteLine($"Число {num[0]} {Result} квадратом числа {num[1]}");
Console.WriteLine();
Console.WriteLine();

//Console.ReadLine();
//goto metka;
