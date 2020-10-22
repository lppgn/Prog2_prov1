using System;

namespace Prog2pvor1
{
    public class Antique
    {
        //namnet av antiken ska spelaren säga
        public string name = "";
        //Vilken kategori eller vad för typ av antik det är (scroll t.ex)
        private string type = "";
        //vilket id antiken har för att se om customers vill ha denna antik
        private int ID = 0;
        //hur rare den är vilket definierar priset
        private int rarity = 0;
        //vilket skick den är i
        private int condition = 0;
        //om den har en förbannelse över sig
        private int curse = 0;
        //vad för pris den har
        private int value = 0;
        //min random generator
        public Random genrerator = new Random();

        public Antique(){
            name = Console.ReadLine();
            type = Console.ReadLine();
            ID = genrerator.Next(100);
            rarity = genrerator.Next(10);
            condition = genrerator.Next(10);
            curse = genrerator.Next(2);
            value = rarity*condition-(curse*10);
        }
    }
}
