using System.Runtime.CompilerServices;

namespace Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double johnMoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersCost = double.Parse(Console.ReadLine());
            double robesCost = double.Parse(Console.ReadLine());
            double beltsCost = double.Parse(Console.ReadLine());
            double robes = students, belts = students;
            double lightsabers = students;
            lightsabers += Math.Ceiling(students * 0.10);
            double freeBelts = Math.Floor((double)students / 6);
            double allCost = (lightsabers * lightsabersCost) + (robes * robesCost) + (belts * beltsCost - (freeBelts * beltsCost));

            if (johnMoney >= allCost)
            {
                Console.WriteLine($"The money is enough - it would cost {allCost:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {Math.Abs(allCost - johnMoney):f2}lv more.");
            }
        }
    }
}