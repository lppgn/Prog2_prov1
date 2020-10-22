using System;
using System.Collections.Generic;

namespace Prog2pvor1
{
    public class Shop
    {
        //lista för alla möjliga namn på antiker samt klasser på den andra listan
        public List<string> allNames = new List<string>();
        public List<string> allTypes = new List<string>();
        public Shop(){
            //sätter oin allt i listorna
            allTypes.Add("Tome"); allTypes.Add("Vase"); allTypes.Add("Scroll"); allTypes.Add("Book");
            allNames.Add(" of Alhaktar"); allNames.Add(" of Valhalla"); allNames.Add(" of moria"); allNames.Add(" of Micke");
        }
    }
}
