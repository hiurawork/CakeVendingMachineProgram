using System;

namespace Cake9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CakeVendingMachine cakeVendingMachine = new CakeVendingMachine();
            bool loopFlag = true;
            while (loopFlag == true)
            {
                Console.WriteLine("お金を入れてください。");
                string inputMoney = Console.ReadLine();
                int money = int.Parse(inputMoney);
                cakeVendingMachine.AddMoney(money);
                cakeVendingMachine.ShowDeposit();

                Console.WriteLine("どの番号のケーキを購入しますか？");
                string selectedNumberStr = Console.ReadLine();
                int selectedNumber = int.Parse(selectedNumberStr);

                string cake = cakeVendingMachine.Buy(selectedNumber);
                if (cake == null)
                {
                    Console.WriteLine("投入金額が不足しています。");
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
