using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labsheet4
{
    class lunchDemon
    {
        static void Main(string[] args)
        {
            Lunch l1 = new Lunch("hamburger", "fries", "cola");
            Lunch l2 = new Lunch("hot dog", "chips", "lemonade");
            Lunch l3 = new Lunch("pizza", "salad", "iced tea");
            Lunch l4 = new Lunch("tuna sandwich", "fruit cup", "water");
            Lunch l5 = new Lunch("peanut butter sandwich", "cookie", "milk");

            Lunch[] lunchArr = new Lunch[3];
            lunchArr[0] = l1;
            lunchArr[1] = l2;
            lunchArr[2] = l3;
            l1.displayLunches(lunchArr);

            lunchArr = new Lunch[4];
            lunchArr[0] = l1;
            lunchArr[1] = l2;
            lunchArr[2] = l3;
            lunchArr[3] = l4;
            l1.displayLunches(lunchArr);

            lunchArr = new Lunch[5];
            lunchArr[0] = l1;
            lunchArr[1] = l2;
            lunchArr[2] = l3;
            lunchArr[3] = l4;
            lunchArr[4] = l5;
            l1.displayLunches(lunchArr);
        }
    }

    class Lunch
    {
        public string entree { get; set; }
        public string side { get; set; }
        public string drink { get; set; }

        public Lunch(string entree, string side, string drink)
        {
            this.entree = entree;
            this.side = side;
            this.drink = drink;
        }

        public void displayLunches(params Lunch[] arr)
        {
            Console.WriteLine(String.Format("{0,-30} {1,-30} {2,-30}", "Entree:", "Side:", "Drink:"));
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(String.Format("{0,-30} {1,-30} {2,-30}", arr[i].entree, arr[i].side, arr[i].drink));
            }
            Console.WriteLine("\n");
        }

    }
}
