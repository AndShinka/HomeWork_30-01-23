// Найти расстояние между точками в пространстве 2D/3D
// metka:
// Console.Clear(); Console.WriteLine();

int numAxis = 0;              // количество осей координат
int min = -100;               // минимальное значение диапазона для выбора случайных чисел
int max = 100;                // максимальное значение диапазона ...

int NumberAxes()
{
    int numberAxes = 0;
    do
    {
    Console.Write("Введите число осей координат 2 (2D) или 3 (3D): "); 
    numberAxes = Convert.ToInt32(Console.ReadLine());
    }
    while ((numberAxes < 2) | (numberAxes >3));
    return numberAxes;
}

int[] PointCoords(int numAxis)                  
{
    int[] coords = new int[numAxis];
    for (int i = 0; i < numAxis; i++)
    {
        coords[i] = new Random().Next(min, max);
    }
        return coords;
}

void PrintCoords(int[] array)
{
    Console.Write($"({array[0]}, ");
    for (int i = 1; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length - 1]})");
}

double Distance(int[] arr1, int[] arr2)
{
    int sum = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        sum = sum + (arr1[i] - arr2[i]) * (arr1[i] - arr2[i]);
    }
    double result = Math.Sqrt(sum);
    return result;
}


numAxis = NumberAxes();
int[] PointA = PointCoords(numAxis);
int[] PointB = PointCoords(numAxis);

//PointA[0] = 1; PointA[1] = 1; PointA[2] = 9;
//PointB[0] = 2; PointB[1] = 2; PointB[2] = 10;

Console.Write($"Координаты точки А: ");
PrintCoords(PointA);
Console.Write($"Координаты точки B: ");
PrintCoords(PointB);

Console.WriteLine($"Расстояние между точками А и В: {Distance(PointA, PointB)}");
Console.WriteLine();

// Console.ReadLine();
// goto metka;