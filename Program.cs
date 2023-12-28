void arrayPrint(string[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i == 0) System.Console.Write("[");
        System.Console.Write(array[i]);
        if(i == array.Length - 1) System.Console.Write("]");
        else System.Console.Write(", ");
    }
}
System.Console.WriteLine("Введите колличество слов в массиве: ");
int size = int.Parse(System.Console.ReadLine()!);
string[] array = new string[size];
for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"Введите {i + 1}-е слово: ");
    array[i] = Convert.ToString(Console.ReadLine()!);
}
int sizeTwo = 0;
for(int i = 0; i < array.Length;i++)
{
    if (array[i].Length <= 3)
    {
        sizeTwo++;
    }
}
string[] arrayTwo = new string[sizeTwo];
int index = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        arrayTwo[index] = array[i];
        index++;
    }
}
arrayPrint(array);
System.Console.WriteLine();
arrayPrint(arrayTwo);
