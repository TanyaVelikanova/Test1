int countElem = new Random().Next(4, 6);
string[] array = new string[countElem];
CreateArray();
Console.WriteLine("Печать заданного массива");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Печать массива согласно условию задачи");
PrintChangeArray(array);

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

    void PrintChangeArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <=3)
        Console.Write($"{array[i]}\t");
    }
}