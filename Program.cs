// Написать программу, которая из имеющегося массива строк
// формирует новый массив строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

int maxLength = 3;
int arraySize = GetNum("Введите длинну массива строк: ");
if (arraySize > 0)
{
    string[] arrayString = GetStringArray(arraySize);
    Console.Clear();
    Console.WriteLine("Старый массив:");
    PrintArray(arrayString);
    string[] newArrayString = SelectElementsGivLength(arrayString, maxLength);
    Console.WriteLine("Новый массив:");
    PrintArray(newArrayString);
}
else Console.WriteLine("Длина массива должна быть больше 0.");

int GetNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

string GetString(string mes)
{
    Console.Write(mes);
    string str = Console.ReadLine()!;
    return str;
}

string[] GetStringArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetString($"Введите {i} элемент массива: ");
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("\"" + array[i] + "\",");
    }
    Console.WriteLine("\b]");
}

string[] SelectElementsGivLength(string[] arr, int maxLeng)
{
    int count = 0;
    string[] temp = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= maxLeng)
        {
            temp[count] = arr[i];
            count++;
        }
    }
    string[] newArray = new string[count];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = temp[i];
    }
    return newArray;
}