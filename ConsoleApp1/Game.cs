// See https://aka.ms/new-console-template for more information


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] playingGrid = new int[9];
            // playingGrid[1] = 8;
            //playingGrid[2] = 16;
            //playingGrid[8] = 2048;
            //playingGrid[5] = 2048;
            bool start = StartGame();
            if (start)
            {
                RenderGame(playingGrid);
                if (CheckForWin(playingGrid))
                {
                    Console.WriteLine("You win!");
                };
            }

        }

        static bool StartGame()
        {
            Console.WriteLine("Welcome to the game. Type 1 to start");
            string response = Console.ReadLine();
            int parsedResponse = int.Parse(response);
            if (parsedResponse == 1)
            {
                return true;
            }

            return false;
        }

        static void RenderGame(int[] grid)
        {
            int gridCounter = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int v = 0; v < 3; v++)
                {
                    Console.Write("[" + grid[gridCounter] + "] ");
                    gridCounter++;
                }

                Console.WriteLine("");
            }
        }

        static bool CheckForWin(int[] grid)
        {
            int gridCounter = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int v = 0; v < 3; v++)
                {
                    if (grid[gridCounter] == 2048)
                    {
                        return true;
                    }

                    gridCounter++;
                }
            }
            return false;
        }

        static void RandomNumberToGrid(int[] grid)
        {
            
        }
    }
}

/*static int[] GetMove()
{
       
}*/
