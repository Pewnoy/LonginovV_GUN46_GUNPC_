using GamePrototype.Game;
using GamePrototype.Utils;

namespace GamePrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose difficulty:");
            Console.WriteLine("1 - Easy");
            Console.WriteLine("2 - Hard");

            Difficulty difficulty;

            while (true)
            {
                Console.Write("Enter difficulty: ");

                if (int.TryParse(Console.ReadLine(), out int choice)
                    && choice >= 1 && choice <= 2)
                {
                    difficulty = (Difficulty)(choice - 1);
                    break;
                }

                Console.WriteLine("Invalid choice.");
            }

            IUnitFactory unitFactory;
            IDungeonBuilder dungeonBuilder;

            if (difficulty == Difficulty.Easy)
            {
                unitFactory = new EasyUnitFactory();
                dungeonBuilder = new EasyDungeonBuilder();
            }
            else
            {
                unitFactory = new HardUnitFactory();
                dungeonBuilder = new HardDungeonBuilder();
            }

            new GameLoop(unitFactory, dungeonBuilder).StartGame();
        }
    }
}