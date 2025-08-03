using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_MŻ
{
    public partial class Form2 : Form
    {
        private Game game; // Referencja do obiektu gry
        public Form2(Game game)
        {
            InitializeComponent();
            this.game = game;
            
        }

        private void btnCentaur_Click(object sender, EventArgs e)
        {
            game.AddUnitToCurrentArmy(new Centaur { Identifier = "Centaur" });
            UpdateArmyTextBoxes();
        }

        private void btnGriffin_Click(object sender, EventArgs e)
        {
            game.AddUnitToCurrentArmy(new Griffin { Identifier = "Griffin" });
            UpdateArmyTextBoxes();
        }

        private void btnArcher_Click(object sender, EventArgs e)
        {
            game.AddUnitToCurrentArmy(new Archer { Identifier = "Archer" });
            UpdateArmyTextBoxes();
        }

        private void btnDwarf_Click(object sender, EventArgs e)
        {
            game.AddUnitToCurrentArmy(new Dwarf { Identifier = "Dwarf" });
            UpdateArmyTextBoxes();
        }

        private void btnHealer_Click(object sender, EventArgs e)
        {
            game.AddUnitToCurrentArmy(new Healer { Identifier = "Healer" });
            UpdateArmyTextBoxes();
        }

        private void btnWarrior_Click(object sender, EventArgs e)
        {
            game.AddUnitToCurrentArmy(new Warrior { Identifier = "Warrior" });
            UpdateArmyTextBoxes();
        }

        private void btnMage_Click(object sender, EventArgs e)
        {
            game.AddUnitToCurrentArmy(new Mage { Identifier = "Mage" });
            UpdateArmyTextBoxes();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            List<IUnit> army1Units = game.Army1.Units;
            List<IUnit> army2Units = game.Army2.Units;

            if (game.Army1.Units.Count == 5 && game.Army2.Units.Count == 5)
            {
                Form1 form1 = new Form1(game, game.Army1.Units, game.Army2.Units);
                form1.Show();
                this.Hide();
            }
        }
        private void AddUnitToArmy(IUnit unit)
        {
            game.AddUnitToCurrentArmy(unit);
            UpdateArmyTextBoxes();

            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Obsługa zdarzenia TextChanged dla textBox1
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Obsługa zdarzenia TextChanged dla textBox2
        }
        private void UpdateArmyTextBoxes()
        {
            textBox1.Clear();
            textBox2.Clear();

            var player1Units = game.Army1.Units;
            var player2Units = game.Army2.Units;

            foreach (var unit in player1Units)
            {
                textBox1.AppendText(unit.Identifier + Environment.NewLine);
            }

            foreach (var unit in player2Units)
            {
                textBox2.AppendText(unit.Identifier + Environment.NewLine);
            }
        }

        private void lblArmy2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
