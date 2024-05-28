internal class Highscore
{
    public void highscoreList()
    {
        string[] highscore;
        string filename = "highscore.txt"; // För att Highscore-Listan ska finnas kvar varje gång man öppnar och stänger programmet skapar jag en fil som kommer hålla den informationen
        int podium = 5;
        string empty = "";

        Console.Clear();
        Console.WriteLine("highscore List");

        // Läser in från fil ifall den finns
        if (File.Exists(filename))
        {
            highscore = File.ReadAllLines(filename);

        }
        else // Annars skapas filen och vi kan fylla den med information
        {

            highscore = new string[podium]; 
            for (int i = 0; i < highscore.Length; i++) // Varje rad kommer vara tom tills att det finns resultat att skriva in
            {
                highscore[i] = empty;
            }
            File.WriteAllLines(filename, highscore); // Ger informationen till den skapade filen
        }
        for (int i = 0; i < highscore.Length; i++)
        {
            if (highscore[i] == empty)
            {
                Console.WriteLine($"{i + 1}. ");
                continue;
            }
        }

        Console.WriteLine("\n");
        Menu.StartMenu();
    }

    // Sortering måsta lösas

    // Om det finns highscores
    // Nödvändig information inte skriven än

    // string[] solo = highscore[i].Split(';');
    // string place = solo[1];
    //Console.WriteLine($"{i + 1}. Name: {name}, Score: {timescore}"); 

}
