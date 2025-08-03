using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_MŻ
{
    public class Healer : IUnit
    {
        public string Identifier { get; set; }
        public int X { get; set; } // Współrzędna X na planszy
        public int Y { get; set; } // Współrzędna Y na planszy

        public Healer()
        {
            X = 0; // Domyślne położenie X
            Y = 0; // Domyślne położenie Y
        }

    }
}
