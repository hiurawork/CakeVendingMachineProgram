using System.Collections.Generic;

namespace Cake12
{
    // おにぎり自動販売機クラス
    internal class RiceballVendingMachine : VendingMachine
    {
        public RiceballVendingMachine()
        {
            base.name = "おにぎり自動販売機";
        }

        protected override List<string> GetItems()
        {
            return new List<string>
            {
                "塩おにぎり",
                "こんぶおにぎり",
                "鮭おにぎり"
            };
        }
    }
}
