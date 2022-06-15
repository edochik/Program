Console.WriteLine("Ввод массива с клавиатуры? Нажми 1| Выбрать массив. Нажми 2");
Console.WriteLine();
int b = Convert.ToInt16(Console.ReadLine());

string[] arrayFirst = { "Hello", "2", "word", ":-)" };
string[] arraySecond = { "1234", "1567", "-2", "computer science" };
string[] arrayThird = { "Russia", "Denmark", "Kazan" };

int CountIndexArrayLessThree(string[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            j += 0;
        }
    }
    return j;
}

void ReplaceOldArrayNewArray(ref string[] array, int count)
{
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    array = newArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
}


if (b == 1)
{

    Console.WriteLine("Введите кол-во строк(цифры): ");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] UserArray = new string[n];
    void EmptyArray(string[] array)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write("Введите строку №{0}:\r\n    ", i + 1);
            UserArray[i] = Console.ReadLine();
        }
    }
    EmptyArray(UserArray);
    Console.WriteLine();
    Console.WriteLine("Вывод:");
    ReplaceOldArrayNewArray(ref UserArray, CountIndexArrayLessThree(UserArray));
    PrintArray(UserArray);

}

if (b == 2)
{
    Console.WriteLine("выберите массив 1, 2, 3:");
    Console.Write("1 = ");
    PrintArray(arrayFirst);
    Console.WriteLine();
    Console.Write("2 = ");
    PrintArray(arraySecond);
    Console.WriteLine();
    Console.Write("3 = ");
    PrintArray(arrayThird);
    Console.WriteLine();
    int c = Convert.ToInt32(Console.ReadLine());
    if (c == 1)
    {
        Console.WriteLine();
        Console.WriteLine("Вывод:");
        ReplaceOldArrayNewArray(ref arrayFirst, CountIndexArrayLessThree(arrayFirst));
        PrintArray(arrayFirst);
    }
    if (c == 2)
    {
        Console.WriteLine();
        Console.WriteLine("Вывод:");
        ReplaceOldArrayNewArray(ref arraySecond, CountIndexArrayLessThree(arraySecond));
        PrintArray(arraySecond);
    }
    if (c == 3)
    {
        Console.WriteLine();
        Console.WriteLine("Вывод:");
        ReplaceOldArrayNewArray(ref arrayThird, CountIndexArrayLessThree(arrayThird));
        PrintArray(arrayThird);
    }
    else
    {
        Console.Write("Не правильный ввод");
    }
}
if (b > 2 || b < 1)
{
    Console.Write(" Перезапусти программу, и введи 1 или 2");
}

