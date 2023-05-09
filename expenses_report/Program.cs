namespace expenses_report;
using static Calculation;



class Program
{
    static void Main(string[] args)
    {
        //-----Create Staff Names, Menus and Objects-----//
        string[,] sNames = { { "Kieran", "1001" }, { "Emily", "1002" }, { "Axel", "1003" }, { "Toby", "1004" } };
        int iUserSelection = 0;

        Company Office = new Company();
        StaffMember Staff = new StaffMember();
        Expenses Expense = new Expenses();
        Trips Trip = new Trips();


        Menu Menu1 = new Menu(
            "----Please select the staff member----",
            sNames[0, 0],
            sNames[1, 0],
            sNames[2, 0],
            sNames[3, 0]);
        Menu Menu2 = new Menu("----Is this information correct?----",
            "Yes", "No"
            );
        Menu Menu3 = new Menu("---- Would you like to save to a file?----",
            "Yes", "No"
            );
        //-----Create Staff Names and Objects-----//

        do
        {

            //----Loop for User input----//
            do
            {
                //----Call Staff Menu Selection with exceptions----//
                do
                {
                    Menu1.MenuOp();
                    iUserSelection = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                    Exceptions(iUserSelection);
                } while (iUserSelection < 1 || iUserSelection > 4);
                //----Call Staff Menu Selection----//


                //----Declare staff name----//
                switch (iUserSelection)
                {

                    case 1:
                        Staff.sName = sNames[0, 0];
                        Staff.iStaffNo = Convert.ToInt16(sNames[0, 1]);
                        break;

                    case 2:
                        Staff.sName = sNames[1, 0];
                        Staff.iStaffNo = Convert.ToInt16(sNames[1, 1]);
                        break;

                    case 3:
                        Staff.sName = sNames[2, 0];
                        Staff.iStaffNo = Convert.ToInt16(sNames[2, 1]);
                        break;

                    case 4:
                        Staff.sName = sNames[3, 0];
                        Staff.iStaffNo = Convert.ToInt16(sNames[3, 1]);
                        break;
                }
                //----Declare staff name----//

                iUserSelection = 0;
                Console.Clear();


                //----Travel and Expenses input and Assignment----//
                Console.WriteLine($"----Hi {Staff.sName}---- \n " +
                    $"Please get ready the followeing: \n " +
                    $"Total trip costs and other travel expenses \n" +
                    $"----Press any key to continue----");
                Console.ReadLine();


                do
                {
                    Console.Clear();
                    Trip.CostInput("Trip");
                    Menu2.MenuOp();
                    iUserSelection = Convert.ToInt16(Console.ReadLine());
                } while (iUserSelection != 1);
                iUserSelection = 0;

                do
                {
                    Console.Clear();
                    Expense.CostInput("Expense");
                    Menu2.MenuOp();
                    iUserSelection = Convert.ToInt16(Console.ReadLine());

                } while (iUserSelection != 1);
                iUserSelection = 0;
                Console.Clear();

                Staff.iTripCount = Trip.sName.Count;
                Staff.dTripCosts = Trip.dAmount.Sum();
                Staff.dTripExp = Expense.dAmount.Sum();
                Staff.dExpRefund = CalcRefund(Staff.dTripCosts, Staff.dTripExp, Staff.iTripCount);
                Office.dTotalCosts = (Staff.dTripCosts + Staff.dTripExp);
                Office.dTaxRebate = Math.Round(TaxCalc(Office.dTotalCosts), 2);
                //----Travel and Expenses input and Assignment----//


                //----Confirm Details----//
                Console.WriteLine(
                    $"Staff Member: {Staff.sName} \n" +
                    $"Staff Number: {Staff.iStaffNo} \n" +
                    $"Number Of Trips: {Staff.iTripCount} \n" +
                    $"Travel Costs: ${Staff.dTripCosts} \n" +
                    $"Other Travel Expenses: ${Math.Round(Staff.dTripExp, 2)} \n"
                    );

                Menu2.MenuOp();
                iUserSelection = Convert.ToInt16(Console.ReadLine());
                //----Confirm Details----//

                Console.Clear();
            } while (iUserSelection != 1);
            iUserSelection = 0;
            //----Loop for User input----//


            //----Summary----//
            Console.WriteLine(
                $"Average Expense: ${Math.Round(Expense.dAmount.Average(), 2)} \n" +
                $"Largest Expense: ${Expense.dAmount.Max()} \n" +
                $"Staff Refunded: ${Staff.dExpRefund} of ${Office.dTotalCosts} \n" +
                $"Company Tax Rebate at {Company.iTax * 100}%: ${Office.dTaxRebate} of ${Office.dTotalCosts}"
                );
            //----Summary----//

            //----Option to save to a file----//
            Console.WriteLine();
            Menu3.MenuOp();
            iUserSelection = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

        } while (iUserSelection != 1);

        StaffMember.StreamWrite(
            Staff.sName,
            Staff.iStaffNo,
            Staff.iTripCount,
            Staff.dTripCosts,
            Staff.dTripExp,
            Staff.dExpRefund,
            Math.Round(Expense.dAmount.Average(), 2),
            Expense.dAmount.Max(),
            Office.dTaxRebate,
            Office.dTotalCosts
            );
        //----Option to save to a file----//
    }
}

