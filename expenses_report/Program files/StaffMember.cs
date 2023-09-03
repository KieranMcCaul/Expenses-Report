using System;
namespace expenses_report
{
    class StaffMember
    {
        string sName = "";
        int iStaffNo;

        int iTripCount;
        double dTripCosts;
        double dTripExp;
        double dExpRefund;

        public string Name
        {
            get => sName; set => sName = value;
        }
        public int StaffNo
        {
            get => iStaffNo; set => iStaffNo = value;
        }
        public int TripCount
        {
            get => iTripCount; set => iTripCount = value;
        }
        public double TripCosts
        {
            get => dTripCosts; set => dTripCosts = value;
        }
        public double TripExp
        {
            get => dTripExp; set => dTripExp = value;
        }
        public double ExpRefund
        {
            get => dExpRefund; set => dExpRefund = value;
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
                    $"Company Tax Rebate at {Company.Tax * 100}%: ${TaxRebate} of ${TotalCosts}";

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
            //--------//
        }
        //--------//
    }
}
