using System;
namespace expenses_report
{
    public class Menu
    {
        public string sTitle;
        public string[] sOptions = new string[4];
        public int iItems;


        public Menu(string Title, string Option1, string Option2, string Option3, string Option4)
        {
            //4 Option Menu//
            sTitle = Title;
            sOptions[0] = Option1;
            sOptions[1] = Option2;
            sOptions[2] = Option3;
            sOptions[3] = Option4;
            iItems = 4;
            //4 Option Menu//
        }
        public Menu(string Title, string Option1, string Option2)
        {
            //2 Option Menu//
            sTitle = Title;
            sOptions[0] = Option1;
            sOptions[1] = Option2;
            iItems = 2;
            //2 Option Menu//
        }
        public void MenuOp()
        {
            //Call Menu Function//
            Console.WriteLine(sTitle);

            for (int i = 0; i < iItems; i++)
                Console.WriteLine($"{i + 1}: " + sOptions[i]);
            //Call Menu Function//

        }
    }
}

