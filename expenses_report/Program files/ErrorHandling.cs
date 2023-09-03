using System;
namespace expenses_report
{
	public static class ErrorHandling
	{
		public static int IntException()
		{
            int iUserSelection = 0;
            do
            {
                try
                {
                    iUserSelection = Convert.ToInt16(Console.ReadLine());
                    if (iUserSelection < 1 || iUserSelection > 4)
                    {
                        Console.WriteLine("Please enter a valid number between 1 and 4");
                        iUserSelection = 0;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("----ERROR!---- \n Please enter a valid number between 1 and 4");
                    iUserSelection = 0;
                }
            } while (iUserSelection == 0);

            return iUserSelection;
		}
    

       
	}
}



