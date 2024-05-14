using System;

namespace Cake7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CakeVendingMachine cakeVendingMachine = new CakeVendingMachine();
            bool loopFlag = true;
            int money = 0;
            while (loopFlag == true)
            {
                Console.WriteLine("お金を入れてください。");
                string inputMoney = Console.ReadLine();
                money += int.Parse(inputMoney);

                Console.WriteLine("どの番号のケーキを購入しますか？");
                string selectedNumberStr = Console.ReadLine();
                int selectedNumber = int.Parse(selectedNumberStr);

                string cake = cakeVendingMachine.Buy(selectedNumber, money);
                if (cake == null)
                {
                    Console.WriteLine("投入金額が不足しています。(現在の投入金額は" + money + "円です。)");
                }
                else
                {
                    Console.WriteLine(cake + "を購入しました。");
                    loopFlag = false;
                }
            }
        }
    }
}
