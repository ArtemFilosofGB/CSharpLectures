// Функции
// using System.Runtime.Intrinsics.X86;
// using Internal;

int a1 = 2, a2 = 23, a3 = 12, b1 = 139987, b2 = -12, b3 = 67, c1 = 1, c2 = 2321, c3 = 111;
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));
Console.WriteLine(max);