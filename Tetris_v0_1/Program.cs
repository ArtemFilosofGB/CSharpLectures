// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// int[,] pic = new int[,]
// {
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
//  {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
//  {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
//  {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrintPicArray(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         if (matrix[i,j]==1) Console.Write($"█");
//         else Console.Write(" ");
//     }
//     Console.WriteLine();
// }
// }


// while (true)
// {

//     if()
// }

/*
using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[30, 30];
        int objectX = 0;
        int objectY = 0;

        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.Q)
            {
                break;
            }
            else if (key.Key == ConsoleKey.UpArrow && objectY > 0)
            {
                objectY--;
            }
            else if (key.Key == ConsoleKey.DownArrow && objectY < 29)
            {
                objectY++;
            }
            else if (key.Key == ConsoleKey.LeftArrow && objectX > 0)
            {
                objectX--;
            }
            else if (key.Key == ConsoleKey.RightArrow && objectX < 29)
            {
                objectX++;
            }

            // Обновление матрицы с объектом
            matrix[objectX, objectY] = 1;

            // Вывод матрицы на консоль
            Console.Clear();
            for (int y = 0; y < 30; y++)
            {
                for (int x = 0; x < 30; x++)
                {
                    Console.Write(matrix[x, y] == 1 ? "X" : ".");
                }
                Console.WriteLine();
            }
        }
    }
}
*/

using System;

class TetrisGame
{
    private static int[,] matrix = new int[30, 30];
    private static int currentX = 0;
    private static int currentY = 0;

    static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            DrawMatrix();
            ConsoleKeyInfo keyInfo = GetInput();

            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    MoveLeft();
                    break;

                case ConsoleKey.RightArrow:
                    MoveRight();
                    break;

                case ConsoleKey.DownArrow:
                    MoveDown();
                    break;

                case ConsoleKey.UpArrow:
                    MoveUp();
                    break;

                case ConsoleKey.Q:
                    isRunning = false;
                    break;
            }
        }

        Console.WriteLine("Игра окончена!");
        Console.ReadLine();
    }

    private static void DrawMatrix()
    {
        Console.Clear();

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == currentY && j == currentX)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(" ");
                }
                if (i == 0 || j == 0 || i == matrix.GetLength(0)-1 || j ==matrix.GetLength(1)-1) Console.Write("▄");
            }

            Console.WriteLine();
        }
    }

    private static ConsoleKeyInfo GetInput()
    {
        Console.Write($"=[{currentX}:{currentY}]Управление на стрелках клавиатуры, q - выход: ");
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        Console.WriteLine();

        return keyInfo;
    }

    private static void MoveLeft()
    {
        if (currentX - 1 >= 0)
        {
            currentX--;
        }
    }

    private static void MoveRight()
    {
        if (currentX + 1 < matrix.GetLength(1))
        {
            currentX++;
        }
    }

    private static void MoveDown()
    {
        if (currentY + 1 < matrix.GetLength(0))
        {
            currentY++;
        }
    }

    private static void MoveUp()
    {
        if (currentY - 1 >= 0)
        {
            currentY--;
        }
    }
}