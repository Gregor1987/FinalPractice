Console.Write("Введите длинну массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
string[] array = new string[arrayLength];
for (int i = 0; i < arrayLength; i++)
{
    Console.Write($"Введите элемент {i + 1}: ");
    array[i] = Console.ReadLine();
}
int newArrayLength = 0;
for (int i = 0; i < arrayLength; i++)
{
    if (array[i].Length <= 3) newArrayLength++;
}
void ArrayPrint(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");

}
if (newArrayLength == 0) Console.WriteLine("В введенном массиве нет элементов, длина которых меньше либо равна 3");
else
{
    Console.WriteLine("Первоначальный массив:");
    ArrayPrint(array);
    string[] newArray = new string[newArrayLength];
    int j = 0;
    Console.WriteLine();
    Console.WriteLine("Элементы, длина которых меньше либо равна 3:");
    for (int i = 0; i < arrayLength; i++)
    {
        if (array[i].Length <= 3) 
        {
            newArray[j] = array[i];
            j++;
        }
    }
    ArrayPrint(newArray);
}