using System;
using System.Collections.Generic;

namespace Prog2pvor1
{
    public class Customer
    {
        //namn på customern
        private string name = "";
        //lista på allt den redan har köpt
        public List<string> collection = new List<string>();
        //int tal som säger vilka ID de är interesserade av
        public int pereferance = 0;
    }
}
