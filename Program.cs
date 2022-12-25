// Написать программу, которая из имеющегося массива строк сформирует массив из строк, 
//длина которых меньше либо равнa 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма.

string[] Zapolnenie(int len)
{
    string[] array = new string[len];
    for (int i = 0; i < len; i++)
    {
        Console.WriteLine("Введите строку c индексом: " + i);
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] NewArray(string[] arr)
{
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4) count++;
    }

    string[] newArray = new string[count];

    for (int i = 0, c = 0; i < arr.Length; i++)
    {
        if (arr[i].Length < 4)
        {
            newArray[c] = arr[i];
            c++;
        }
    }

    return newArray;

}

void Print(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write("  |" + arr[i] + "|  ");
    }
    Console.WriteLine("]");
}

int GetPositivInt()
{
    bool check = false;
    int num = -1;
    while (check == false || num < 0)
    {
        Console.WriteLine($"Задайте натуральное положительнео число:");
        check = int.TryParse(Console.ReadLine(), out num);
        if (check == false)
        {
            System.Console.WriteLine("Вы ввели не натуральное число!");
            continue;
        }
        if (num < 0)
        {
            System.Console.WriteLine("Вы ввели отрицательное число!");
            continue;
        }
    }
    return num;
}

int lenght = GetPositivInt();
string[] initArray = Zapolnenie(lenght);
System.Console.WriteLine("Массив:");
Print(initArray);
string[] cutArray = NewArray(initArray);
System.Console.WriteLine("Массив из строк, длина которых меньше либо равнa 3 символа:");
Print(cutArray);
