using System;
namespace expenses_report
{

    class Company
    {
        double dTotalCosts;
        double dTaxRebate;
        static double iTax = .2;

        public double TotalCosts
        {
            get => dTotalCosts; set => dTotalCosts = value;
        }
        public double TaxRebate
        {
            get => dTaxRebate; set => dTaxRebate = value;
        }
        public static double Tax
        {
            get => iTax; set => iTax = value;
        }
    }
}

