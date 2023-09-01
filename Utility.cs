using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AoCCSharp {
    public class Utility {
        
        public static List<string> ReadFile(string year, string fileName) {
            List<string> lines = new();
            string line;
            StreamReader file = new(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Y_" + year, "Input", fileName));
            while ((line = file.ReadLine()) != null) {
                lines.Add(line);
            }
            file.Close();
            return lines;
        }

        public static List<String> ReadLinesUsingFile(string path) {
            return File.ReadAllLines(path).ToList();
        }
    }
}
