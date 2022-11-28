// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] NewStringArray(string[] array)
{
    int size = 0;
    string temp = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            size++;
            temp = temp + "," + array[i];
        }
    }
    string[] newArray = new string[size];
    newArray = temp.Split(',', StringSplitOptions.RemoveEmptyEntries);
    return newArray;
}
void PrintArray(string[] mass)
{
    Console.Write("[");
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write($"{mass[i]}");
        if (i != mass.Length - 1)
        {
            Console.Write(", ");

        }
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива: ");
int n = int.Parse(Console.ReadLine()!);
string[] array = new string[n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Введите {i + 1} строку: ");
    array[i] = Console.ReadLine()!;
}
Console.WriteLine("Исходный массив");
PrintArray(array);

Console.WriteLine("Новый массив, где длина строк меньше или равна 3 символам");
PrintArray(NewStringArray(array));

