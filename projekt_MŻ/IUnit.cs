using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_MŻ
{
    public interface IUnit
    {
        string Identifier { get; set; }
        int X { get; set; } // Współrzędna X na planszy
        int Y { get; set; } // Współrzędna Y na planszy

    }
}
