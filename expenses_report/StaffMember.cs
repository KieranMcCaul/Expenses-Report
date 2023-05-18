using System;

namespace expenses_report
{
    public class StaffMember
    {
        public string sName;
        public int iStaffNo;

        public int iTripCount;
        public double dTripCosts;
        public double dTripExp;
        public double dExpRefund;

        public StaffMember()
        {
        }

        //----Print to file----//
        public static void StreamWrite(string Name, int StaffNo, int TripNo, double TripCosts, double TripExp, double ExpRefund, double ExpAmount, double LargeAmount, double TaxRebate, double TotalCosts)
        {
            bool bError = false;

            try
            {

                string writeText =
                    $"----Staff----\n" +
                    $"Staff Member: {Name} \n" +
                    $"Staff Number:  ${StaffNo} \n" +
                    $"Number of Trips: ${TripNo} \n" +
                    $"Travel Costs: ${TripCosts} \n" +
                    $"Other Trip Expenses: ${TripExp} \n" +
                    $"Expenses Refunded: ${ExpRefund} of ${TotalCosts}\n" +
                    $"----Company----\n" +
                    $"Average Expense: ${ExpAmount} \n" +
                    $"Largest Expense: ${LargeAmount} \n" +
                    $"Company Tax Rebate at {Company.iTax * 100}%: ${TaxRebate} of ${TotalCosts}";

                File.WriteAllText($"{Name}.txt", writeText);
            }

            //----Error handling----//
            catch (Exception e)
            {
                Console.WriteLine($"An Error occured saving the file{e}");
                bError = true;
            }

            finally
            {
                if (bError == true)
                {
                    Console.WriteLine("File not saved, please restart the program");
                }
                else
                {
                    Console.WriteLine($"File saved as '{Name}.txt'");
                    Console.WriteLine("Press any button to close the program");
                    Console.ReadLine();
                }
            }
            //----Error handling----//

        }
        //----Print to file----//
    }
}
