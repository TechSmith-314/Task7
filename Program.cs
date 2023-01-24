using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userGold;
            int userCrystal;
            int crystalPrice = 75;
            string userInput;

            Console.WriteLine("Сколько у Вас монет?");
            userInput = Console.ReadLine();
            userGold = Int32.Parse(userInput);

            Console.WriteLine($"На данный момент кристалы стоят {crystalPrice} монет. Сколько желаете приобрести?");
            userInput = Console.ReadLine();
            userCrystal = Int32.Parse(userInput);
            userGold = userGold - (userCrystal * crystalPrice);
            Console.WriteLine($"Отлично! Теперь у Вас есть {userCrystal} кристалов и осталось {userGold} монет");
        }
    }
}
