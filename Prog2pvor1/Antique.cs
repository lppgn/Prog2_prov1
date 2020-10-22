using System;
using System.Collections.Generic;


namespace Prog2pvor1
{
    public class Antique
    {
        //vad spelaren tror att den är värd
        public int price = 0;
        Shop theShop = new Shop();
        //namnet av antiken ska spelaren säga
        private string name = "";
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
            //ger spelaren valet att säga vad den tror antiken är värd samt en while loop så de inte kan skriva text
            string input = Console.ReadLine();
            while(!int.TryParse(input, out value)){
                System.Console.WriteLine("Bad player, thats not a price");
                input = Console.ReadLine();
            }
            //ger antiken alla dess värden
            name = theShop.allNames[genrerator.Next(theShop.allNames.Count)];
            type = theShop.allTypes[genrerator.Next(theShop.allTypes.Count)];
            ID = genrerator.Next(100);
            rarity = genrerator.Next(10);
            condition = genrerator.Next(10);
            curse = genrerator.Next(2);
            value = rarity*condition-(curse*10);
            printInfo();
        }
        public void printInfo(){
            //printar viktig info
            System.Console.WriteLine("Name: " + type + name);
            System.Console.WriteLine("Type: " + type);
        }
    }
}
