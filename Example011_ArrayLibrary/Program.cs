// Использование метода для заполнения массива случайными часлами 0..9
// Использование метода вывода массива
//Использование метода для поиска индекса требуемого числа
//using Internal;

// using System.Reflection.Emit;
// using Internal;

void FillArray(int[] collection)// Использование метода для заполнения массива случайными часлами 0..9
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}
//void - ничего не возвращает
void PrintArray(int[] col)// Использование метода вывода массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find)//Использование метода для поиска индекса требуемого числа
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //-1 означает что не нужного элемента

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine(IndexOf(array, 1));