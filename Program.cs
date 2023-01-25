using System;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userGolds;
            int userCrystals;
            int crystalPrice = 75;

            Console.WriteLine("Сколько у Вас монет?");
            userGolds = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"На данный момент кристалы стоят {crystalPrice} монет. Сколько желаете приобрести?");
            userCrystals = Int32.Parse(Console.ReadLine());
            userGolds -= userCrystals * crystalPrice;
            Console.WriteLine($"Отлично! Теперь у Вас есть {userCrystals} кристалов и осталось {userGolds} монет");
        }
    }
}
