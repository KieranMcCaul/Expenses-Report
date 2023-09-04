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

                return dResult;
            }

            else
            {
                dResult = (dTravelCosts + dTravelExp);
                return dResult;
            }
        }
        //--------//


        //----Company tax refund calculation----//
        public static double TaxCalc(double preTaxTotal)
        {

            double TaxRebate = (preTaxTotal * (Company.Tax));
            return TaxRebate;

        }
        //--------//



    }
}

