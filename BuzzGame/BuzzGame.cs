using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuzzGame
{
    class BuzzGame
    {
        bool clockwise = true;
        int currentNumber = 0;
        public int AantalSpelers { get; set; }
        List<Player> players;

        public BuzzGame(int aantalSpelers)
        {
            AantalSpelers = aantalSpelers;
            players = new List<Player>();
            for (int i = 0; i <= AantalSpelers; i++)
            {
                players.Add(new Player($"{i + 1}"));
            }
        }

        public override string ToString()
        {
            string tekst = "";
            foreach (Player nr in players)
            {
                tekst += $"Speler {nr.Name}: aantal keren BUZZ: \t{nr.Score}\n";
            }
            return tekst;
        }

        public void PlayBuzz()
        {
            int i = 0;
            while (currentNumber < 1000)
            {
                if (i > AantalSpelers && clockwise)
                {
                    i = 0;
                }
                if (i < 0 && clockwise)
                {
                    i = AantalSpelers;
                }
                if (i > AantalSpelers && !clockwise)
                {
                    i = AantalSpelers;
                }
                if (i < 0 && !clockwise)
                {
                    i = 0;
                }
                currentNumber++;
                if (currentNumber % 7 == 0 || currentNumber.ToString().Contains("7"))
                {
                    Console.WriteLine($"{players[i].Name}: BUZZ!");
                    players[i].upScore();
                    clockwise = !clockwise;
                    if (clockwise == true) { i++; }
                    if (clockwise == false) { i--; }
                }
                else
                {
                    Console.WriteLine($"{players[i].Name} {currentNumber} ");

                    if (clockwise == true) { i++; }
                    if (clockwise == false) { i--; }
                }
            }
            Console.WriteLine($"Player {players[0]}");
        }
    }
}
