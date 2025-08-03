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
    public partial class Form1 : Form
    {
        private List<IUnit> player1Units;
        private List<IUnit> player2Units;
        private Game game; // Referencja do obiektu gry
        public Form1(Game game, List<IUnit> player1Units, List<IUnit> player2Units)
        {
            InitializeComponent();
            this.game = game;
            this.player1Units = player1Units;
            this.player2Units = player2Units;
            InitializeBoard();
        }
        private void InitializeBoard()
        {
            tableLayoutPanel1.SuspendLayout(); // Wstrzymaj rysowanie panelu, aby zoptymalizować dodawanie kontrolek

            // Ustawienie jednostek pierwszego gracza na dole co drugie miejsce
            int unitIndex = 0;
            for (int col = 0; col < tableLayoutPanel1.ColumnCount; col += 2)
            {
                if (unitIndex < player1Units.Count)
                {
                    IUnit unit = player1Units[unitIndex];
                    Label label = GetUnitLabel(unit, 1); // Gracz pierwszy
                    tableLayoutPanel1.Controls.Add(label, col, tableLayoutPanel1.RowCount - 1); // Ustawienie na dole
                }
                unitIndex++;
            }

            // Ustawienie jednostek drugiego gracza na górze co drugie miejsce
            unitIndex = 0;
            for (int col = 0; col < tableLayoutPanel1.ColumnCount; col += 2)
            {
                if (unitIndex < player2Units.Count)
                {
                    IUnit unit = player2Units[unitIndex];
                    Label label = GetUnitLabel(unit, 2); // Gracz drugi
                    tableLayoutPanel1.Controls.Add(label, col, 0); // Ustawienie na górze
                }
                unitIndex++;
            }

            tableLayoutPanel1.ResumeLayout(); // Wznów rysowanie panelu
        }

        private Label GetUnitLabel(IUnit unit, int playerNumber)
        {
            Label label = new Label();
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Dock = DockStyle.Fill;
            label.BackColor = Color.DarkGray;
            label.BorderStyle = BorderStyle.FixedSingle;
            label.Margin = new Padding(0);
            label.Padding = new Padding(5);

            // Ustawienie tekstu na etykiecie
            string unitType = unit.GetType().Name; // Pobieranie nazwy typu jednostki
            char unitChar = unitType[0]; // Pobieranie pierwszej litery nazwy typu jednostki

            // Ustawienie prefixu w zależności od numeru gracza
            string playerPrefix = unitChar.ToString().ToUpper(); // Ustawienie z jednym z graczy

            label.Text = $"{playerPrefix}{playerNumber}";

            return label;
        }
       

        private void arrowDOWN_Click(object sender, EventArgs e)
        {

        }

        private void arrowLEFT_Click(object sender, EventArgs e)
        {

        }

        private void arrowRIGHT_Click(object sender, EventArgs e)
        {

        }

        private void arrowUP_Click(object sender, EventArgs e)
        {

        }
        private void btnAbility_Click(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnAttack_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFirespell_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
