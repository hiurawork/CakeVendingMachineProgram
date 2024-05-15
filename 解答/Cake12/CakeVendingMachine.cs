using System.Collections.Generic;

namespace Cake12
{
    // ケーキ自動販売機クラス
    internal class CakeVendingMachine : VendingMachine
    {
        public CakeVendingMachine()
        {
            base.name = "ケーキ自動販売機";
        }

        protected override List<string> GetItems()
        {
            return new List<string>
            {
                "チョコレートケーキ",
                "チーズケーキ",
                "モンブラン"
            };
        }
    }
}
