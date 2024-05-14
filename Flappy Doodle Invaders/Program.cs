using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        Menu menu = new();
        menu.StartMenu();

        //Added game.run so the whole game can start and not just the menu
        Game game = new Game();
        game.Run();

    }
}
