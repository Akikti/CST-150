using System;
using System.Collections.Generic;

namespace Inventory_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add");
            Console.WriteLine("Display");
            Console.WriteLine("Remove");
            Console.WriteLine("Search by name");
            Console.WriteLine("Search by price");
            Console.WriteLine("Re-stock");
            Console.WriteLine("Exit");

            InventoryManager i1 = new InventoryManager();
            int ch;

            for (; ; )
            {

                Console.WriteLine("Enter Item");
                ch = Convert.ToInt32(Console.ReadLine());


                switch (ch)
                {
                    case 1:
                        i1.addItem();
                        break;
                    case 2:
                        i1.displayItem();
                        break;

                    case 3:
                        i1.removeItem();
                        break;
                    case 4:
                        Console.WriteLine("Search Item ");
                        string n = Console.ReadLine();
                        i1.searchItemByName(n);
                        break;

                    case 5:

                        Console.WriteLine("Search Price ");
                        double d = Convert.ToDouble(Console.ReadLine());
                        i1.searchItemByPrice(d);
                        break;

                    case 6:
                        Console.WriteLine("Choose Item to Restock ");
                        string n2 = Console.ReadLine();

                        i1.editItem(n2);
                        break;

                    case 7:
                        Environment.Exit(0);
                        break;

                }

            }

        }
    }


    class InventoryManager
    {

        
        List<Item> l1 = new List<Item>();

        public void addItem()
        {
            string n;
            double p;
            int q;


            Console.WriteLine("Enter item  ");
            n = Console.ReadLine();

            Console.WriteLine("Enter  price ");
            p = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter  quantity ");
            q = Convert.ToInt32(Console.ReadLine());

            Item i = new Item(n, p, q); 

            l1.Add(i);

        }

        public void displayItem()
        {

            string s = String.Format("{0,10}{1,10}{2,10}", "name", "price", "quantity");
            Console.WriteLine(s + "\n");

            foreach (Item i in l1)
            {

                string s1 = String.Format("{0,10}{1,10}{2,10}", i.Name, i.Price, i.Qty);
                Console.WriteLine(s1 + "\n");

            }


        }

        public void removeItem()
        {

            Console.WriteLine("Remove Item ");
            string n = Console.ReadLine();

            int flag = 0;

            
            for (int i = 0; i < l1.Count; i++)
            {

                if (l1[i].Name.Equals(n)) 
                {
                    l1.RemoveAt(i);
                    Console.WriteLine("Item removed");
                    flag = 1;
                }
            }

            if (flag == 0)
                Console.WriteLine("Item not found");

        }

        
        public void searchItemByName(string n)
        {

            int flag = 0;
            
            string s = String.Format("{0,10}{1,10}{2,10}", "name", "price", "quantity");
            Console.WriteLine(s + "\n");

            
            foreach (Item i in l1)
            {

                
                if (i.Name.Equals(n))
                {
                    
                    string s1 = String.Format("{0,10}{1,10}{2,10}", i.Name, i.Price, i.Qty);
                    Console.WriteLine(s1 + "\n");
                    flag = 1;
                }

            }

            if (flag == 0)
                Console.WriteLine("Item not found");


        }

        
        public void searchItemByPrice(double p)
        {

            int flag = 0;
            string s = String.Format("{0,10}{1,10}{2,10}", "name", "price", "quantity");
            Console.WriteLine(s + "\n");

            
            foreach (Item i in l1)
            {

                
                if (i.Price == p)
                {
                    
                    string s1 = String.Format("{0,10}{1,10}{2,10}", i.Name, i.Price, i.Qty);
                    Console.WriteLine(s1 + "\n");
                    flag = 1;
                }

            }

            if (flag == 0)
                Console.WriteLine("Item not found");

        }


        public void editItem(string n)
        {


            Console.WriteLine("Enter new  quantity for item ");
            string n2 = Console.ReadLine();

            int q = Convert.ToInt32(n2);

            
            foreach (Item i in l1)
            {


                if (i.Name.Equals(n))
                {
                    i.Qty = q;
                    Console.WriteLine("updated");
                }

            }

        }

    }

    class Item
    {

        
        string name;
        double price;
        int qty;

        
        public Item(string n, double p, int q)
        {
            Name = n;
            Price = p;
            Qty = q;

        }

       
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Qty { get => qty; set => qty = value; }


    }

}