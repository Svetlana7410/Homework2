// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void PrintArrayReversely(int[] array, int currentIndex)
{
    if (currentIndex < 0)
    {
        return;
    }
    Console.WriteLine(array[currentIndex]);
    PrintArrayReversely(array, currentIndex - 1);
}

int[] array = { 1, 2, 5, 0, 10, 34};
PrintArrayReversely(array, array.Length - 1);

