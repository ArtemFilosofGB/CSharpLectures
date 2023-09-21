// Нахождение индекса требуемого числа в массиве

//using Internal;

int[] array = { 1, 11, 21, 31, 314, 41, 43, 45, 21 }; ;

int n = array.Length;
int find = 21;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

