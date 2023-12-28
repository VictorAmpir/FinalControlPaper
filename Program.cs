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
