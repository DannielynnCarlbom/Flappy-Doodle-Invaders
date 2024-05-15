internal class Highscore
{
    public void highscoreList()
    {
        string[] highscore;
        string filename = "highscore.txt";
        int podium = 5;
        string empty = "";

        Console.Clear();
        Console.WriteLine("highscore List");

        // Läs in från fil ifall den finns
        if (File.Exists(filename))
        {
            highscore = File.ReadAllLines(filename);

        }
        else
        {
            // Skapa  och fyll den med information

            highscore = new string[podium];
            for (int i = 0; i < highscore.Length; i++)
            {
                highscore[i] = empty;
            }
            File.WriteAllLines(filename, highscore);
        }
        for (int i = 0; i < highscore.Length; i++)
        {
            if (highscore[i] == empty)
            {
                Console.WriteLine($"{i + 1}. ");
                continue;
            }
        }
    }

    // Sortering måsta lösas

    // Om det finns highscores
    // Nödvändig information inte skriven än

    // string[] solo = highscore[i].Split(';');
    // string place = solo[1];
    //Console.WriteLine($"{i + 1}. Name: {name}, Score: {timescore}"); 

}
