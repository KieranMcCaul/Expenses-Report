using System;
namespace expenses_report
{
    public class Trips
    {
        //----Dynamic List for entering trips----//
        public List<string> sName = new List<string>();
        public List<double> dAmount = new List<double>();
        //----Dynamic List for entering trips----//

        public Trips()
        {
        }
        

        //----Loop for entering Trip and Expenses----//
        public void CostInput(string s)
        {
            string sTitle = s;
            Console.WriteLine($"How many {sTitle}s?");
            int iCount = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

            Console.WriteLine($"----{sTitle}s----");
            for (int i = 0; i < iCount; i++)
            {
                Console.WriteLine($"Name of {sTitle} {i + 1}?");
                sName.Add(Console.ReadLine());
                Console.WriteLine($"{sTitle} {i + 1} Amount?");
                dAmount.Add(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine();
            }

            Console.Clear();
            Console.WriteLine($"----{sTitle}s----");
            for (int i = 0; i < iCount; i++)
            {
                Console.WriteLine($"{sName[i]} : ${dAmount[i]}\n");
            }

        }
        //----Loop for entering Trip and Expenses----//
    }
}

