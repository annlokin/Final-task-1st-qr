string[] userArray = { "42abc", "cat", "r2d2", "j1" };

string[] countSymbols(string[] stringArray)
{
    int count = 0;
    int maxLength = 3;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= maxLength)
            count++;
    }
    string[] result = new string[count];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            result[j] = stringArray[i];
            j++;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    foreach (string stringArray in array)
    {
        System.Console.Write($"{stringArray} ");
    }
    System.Console.WriteLine();
}

void PrintResult(string[] userArray)
{
    System.Console.WriteLine("Задан массив:");
    PrintArray(userArray);
    string[] resultArray = countSymbols(userArray);
    System.Console.WriteLine("Элементы массива, которые меньше или равны 3-м символам:");
    PrintArray(resultArray);
}

PrintResult (userArray);



