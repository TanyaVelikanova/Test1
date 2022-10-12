int countElem = new Random().Next(4, 6);
string[] array = new string[countElem];
CreateArray();
Console.WriteLine("Печать заданного массива");
PrintArray(array);
Console.WriteLine("Печать массива согласно условию задачи");
string[] newArray = new string[GetCountElement(array)];
PrintArray(CreateNewArray(array, newArray));

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
        Console.WriteLine(array[i]);
    }
}

    int GetCountElement(string[] array)
    {
        int newLength = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <=3)
            {
                newLength++;
            }
        }
        return newLength;
    }

string[] CreateNewArray(string[] array, string[] arrayNew)
{
    for (int i = 0, j=0; i < array.Length; i++)
    {
        {
            if (array[i].Length <=3)
            {
            arrayNew[j] = array[i];
            j++;
            }
        }
    }
    return newArray;
}