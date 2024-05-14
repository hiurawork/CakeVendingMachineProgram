using System;

namespace Cake3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cake1 = BuyCake(1);
            Console.WriteLine(cake1 + "を購入しました。");

            string cake2 = BuyCake(3);
            Console.WriteLine(cake2 + "を購入しました。");
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
