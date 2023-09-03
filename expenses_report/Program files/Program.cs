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
        //----------//


        do
        {
            //----Loop for User input----//
            do
            {
                //----Call Staff Menu Selection with IntExceptions----//
              
                Menu1.MenuOp();
                iUserSelection = ErrorHandling.IntException();

                //----Declare staff name----//
                switch (iUserSelection)
                {

                    case 1:
                        Staff.Name = sNames[0, 0];
                        Staff.StaffNo = Convert.ToInt16(sNames[0, 1]);
                        break;

                    case 2:
                        Staff.Name = sNames[1, 0];
                        Staff.StaffNo = Convert.ToInt16(sNames[1, 1]);
                        break;

                    case 3:
                        Staff.Name = sNames[2, 0];
                        Staff.StaffNo = Convert.ToInt16(sNames[2, 1]);
                        break;

                    case 4:
                        Staff.Name = sNames[3, 0];
                        Staff.StaffNo = Convert.ToInt16(sNames[3, 1]);
                        break;
                }
                //--------//

                iUserSelection = 0;
                Console.Clear();

                //----Travel and Expenses input and Assignment----//
                Console.WriteLine($"----Hi {Staff.Name}---- \n " +
                    $"Please get ready the following: \n " +
                    $"Total trip costs and other travel expenses \n" +
                    $"----Press ENTER to continue----");
                Console.ReadLine();

                do
                {
                    Console.Clear();
                    Trip.Intro();
                    Trip.CostInput("Trip");
                    Menu2.MenuOp();
                    iUserSelection = Convert.ToInt16(Console.ReadLine());
                } while (iUserSelection != 1);
                iUserSelection = 0;

                do
                {
                    Console.Clear();
                    Expense.Intro();
                    Expense.CostInput("Expense");
                    Menu2.MenuOp();
                    iUserSelection = Convert.ToInt16(Console.ReadLine());

                } while (iUserSelection != 1);
                iUserSelection = 0;
                Console.Clear();

                Staff.TripCount = Trip.Name.Count;
                Staff.TripCosts = Trip.Amount.Sum();
                Staff.TripExp = Expense.Amount.Sum();
                Staff.ExpRefund = CalcRefund(Staff.TripCosts, Staff.TripExp, Staff.TripCount);
                Office.TotalCosts = (Staff.TripCosts + Staff.TripExp);
                Office.TaxRebate = Math.Round(TaxCalc(Office.TotalCosts), 2);
                //--------//


                //----Confirm Details----//
                Console.WriteLine(
                    $"Staff Member: {Staff.Name} \n" +
                    $"Staff Number: {Staff.StaffNo} \n" +
                    $"Number Of Trips: {Staff.TripCount} \n" +
                    $"Travel Costs: ${Staff.TripCosts} \n" +
                    $"Other Travel Expenses: ${Math.Round(Staff.TripExp, 2)} \n"
                    );

                Menu2.MenuOp();
                iUserSelection = Convert.ToInt16(Console.ReadLine());
                //--------//

                Console.Clear();
            } while (iUserSelection != 1);
            iUserSelection = 0;
            //--------//


            //----Summary----//
            Console.WriteLine(
                $"Average Expense: ${Math.Round(Expense.Amount.Average(), 2)} \n" +
                $"Largest Expense: ${Expense.Amount.Max()} \n" +
                $"Staff Refunded: ${Staff.ExpRefund} of ${Office.TotalCosts} \n" +
                $"Company Tax Rebate at {Company.Tax * 100}%: ${Office.TaxRebate} of ${Office.TotalCosts}"
                );
            //--------//

            //----Option to save to a file----//
            Console.WriteLine();
            Menu3.MenuOp();
            iUserSelection = Convert.ToInt16(Console.ReadLine());
            Console.Clear();

        } while (iUserSelection != 1);

        StaffMember.StreamWrite(
            Staff.Name,
            Staff.StaffNo,
            Staff.TripCount,
            Staff.TripCosts,
            Staff.TripExp,
            Staff.ExpRefund,
            Math.Round(Expense.Amount.Average(), 2),
            Expense.Amount.Max(),
            Office.TaxRebate,
            Office.TotalCosts
            );
        //--------//
    }
}

