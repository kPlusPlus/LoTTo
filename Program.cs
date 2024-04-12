using System;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        // Create a Random object
        Random random = new Random();
        // combinations
        int combinations = 100000;
        List<int> list = new List<int>();
        string filePath = "lotto.csv";
        StreamWriter writer = new StreamWriter(filePath);
        string writeLine = string.Empty;

        for (int comb = 0; comb < combinations; comb++)
        {            
            Console.WriteLine("Predicted lottery numbers:");
            for (int i = 0; i < 6; i++)
            {
                int randomNumber = random.Next(1, 50); // Generates a random integer between 1 and 49 (inclusive)
                list.Add(randomNumber);
            }

            list.Sort();
            writeLine = string.Empty;
            foreach (int number in list)
            {
                Console.Write(number + ";");
                writeLine += number + ";";
            }
            writer.Write(writeLine + "\r\n");
            Console.WriteLine();

            list = new List<int>();
        }

        writer.Close();

        Console.WriteLine();
    }
}
