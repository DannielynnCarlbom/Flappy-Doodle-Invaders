using System.Security.Cryptography.X509Certificates;

public class Menu
{
    public static void StartMenu()
    {

        Console.WriteLine("Welcome to Flappy Doodle Invaders\n[1] Highscore\n[2] Start Game");
        int alt = int.Parse(Console.ReadLine());
        if (alt == 1)
        {
                Highscore Hs = new();
                Hs.highscoreList();
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
    
    public void StartGame()
    {
        Console.Clear();
        Console.WriteLine("Starting Game... ");
        Thread.Sleep(1000);
        Console.Clear();
        Player player = new('A');
        Game game = new Game();
        game.Run();

    }
}
