using System;
using System.IO;

namespace expenses_report
{
    public class StaffMember
    {
        public string sName;
        public int iStaffNo;

        public int iiTripCount;
        public double dTripCosts;
        public double dTripExp;
        public double dExpRefund;

        public StaffMember()
        {
        }

        //----Print to file----//
        public static void StreamWrite(string Name, int StaffNo, int TripNo, double TripCosts, double TripExp, double ExpRefund, double ExpAmount, double LargeAmount, double TaxRebate, double TotalCosts)
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
        //----Print to file----//
    }
}
