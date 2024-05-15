﻿using System.Collections.Generic;

namespace Cake10
{
    // ケーキ自動販売機クラス
    internal class CakeVendingMachine : VendingMachine
    {
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
