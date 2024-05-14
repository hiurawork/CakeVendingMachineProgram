using System;

namespace Cake4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("どの番号のケーキを購入しますか？");
            string selectedNumberStr = Console.ReadLine();
            int selectedNumber = int.Parse(selectedNumberStr);

            string cake = BuyCake(selectedNumber);
            Console.WriteLine(cake + "を購入しました。");
        }

        private static string BuyCake(int number)
        {
            string cake = null;
            if (number == 1)
            {
                cake = "チョコレートケーキ";
            }
            else if (number == 2)
            {
                cake = "チーズケーキ";
            }
            else if (number == 3)
            {
                cake = "モンブラン";
            }

            return cake;
        }
    }
}
