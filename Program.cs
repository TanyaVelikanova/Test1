int countElem = new Random().Next(3, 5);
string[] array = new string[countElem];
CreateArray();
PrintArray(array);


string[] CreateArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите строковое значение {i+1}");
        array[i] = Console.ReadLine();
    }
    return array;
}

 void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}\t");
    }
}

