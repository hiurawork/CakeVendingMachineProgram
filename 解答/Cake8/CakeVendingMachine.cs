namespace Cake8
{
    // ケーキ自動販売機クラス
    internal class CakeVendingMachine
    {
        public int Money { get; set; }

        public string Buy(int number)
        {
            string cake = null;
            if (number == 1)
            {
                if (500 <= Money)
                {
                    cake = "チョコレートケーキ";
                }
            }
            else if (number == 2)
            {
                if (400 <= Money)
                {
                    cake = "チーズケーキ";
                }
            }
            else if (number == 3)
            {
                if (400 <= Money)
                {
                    cake = "モンブラン";
                }
            }

            return cake;
        }
    }
}
