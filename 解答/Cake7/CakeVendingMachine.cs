namespace Cake7
{
    // ケーキ自動販売機クラス
    internal class CakeVendingMachine
    {
        public string Buy(int number, int money)
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
