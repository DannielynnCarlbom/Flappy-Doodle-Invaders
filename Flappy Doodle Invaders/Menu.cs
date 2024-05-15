using System.Security.Cryptography.X509Certificates;

internal class Menu
{
    private bool isRunning = true;
    public void StartMenu()
    {
        while (isRunning)
        {

            Console.WriteLine("Welcome to Flappy Doodla Invaders\n[1] Highscore\n[2] Start Game");
            int alt = int.Parse(Console.ReadLine());
            if (alt == 1)
            {
                Highscore Hs = new();
                Hs.HighscoreList();
            }
            else if (alt == 2)
            {
                StartGame();
            }
            else
            {
                Console.WriteLine("Error: Unvalid answer\nTry again: ");
                alt = int.Parse(Console.ReadLine());
            }
        }
    }
    
    public void StartGame()
    {
        Console.Clear();
        Console.WriteLine("Starting Game");

        //Creating walls
        Walls wall1 = new(5, 10, "/\\/\\");
        Walls wall2 = new(20, 8, "/\\/\\");

       

        //Rendering walls
        wall1.Render();

        wall2.Render();

        Player player = new Player("Player1");

        while (isRunning)
        {
            player.Update();

        }

        System.Threading.Thread.Sleep(100);
    }
}
