using System;
namespace expenses_report
{
    static class Calculation
    {
        //----Staff refund calculation----//
        public static double CalcRefund(double dTravelCosts, double dTravelExp, int iTripCount)
        {

            double dResult;
            int iRefund = 50;
            if (dTravelExp > (iRefund * iTripCount))
            {
                dTravelExp = (iRefund * iTripCount);
                dResult = (dTravelCosts + dTravelExp);

                return Math.Round(dResult,2);
            }

            else
            {
                dResult = (dTravelCosts + dTravelExp);
                return Math.Round(dResult,2);
            }
        }
        //--------//


        //----Company tax refund calculation----//
        public static double TaxCalc(double preTaxTotal)
        {

            double TaxRebate = (preTaxTotal * (Company.Tax));
            return Math.Round(TaxRebate,2);

        }
        //--------//



    }
}

