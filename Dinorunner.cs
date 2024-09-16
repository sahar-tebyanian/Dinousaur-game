using System;
using System.Threading;

class DinosaurRun
{
    static void Main()
    {
        int dinosaurPosition = 0;
        int obstaclePosition = 30;
        bool isRunning = true;

        while (isRunning)
        {
            Console.Clear();
            DrawDinosaur(dinosaurPosition);
            DrawObstacle(obstaclePosition);

            if (dinosaurPosition == obstaclePosition)
            {
                Console.WriteLine("Game Over!");
                isRunning = false;
            }

            dinosaurPosition++;
            if (dinosaurPosition > Console.WindowWidth)
            {
                dinosaurPosition = 0;
            }

            obstaclePosition--;
            if (obstaclePosition < 0)
            {
                obstaclePosition = Console.WindowWidth;
            }

            Thread.Sleep(100);
        }
    }

    static void DrawDinosaur(int position)
    {
        Console.SetCursorPosition(position, Console.WindowHeight - 1);
        Console.Write("D");
    }

    static void DrawObstacle(int position)
    {
        Console.SetCursorPosition(position, Console.WindowHeight - 1);
        Console.Write("O");
    }
}
