using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookLibrary
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int Price { get; set; }
    }
    public class ProductData
    {
        private List<Product> ProductList = new List<Product>();
        public void ListAll()
        {
            if (ProductList.Count == 0)
            {
                Console.WriteLine("     >>> Danh sach trong <<<");
                return;
            }
            foreach (Product sv in ProductList)
            {
                Console.WriteLine("ID: " + sv.ID + "Name: " + sv.Name + "Publisher: " + sv.Publisher + "Price: " + sv.Price);
            }
        }
        public Boolean AddNew()
        {
            Product s = new Product();
            Console.WriteLine("Input ID: ");
            s.ID =  int.Parse(Console.ReadLine());
            Console.WriteLine("Input name: ");
            s.Name = Console.ReadLine();
            Console.WriteLine("Input publisher: ");
            s.Publisher = Console.ReadLine();
            Console.WriteLine("Input price: ");
            s.Price = int.Parse(Console.ReadLine());
            Product p = Find(s.ID);
            if (p == null)
            {
                ProductList.Add(s);
                Console.WriteLine("Add success!");
            }
            else
            {
                Console.WriteLine("Add fail!");
                return false;
            } 
            return true;
        }
        public void Search()
        {
            Product s = new Product();
            Console.WriteLine("Input ID want to Find: ");
            s.ID = int.Parse(Console.ReadLine());
            Product p = Find(s.ID);
            if(p == null)
            {
                Console.WriteLine("ID does not exist ");
                return;
            }
            else
            {
                
                Console.WriteLine("this is your book: ");
                Console.WriteLine("ID: " + p.ID + "Name: " + p.Name + "Publisher: " + p.Publisher + "Price: " + p.Price);
            }
            return;
        }
        public Boolean Remove()
        {
            Console.WriteLine("Input ID: ");
            int ID = int.Parse(Console.ReadLine());
            Product p = Find(ID);
            if(p != null)
            {
                ProductList.Remove(p);
                Console.WriteLine("Remove success!");
            }
            else
            {
                Console.WriteLine("ID does not exist!");
                return false;
            }
            return true;


        }
        public Product Find(int ID)
        {
            Product p = ProductList.SingleOrDefault(book => book.ID == ID);
            return p;
        }
    }
}
