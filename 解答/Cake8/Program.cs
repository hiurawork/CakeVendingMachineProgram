using System;

namespace Cake8
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
                cakeVendingMachine.Money += int.Parse(inputMoney);

                Console.WriteLine("どの番号のケーキを購入しますか？");
                string selectedNumberStr = Console.ReadLine();
                int selectedNumber = int.Parse(selectedNumberStr);

                string cake = cakeVendingMachine.Buy(selectedNumber);
                if (cake == null)
                {
                    Console.WriteLine("投入金額が不足しています。(現在の投入金額は" + cakeVendingMachine.Money + "円です。)");
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
