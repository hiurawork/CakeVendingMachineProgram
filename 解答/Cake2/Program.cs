using System;
using System.Collections.Generic;

namespace Cake2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cakes = new List<string>();
            cakes.Add("チョコレートケーキ");
            cakes.Add("チーズケーキ");
            cakes.Add("モンブラン");
            cakes.Add("ショートケーキ");
            cakes.Add("まるやまケーキ");

            foreach (var cake in cakes)
            {
                Console.WriteLine(cake);
            }
            int count = cakes.Count;
            Console.WriteLine("箱のケーキの数は、" + count + "個です。");
        }
    }
}
