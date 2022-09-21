Console.Write("Введите длинну массива:");
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
if (newArrayLength == 0) Console.WriteLine("В введенном массиве нет элементов, длина которых меньше либо равна 3");
else
{
    string[] newArray = new string[newArrayLength];
    int j = 0;
    Console.WriteLine("Элементы, длина которых меньше либо равна 3:");
    for (int i = 0; i < arrayLength; i++)
    {
        if (array[i].Length <= 3) 
        {
            newArray[j] = array[i];
            Console.Write($"{newArray[j]} ");
            j++;
        }
    }
}