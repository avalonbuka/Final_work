// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


int size;
Console.Write("Введите количество элементов массива: ");
int.TryParse(Console.ReadLine()!, out size);

string[] array1 = new string[size];
for (int i = 0; i < size; i++)
{
    Console.Write("Введите элемент массива: ");
    string result = Console.ReadLine()!;
    array1[i] = result;
}

Console.WriteLine();
Console.Write("Введенный массив: [");
Console.Write(string.Join(" ", array1));
Console.Write("]");

int n = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
        n++;
}
Console.WriteLine();

Console.Write("Новый массив: [");
string[] array2 = new string[n];
int j = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
        array2[j] = array1[i];
        Console.Write(array2[j] + " ");
        j++;
    }
}
Console.Write("]");