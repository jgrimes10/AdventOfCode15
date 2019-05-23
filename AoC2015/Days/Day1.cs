using System;
using System.IO;

namespace AoC2015.Days
{
    class Day1
    {
        // Open the file
        private readonly StreamReader _reader = File.OpenText("C:\\Users\\jgrimes\\OneDrive - Relias Learning\\Documents\\AoC2015\\AoC2015\\Data\\Day1AData.txt");

        public void Run()
        {
            // Part A
            string line;
            var floor = 0;
            var charPosition = 0;
            var enteredBasement = false;

            // Read in the contents of the text file
            while ((line = _reader.ReadLine()) != null)
            {
                // Convert to an array of chars
                var items = line.ToCharArray();
                // Loop through each character
                foreach (var item in items)
                {
                    switch (item)
                    {
                        // If it's an open parenthesis, go up a floor
                        case '(':
                            floor++;
                            break;
                        // If it's a close parenthesis, go down a floor
                        case ')':
                            floor--;
                            break;
                        // Something other than a parenthesis was read in...
                        default:
                            Console.WriteLine("Something went wrong...");
                            break;
                    }

                    // Part B
                    // Increment charPosition
                    charPosition++;
                    // Continue if already have entered basement or current floor is not in basement
                    if (enteredBasement != false || floor >= 0) continue;

                    Console.WriteLine("Entered basement at character {0}", charPosition);
                    enteredBasement = true;
                }

                Console.WriteLine("Ended up on floor: {0}", floor);
            }

            // Close the file
            _reader.Close();
        }
    }
}
