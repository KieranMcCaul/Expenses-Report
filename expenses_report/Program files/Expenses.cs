using System;
namespace expenses_report
{
    //----Inherited properties and methods from Trips class
    class Expenses : Trips
    {
        public override void Intro()
        {
            Console.WriteLine("Please gather Expenses data \n ----Press ENTER to continue----");
            Console.ReadLine();
        }

    }
}

