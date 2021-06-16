using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            ArrayList menu = new ArrayList();
            menu.Add("      ===== Manage books =====");
            menu.Add("1. Add new book,");
            menu.Add("2. Find a book,");
            menu.Add("3. Show book,");
            menu.Add("4. Remove a book,");
            menu.Add("5. Quit");
            MyBookLibrary.ProductData pro = new MyBookLibrary.ProductData();
            do
            {
                do
                {
                    Console.WriteLine("===========================================");
                    foreach (string show in menu)
                    {
                        Console.WriteLine(show);
                    }
                    Console.WriteLine("Choose from 1 to 5: ");
                    choice = int.Parse(Console.ReadLine());
                    if (choice < 1 || choice > 5) Console.WriteLine("input from 1 to 5");
                } while (choice < 1 || choice > 5);
                switch (choice)
                {
                    case 1:
                        pro.AddNew();
                        break;
                    case 2:
                        pro.Search();
                        break;
                    case 3:
                        pro.ListAll();
                        break;
                    case 4:
                        pro.Remove();
                        break;

                }
                Console.WriteLine("===========================================\n");
            } while (choice != 5);
        }
    }
}
