using System;
using System.Collections.Generic;

// Interfejs Unit
public interface IUnit
{
    string Identifier { get; set; }
    void UseAbility();
    void Attack();
    string AttackRange();
    int Movement();
    int Damage();
    int Cost();
}

// Konkretne jednostki
public class Centaur : IUnit
{
    public string Identifier { get; set; }
    public int HP { get; set; }

    public Centaur()
    {
        HP = 25; // Początkowe HP
    }

    public void UseAbility()
    {
        Console.WriteLine("Centaur uses ability!");
    }

    public void Attack()
    {
        Console.WriteLine("Centaur attacks!");
    }

    public string AttackRange()
    {
        return "Ranged";
    }

    public int Movement()
    {
        return 7;
    }

    public int Damage()
    {
        return 10;
    }

    public int Cost()
    {
        return 3;
    }
}

public class Griffin : IUnit
{
    public string Identifier { get; set; }
    public int HP { get; set; }

    public Griffin()
    {
        HP = 25; // Początkowe HP
    }

    public void UseAbility()
    {
        Console.WriteLine("Griffin uses ability!");
    }

    public void Attack()
    {
        Console.WriteLine("Griffin attacks!");
    }

    public string AttackRange()
    {
        return "Melee";
    }

    public int Movement()
    {
        return 8;
    }

    public int Damage()
    {
        return 12;
    }

    public int Cost()
    {
        return 4;
    }
}

public class Archer : IUnit
{
    public string Identifier { get; set; }
    public int HP { get; set; }

    public Archer()
    {
        HP = 25; // Początkowe HP
    }

    public void UseAbility()
    {
        Console.WriteLine("Archer uses ability!");
    }

    public void Attack()
    {
        Console.WriteLine("Archer attacks!");
    }

    public string AttackRange()
    {
        return "Ranged";
    }

    public int Movement()
    {
        return 5;
    }

    public int Damage()
    {
        return 7;
    }

    public int Cost()
    {
        return 2;
    }
}

public class Warrior : IUnit
{
    public string Identifier { get; set; }
    public int HP { get; set; }

    public Warrior()
    {
        HP = 25; // Początkowe HP
    }

    public void UseAbility()
    {
        Console.WriteLine("Warrior uses ability!");
    }

    public void Attack()
    {
        Console.WriteLine("Warrior attacks!");
    }

    public string AttackRange()
    {
        return "Melee";
    }

    public int Movement()
    {
        return 6;
    }

    public int Damage()
    {
        return 9;
    }

    public int Cost()
    {
        return 3;
    }
}

// Pole bitwy
public class Battlefield
{
    public IUnit[,] Fields { get; private set; }
    public List<Obstacle> Obstacles { get; set; }
    private string[,] UnitMarkers;

    public Battlefield()
    {
        Fields = new IUnit[10, 10];
        UnitMarkers = new string[10, 10];
        Obstacles = new List<Obstacle>();
    }

    public void PlaceUnit(IUnit unit, int x, int y, string marker)
    {
        if (x >= 0 && x < 10 && y >= 0 && y < 10 && Fields[x, y] == null)
        {
            Fields[x, y] = unit;
            UnitMarkers[x, y] = marker;
            Console.WriteLine($"Placed {unit.GetType().Name} at ({x}, {y})");
        }
        else
        {
            Console.WriteLine($"Cannot place unit at ({x}, {y})");
        }
    }

    public void MoveUnit(int startX, int startY, int endX, int endY)
    {
        IUnit unit = Fields[startX, startY];
        if (unit != null && Fields[endX, endY] == null)
        {
            int movementRange = unit.Movement();
            int distance = Math.Abs(endX - startX) + Math.Abs(endY - startY);
            if (distance <= movementRange)
            {
                Fields[endX, endY] = unit;
                Fields[startX, startY] = null;
                UnitMarkers[endX, endY] = UnitMarkers[startX, startY];
                UnitMarkers[startX, startY] = null;
                Console.WriteLine($"Moved {unit.GetType().Name} from ({startX}, {startY}) to ({endX}, {endY})");
            }
            else
            {
                Console.WriteLine("Move out of range!");
            }
        }
        else
        {
            Console.WriteLine("Invalid move!");
        }
    }

    public void DisplayBattlefield()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (UnitMarkers[i, j] != null)
                {
                    Console.Write($" {UnitMarkers[i, j],-3} ");
                }
                else if (Obstacles.Exists(o => o.X == i && o.Y == j))
                {
                    Console.Write(" O   ");
                }
                else
                {
                    Console.Write(" .   ");
                }
            }
            Console.WriteLine();
        }
    }
}

// Przeszkoda
public class Obstacle
{
    public string Name { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public void BlockPath()
    {
        Console.WriteLine($"{Name} blocks the path at ({X}, {Y})!");
    }
}

// Armia
public class Army
{
    public List<IUnit> Units { get; set; }

    public Army()
    {
        Units = new List<IUnit>();
    }

    public void AddUnit(IUnit unit)
    {
        Units.Add(unit);
    }

    public int TotalCost()
    {
        int total = 0;
        foreach (var unit in Units)
        {
            total += unit.Cost();
        }
        return total;
    }
}

// Gra
public class Game
{
    public List<Army> Armies { get; set; }
    public Battlefield Battlefield { get; set; }
    private Dictionary<string, int> Army1UnitHP;
    private Dictionary<string, int> Army2UnitHP;

    public Game()
    {
        Armies = new List<Army>();
        Battlefield = new Battlefield();
        Army1UnitHP = new Dictionary<string, int>();
        Army2UnitHP = new Dictionary<string, int>();
    }

    public void StartGame()
    {
        Console.WriteLine("Starting game...");

        // Wybór jednostek przez graczy
        Console.WriteLine("Player 1, choose your units:");
        ChooseUnits(Armies[0], 0);

        Console.WriteLine("Player 2, choose your units:");
        ChooseUnits(Armies[1], 9);

        Battlefield.DisplayBattlefield();
        DisplayUnitHP(); // Wyświetl początkowe HP jednostek

        bool gameOn = true;
        while (gameOn)
        {
            for (int i = 0; i < Armies.Count; i++)
            {
                Console.WriteLine($"Player {i + 1}'s turn:");
                Battlefield.DisplayBattlefield();
                Console.WriteLine("Enter the coordinates of the unit you want to move (x y): ");
                int startX = Convert.ToInt32(Console.ReadLine());
                int startY = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the coordinates of the destination (x y): ");
                int endX = Convert.ToInt32(Console.ReadLine());
                int endY = Convert.ToInt32(Console.ReadLine());

                Battlefield.MoveUnit(startX, startY, endX, endY);

                Battlefield.DisplayBattlefield();
                DisplayUnitHP(); // Wyświetl aktualne HP jednostek po ruchu
            }
        }
    }

    public void ChooseUnits(Army army, int side)
    {
        int points = 10;
        int unitCount = 1;
        int column = side == 0 ? 0 : 9; // Left (0) or right (9) column

        while (points > 0)
        {
            Console.WriteLine($"You have {points} points remaining.");
            Console.WriteLine("Choose unit (a: Archer, w: Warrior, c: Centaur, g: Griffin): ");
            char key = Console.ReadKey().KeyChar;
            Console.WriteLine();

            IUnit unit = null;
            string marker = "";

            switch (key)
            {
                case 'a':
                    unit = new Archer();
                    marker = $"a{side}{unitCount}";
                    break;
                case 'w':
                    unit = new Warrior();
                    marker = $"w{side}{unitCount}";
                    break;
                case 'c':
                    unit = new Centaur();
                    marker = $"c{side}{unitCount}";
                    break;
                case 'g':
                    unit = new Griffin();
                    marker = $"g{side}{unitCount}";
                    break;
                default:
                    Console.WriteLine("Invalid key, try again.");
                    continue;
            }

            if (unit != null && points >= unit.Cost())
            {
                bool positionChosen = false;
                while (!positionChosen)
                {
                    Console.WriteLine($"Enter the row position (0-9) to place the unit in column {column}: ");
                    char positionKey = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    int position;
                    if (int.TryParse(positionKey.ToString(), out position) && position >= 0 && position <= 9)
                    {
                        int x = column;
                        int y = position;

                        // Check if the chosen position is already occupied
                        if (Battlefield.Fields[x, y] == null)
                        {
                            string uniqueIdentifier = GetUniqueIdentifier(unit.GetType().Name[0], unitCount);
                            unit.Identifier = uniqueIdentifier;
                            Battlefield.PlaceUnit(unit, x, y, uniqueIdentifier);
                            army.AddUnit(unit);
                            points -= unit.Cost();
                            unitCount++;

                            // Initialize HP for the unit
                            if (army == Armies[0])
                                Army1UnitHP.Add(uniqueIdentifier, 25); // Start with 25 HP
                            else
                                Army2UnitHP.Add(uniqueIdentifier, 25); // Start with 25 HP

                            positionChosen = true;
                        }
                        else
                        {
                            Console.WriteLine("Position already occupied. Choose another position.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid position. Please enter a number from 0 to 9.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Not enough points or invalid unit.");

                // Sprawdzenie, czy gracz ma tylko jeden punkt i nie ma możliwości wyboru żadnej jednostki
                if (points == 1 && !CanChooseAnyUnit(points))
                {
                    Console.WriteLine("Player has 1 point left and cannot choose any unit. Ending unit selection.");
                    break;
                }
                else if (points <= 0)
                {
                    Console.WriteLine("Player has used all points. Ending unit selection.");
                    break;
                }
            }
        }
    }

    // Funkcja sprawdzająca, czy gracz może wybrać jakąkolwiek jednostkę w danej fazie wyboru
    private bool CanChooseAnyUnit(int points)
    {
        return points >= 2; // Możliwe do zmiany, zależnie od ustawień gry
    }

    private string GetUniqueIdentifier(char unitType, int unitCount)
    {
        return $"{unitType}{unitCount}";
    }

    private void DisplayUnitHP()
    {
        Console.WriteLine("Unit HP:");

        // Display Player 1's units HP
        Console.WriteLine("Player 1 army:");
        foreach (var kvp in Army1UnitHP)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value} HP");
        }

        // Display Player 2's units HP
        Console.WriteLine("Player 2 army:");
        foreach (var kvp in Army2UnitHP)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value} HP");
        }

        Console.WriteLine();
    }
}

// Przykładowa klasa główna do uruchomienia gry
public class Program
{
    public static void Main()
    {
        Game game = new Game();

        // Tworzenie armii
        Army army1 = new Army();
        Army army2 = new Army();

        game.Armies.Add(army1);
        game.Armies.Add(army2);

        // Tworzenie pola bitwy
        Battlefield battlefield = new Battlefield();
        game.Battlefield = battlefield;

        game.StartGame();
    }
}