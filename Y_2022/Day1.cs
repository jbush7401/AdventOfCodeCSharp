using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoCCSharp.Y_2022 {
    class Day1 : IDay {
        readonly List<string> l = Utility.ReadFile("2022", "Day1.txt");
        readonly List<int> totals = new();

        public void PartOne() {
            int tempTotal = 0;
            foreach (string s in l) {
                if (s == "") {
                    totals.Add(tempTotal);
                    tempTotal = 0;
                }
                else {
                    tempTotal += int.Parse(s);
                }
            }

            Console.WriteLine(totals.Max().ToString());
        }

        public void PartTwo() {
            Console.WriteLine(totals.OrderByDescending(x => x).Take(3).Sum().ToString());
        }
    }
}
