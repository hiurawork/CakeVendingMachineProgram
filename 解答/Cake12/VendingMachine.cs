using System;
using System.Collections.Generic;

namespace Cake12
{
    internal abstract class VendingMachine
    {
        protected string name;

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
                    cake = items[0];
                }
            }
            else if (number == 2)
            {
                if (400 <= money)
                {
                    cake = items[1];
                }
            }
            else if (number == 3)
            {
                if (400 <= money)
                {
                    cake = items[2];
                }
            }

            return cake;
        }

        public void ShowName()
        {
            Console.WriteLine("これは" + this.name + "です。");
        }

        protected abstract List<string> GetItems();
    }
}
