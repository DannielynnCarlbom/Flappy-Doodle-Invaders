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
                Highscore();
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
    public void Highscore()
    {
        string[] Highscore;
        string filename = "Highscore.txt";
        int podium = 5;
        string empty = "";

        Console.Clear();
        Console.WriteLine("Highscore List");

        // Läs in från fil ifall den finns
        if (File.Exists(filename))
        {
            Highscore = File.ReadAllLines(filename);

        }
        else
        {
            // Skapa  och fyll den med information

            Highscore = new string[podium];
            for (int i = 0; i < Highscore.Length; i++)
            {
                Highscore[i] = empty;
            }
            File.WriteAllLines(filename, Highscore);
        }
        for (int i = 0; i < Highscore.Length; i++)
        {
            if (Highscore[i] == empty)
            {
                Console.WriteLine($"{i + 1}. ");
                continue;
            }
        }
    }

    // Sortering måsta lösas

    // Om det finns Highscores
    // Nödvändig information inte skriven än

    // string[] solo = Highscore[i].Split(';');
    // string place = solo[1];
    //Console.WriteLine($"{i + 1}. Name: {name}, Score: {timescore}"); 

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
