using System;

using System.Text;

namespace sequence_split_xapien
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = "0,6,12,18,24,30,36,42,48,53,58,63,68," +
                "72,77,80,84,87,90,92,95,96,98,99,99,100,99,99,98,96," +
                "95,92,90,87,84,80,77,72,68,63,58,53,48,42,36,30,24,18," +
                "12,6,0,-6,-12,-18,-24,-30,-36,-42,-48,-53,-58,-63,-68," +
                "-72,-77,-80,-84,-87,-90,-92,-95,-96,-98,-99,-99,-100," +
                "-99,-99,-98,-96,-95,-92,-90,-87,-84,-80,-77,-72,-68," +
                "-63,-58,-53,-48,-42,-36,-30,-24,-18,-12,-6";
            
            // Split the sequence to an array
            string[] values = sequence.Split(',');
            
            // Initialize StringBuilder to build a new string
            StringBuilder result = new StringBuilder();
           
            // Iterate over the values array to take every fifth value
            // and append it to the result string, seperated by a comma
            for (int i = 4; i < values.Length; i += 5)
            {
                result.Append(values[i] + ",");
            }
            // Convert result StringBuilder to a string and trimm off the last comma
            string newString = result.ToString().TrimEnd(',');
            
            Console.WriteLine(newString);
        }
    }
}
