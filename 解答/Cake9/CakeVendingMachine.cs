using System;

namespace Cake9
{
    // ケーキ自動販売機クラス
    internal class CakeVendingMachine
    {
        private int money;

        public void AddMoney(int money)
        {
            this.money += money;
        }

        public void ShowDeposit()
        {
            Console.WriteLine("現在の投入金額は、" + money + "円です。");
        }

        public string Buy(int number)
        {
            string cake = null;
            if (number == 1)
            {
                if (500 <= money)
                {
                    cake = "チョコレートケーキ";
                }
            }
            else if (number == 2)
            {
                if (400 <= money)
                {
                    cake = "チーズケーキ";
                }
            }
            else if (number == 3)
            {
                if (400 <= money)
                {
                    cake = "モンブラン";
                }
            }

            return cake;
        }
    }
}
