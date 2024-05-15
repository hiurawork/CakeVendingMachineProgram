using System;
using System.Collections.Generic;

namespace Cake10
{
    internal abstract class VendingMachine
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
            List<string> items = GetItems();
            if (number == 1)
            {
                if (500 <= money)
                {
                    cake = items[1];
                }
            }
            else if (number == 2)
            {
                if (400 <= money)
                {
                    cake = items[2];
                }
            }
            else if (number == 3)
            {
                if (400 <= money)
                {
                    cake = items[3];
                }
            }

            return cake;
        }

        protected abstract List<string> GetItems();
    }
}
