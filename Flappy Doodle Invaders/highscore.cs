﻿ class highscore
{
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

}