// ● Первая группа методов — не принимает никаких аргументов и ничего не возвращают.
// ● Вторая группа методов — принимает какие-то аргументы, но ничего не возвращают.
// Эти две группы — так называемые void методы, которые ничего не возвращают.
// ● Третья группа методов — может что-то возвращать, но не принимает никаких
// аргументов. Например, может служить для генерации случайных данных.
// ● Четвёртая группа методов — что-то принимает (аргументы, данные). И что-то
// возвращает для дальнейшей работы.

// string Method4(int count, string text)
// {
// int i =0;
// string result ="";
// while (i<count)
// {
//     result = result + text;
//     i++;
    
// }
// return result;
// }

// string res  = Method4(10, "Hi");
// Console.WriteLine(res);

string Method4(int count, string text)
{

string result ="";
for (int i = 0; i<count; i++)
{
    result = result + text;
    i++;
    
}
return result;
}

string res  = Method4(10, "Hi");
Console.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
    
}
    
//=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// а большие “С” маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
+"● ежели бы вас послали вместо нашего милого Винценгероде,"
+"● вы бы взяли приступом согласие прусского короля."
+"● Вы так красноречивы. Вы дадите мне чаю?";
// string s = “qwerty”
// 012345
// s[3] //r

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText  = Replase(text,' ','|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replase(newText,'к','К');
Console.WriteLine(newText);
newText = Replase(newText,'с','С');
Console.WriteLine(newText);

// На самом деле мы сами указали достаточно много действий, но в то же время они могут быть
// выражены тремя пунктами.
// 1. Найти позицию минимального элемента в неотсортированной части массива.
// 2. Произвести обмен этого значения со значением первой неотсортированной позиции.
// 3. Повторять пока есть неотсортированные элементы.

int[] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;
        for (int j = i; j < array.Length; j++)
        {
            if (array[j]<array[minPosition]) minPosition = j; //Сортировка массива от мин к макс
                                                                // Сортировка от макс ">"

        }

        int temporary = array[i];
        array[i]= array[minPosition];
        array[minPosition]=temporary; 
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);