using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_MŻ
{
    public class Game
    {
        public Army Army1 { get; private set; }
        public Army Army2 { get; private set; }
        private int currentPlayer;
        

        public Game()
        {
            Army1 = new Army();
            Army2 = new Army();
            currentPlayer = 0; // Player 1 starts
            
        }

        public bool CanAddUnitToCurrentArmy()
        {
            if (currentPlayer == 0)
            {
                return Army1.Units.Count < 5;
            }
            else
            {
                return Army2.Units.Count < 5;
            }
        }

        public void AddUnitToCurrentArmy(IUnit unit)
        {
            if (CanAddUnitToCurrentArmy())
            {
                if (currentPlayer == 0)
                {
                    Army1.AddUnit(unit);
                    if (Army1.Units.Count >= 5)
                    {
                        NextPlayer();
                    }
                }
                else
                {
                    Army2.AddUnit(unit);
                    if (Army2.Units.Count >= 5)
                    {
                        NextPlayer();
                    }
                }
            }
        }

        public void NextPlayer()
        {
            currentPlayer = (currentPlayer + 1) % 2; // Switch between 0 and 1
        }
    }


}
