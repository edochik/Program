string[] newArray = { "Hello", "2", "word", ":-)" };

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