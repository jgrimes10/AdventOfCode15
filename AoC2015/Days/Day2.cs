using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2015.Days
{
    class Day2
    {
        // Open file
        private readonly StreamReader _reader = File.OpenText("C:\\Users\\jgrimes\\OneDrive - Relias Learning\\Documents\\AoC2015\\AoC2015\\Data\\Day2Data.txt");

        public void Run()
        {
            // Part A
            string line;
            int totalWrappingPaperNeeded = 0;
            int totalRibbonNeeded = 0;

            // Read in the contents of the text file
            while ((line = _reader.ReadLine()) != null)
            {
                // Split out each line
                var items = line.Split('\n');
                
                // Loop through each item
                foreach (var item in items)
                {
                    // Split the dimensions into ints
                    var ints = item.Split('x');

                    // Save each dimension to a variable
                    var l = int.Parse(ints[0]);
                    var w = int.Parse(ints[1]);
                    var h = int.Parse(ints[2]);

                    // Get the area of each side (times 2 for it's opposite side)
                    var side1 = 2 * l * w;
                    var side2 = 2 * w * h;
                    var side3 = 2 * h * l;

                    // PART 2
                    var volume = l * w * h;

                    // Find add the side dimensions to a list to find the min
                    var sides = new List<int> {side1 / 2, side2 / 2, side3 / 2};
                    // Get the min
                    var excess = sides.Min();
                    sides.Remove(excess);
                    var secondSmallest = sides.Min();

                    var ribbonAround = excess * 2 + secondSmallest * 2;

                    var ribbonNeeded = ribbonAround + volume;

                    // Find the total area
                    var totalArea = side1 + side2 + side3;

                    // Add the total area plus the area of the smallest side to the total needed
                    totalWrappingPaperNeeded += totalArea + excess;
                    totalRibbonNeeded += ribbonNeeded;

                }
            }

            Console.WriteLine("Total wrapping paper needed: {0}", totalWrappingPaperNeeded);
            Console.WriteLine("Total ribbon needed: {0}", totalRibbonNeeded);
        }
    }
}
