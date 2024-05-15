using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BuyRiceball();
        }

        private static void BuyCake()
        {
            CakeVendingMachine cakeVendingMachine = new CakeVendingMachine();
            cakeVendingMachine.ShowName();

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

        private static void BuyRiceball()
        {
            RiceballVendingMachine riceballVendingMachine = new RiceballVendingMachine();
            riceballVendingMachine.ShowName();

            bool loopFlag = true;
            while (loopFlag == true)
            {
                Console.WriteLine("お金を入れてください。");
                string inputMoney = Console.ReadLine();
                int money = int.Parse(inputMoney);
                riceballVendingMachine.AddMoney(money);
                riceballVendingMachine.ShowDeposit();

                Console.WriteLine("どの番号のおにぎりを購入しますか？");
                string selectedNumberStr = Console.ReadLine();
                int selectedNumber = int.Parse(selectedNumberStr);

                string cake = riceballVendingMachine.Buy(selectedNumber);
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
