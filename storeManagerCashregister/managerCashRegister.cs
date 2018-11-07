using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeManagerCashregister
{
    class managerCashRegister
    {
        static void Main(string[] args)
        {
            cashRegister reg1 = new cashRegister();
            cashRegister reg2 = new cashRegister();
            cashRegister reg3 = new cashRegister();

            for (int i = 0; i < 4; i++)
            {
                reg1.addItem(i + i + (decimal).77);
            }
            for (int i = 0; i < 8; i++)
            {
                reg2.addItem(i + i + (decimal)0.13);
            }
            for (int i = 0; i < 6; i++)
            {
                reg3.addItem(i + i + (decimal).15);
            }

            Console.Write("Register1 total: ");
            Console.Write(reg1.getTotal());
            Console.Write(", items: ");
            Console.Write(reg1.getNumberOfItems());
            Console.WriteLine(".\n");

            Console.Write("Register2 total: ");
            Console.Write(reg2.getTotal());
            Console.Write(", items: ");
            Console.Write(reg2.getNumberOfItems());
            Console.WriteLine(".\n");

            Console.Write("Register3 total: ");
            Console.Write(reg3.getTotal());
            Console.Write(", items: ");
            Console.Write(reg3.getNumberOfItems());
            Console.WriteLine(".\n");

            Console.WriteLine("Total items from all cash registers: " + cashRegister.getNumberOfItemsFromAllCashRegisters());
            Console.WriteLine("Total value from all cash registers: " + cashRegister.getTotalFromAllCashRegisters());
        }
    }

    class cashRegister
    {
        private decimal total;
        private int numberOfItems;

        private static decimal totalFromAllCashRegisters;
        private static int numberOfItemsFromAllCashRegisters;

        public cashRegister()
        {
            this.total = 0;
            this.numberOfItems = 0;
        }
        public void addItem(decimal price)
        {
            Console.WriteLine("Adding item worth " + price + " to cash register!\n");
            this.numberOfItems++;
            total += price;
            addToTotalItemsFromAll();
            addToTotalValueFromAll(price);
        }
        public decimal getTotal()
        {
            return this.total;
        }
        public int getNumberOfItems()
        {
            return this.numberOfItems;
        }

        //static getters
        public static decimal getTotalFromAllCashRegisters()
        {
            return totalFromAllCashRegisters;
        }

        public static int getNumberOfItemsFromAllCashRegisters()
        {
            return numberOfItemsFromAllCashRegisters;
        }

        public static void addToTotalItemsFromAll()
        {
            numberOfItemsFromAllCashRegisters += 1;
        }

        public static void addToTotalValueFromAll(decimal amount)
        {
            totalFromAllCashRegisters += (decimal)amount;
        }
    }
}
