using System;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userGold;
            int userCrystal;
            int crystalPrice = 75;

            Console.WriteLine("Сколько у Вас монет?");
            userGold = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"На данный момент кристалы стоят {crystalPrice} монет. Сколько желаете приобрести?");
            userCrystal = Int32.Parse(Console.ReadLine());
            userGold -= userCrystal * crystalPrice;
            Console.WriteLine($"Отлично! Теперь у Вас есть {userCrystal} кристалов и осталось {userGold} монет");
        }
    }
}
