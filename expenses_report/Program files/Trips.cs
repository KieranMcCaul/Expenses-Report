using System;
namespace expenses_report;
using static ErrorHandling;


class Trips
{
    //----Dynamic List for entering trips----//
    List<string> sName = new List<string>();
    List<double> dAmount = new List<double>();

    public List<string> Name
    {
        get => sName; set => sName = value;
    }
    public List<double> Amount
    {
        get => dAmount; set => dAmount = value;
    }
    //--------//

 
    public virtual void Intro()
    {
        Console.WriteLine("Please gather Trip data \n ----Press ENTER to continue----");
        Console.ReadLine();
    }


    //----Loop for entering Trip and Expenses----//
    public void CostInput(string s)
    {
        
        bool bValidate = false;
        double dAmountCheck = 0;
        string sTitle = s;

        //----Reset Input if incorrect----//
        sName.Clear();
        dAmount.Clear();
        //--------//

        Console.WriteLine($"How many {sTitle}s?");

        int iCount = Convert.ToInt16(Console.ReadLine());
        Console.Clear();

        Console.WriteLine($"----{sTitle}s----");
        for (int i = 0; i < iCount; i++)
        {
            Console.WriteLine($"Name of {sTitle} {i + 1}?");
            sName.Add(Console.ReadLine());

            //----Error handling----//
            do
            {
                do
                {
                
                    Console.WriteLine($"Please enter {sName[i]} {sTitle} costs, between 1.00 and 500.00");
                    try
                    {
                        dAmountCheck = Convert.ToDouble(Console.ReadLine());
                        bValidate = true;
                    }

                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine(
                        "----ERROR!---- \nPlease enter a valid amount");
                        bValidate = false;

                    }
                } while (bValidate == false);
                Console.Clear();
            } while (dAmountCheck < 1 || dAmountCheck > 500);
            dAmount.Add(dAmountCheck);
            dAmountCheck = 0;
        }
        //--------//

        Console.Clear();
        Console.WriteLine($"----{sTitle}s----");
        for (int i = 0; i < iCount; i++)
        {
            Console.WriteLine($"{sName[i]} : ${dAmount[i]}\n");
        }

    }
    //--------//
}

