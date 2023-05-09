using System;
namespace expenses_report
{
    static class Calculation
    {
        //----Staff refund calculation----//
        public static double CalcRefund(double dTravelCosts, double dTravelExp, int iTripCount)
        {
           
            double dResult;
            if (dTravelExp > (50 * iTripCount))
            {
                dTravelExp = (50 * iTripCount);
                dResult = (dTravelCosts + dTravelExp);

                return dResult;
            }

            else
            {
                dResult = (dTravelCosts + dTravelExp);
                return dResult;
            }
        }
        //----Staff refund calculation----//


        //----Company tax refund calculation----//
        public static double TaxCalc(double preTaxTotal)
        {

            double TaxRebate = (preTaxTotal * (Company.iTax));
            return TaxRebate;

        }

        //----Company tax refund calculation----//
        public static void Exceptions(int i)
        {
            if (i < 1 || i > 4)
            {
                Console.WriteLine("Please enter a valid number between 1 and 4");
            }
            
        }
        //----Company tax refund calculation----//

    }
}

