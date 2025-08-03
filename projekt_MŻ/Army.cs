using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_MŻ
{
    public class Army
    {
        public List<IUnit> Units { get; private set; }

        public Army()
        {
            Units = new List<IUnit>();
        }

        public void AddUnit(IUnit unit)
        {
            Units.Add(unit);
        }
    }
}
