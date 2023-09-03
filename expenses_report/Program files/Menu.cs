using System;
namespace expenses_report
{
    class Menu
    {
        string sTitle;
        string[] sOptions = new string[4];
        int iItems;

        public string Title
        {
            get => sTitle; set => sTitle = value;
        }
        public string[] Options
        {
            get => sOptions; set => sOptions = value;
        }
        public int Items
        {
            get => iItems; set => iItems = value;
        }

        public Menu(string Title, string Option1, string Option2, string Option3, string Option4)
        {
            //4 Option Menu//
            sTitle = Title;
            sOptions[0] = Option1;
            sOptions[1] = Option2;
            sOptions[2] = Option3;
            sOptions[3] = Option4;
            iItems = 4;
            //--------//
        }
        public Menu(string Title, string Option1, string Option2)
        {
            //2 Option Menu//
            sTitle = Title;
            sOptions[0] = Option1;
            sOptions[1] = Option2;
            iItems = 2;
            //--------//
        }
        public void MenuOp()
        {
            //Call Menu Function//
            Console.WriteLine(sTitle);

            for (int i = 0; i < iItems; i++)
                Console.WriteLine($"{i + 1}: " + sOptions[i]);
            //--------//
        }
    }
}

