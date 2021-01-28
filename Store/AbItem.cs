/*
 *
 * Name: Logan Brown
 * File: AbItem.cs
 * Date: 1/27/2020
 * Description: Holds the abstract item class, as well as three child classes.
 *
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    public abstract class AbItem
    {
        protected string type;
        protected string name;
        protected int quantity;
        protected double price;

        //A basic constructer, no class inherits this.
        public AbItem()
        {
            type = "None";
            name = "None";
            quantity = 0;
            price = 0.00;
        }

        //I will define all the methods here, as all of them are overriden in the same way, if not very similar

        /*
         * Name: checkPrice
         * 
         * Parameters: None
         * 
         * Description: Returns Price, I made a different function with a different name
         */
        public abstract double checkPrice();
        /*
         * Name: printInfo
         * 
         * Parameters: None
         * 
         * Description: Prints the info of the item; All variables of the class are printed with a label
         */
        public abstract void printInfo();
        /*
         * Name: purchase
         * 
         * Parameters: None
         * 
         * Description: Reduces quantity by specified amount. Again, replaced with a function I like better.
         */
        public abstract void purchase();
        /*
         * Name: getName
         * 
         * Parameters: None
         * 
         * Description: returns the name variable
         */
        public abstract string getName();
        /*
         * Name: getPrice();
         * 
         * Parameters: None
         * 
         * Description: Returns price variable
         */
        public abstract double getPrice();
        /*
         * Name: setQuantity
         * 
         * Parameters:
         *      int amount - amount to change Quantity variable. Make negative to subtract from quantity
         *      
         * Description: Changes quantity to simulate a purchase or restock
         */
        public abstract void setQuantity(int amount);
    }

    /*
     * Here starts the first child class
     *
     */

    public class Vegetable : AbItem
    {
        private string color;
        
        public Vegetable()
        {
            type = "None";
            name = "None";
            quantity = 0;
            price = 0.00;
            color = "None";
        }

        public Vegetable(string typeVar, string nameVar, int quantityVar, double priceVar, string colorVar)
        {
            type = typeVar;
            name = nameVar;
            quantity = quantityVar;
            price = priceVar;
            color = colorVar;
        }
        public override double checkPrice()
        {
            return price;
        }

        public override void printInfo()
        {
            Console.WriteLine("Type: " + type);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Color: " + color);
        }

        public override void purchase()
        {
            int numItem;
            Console.Write("How many item are being purchased? ");

            try
            {
                numItem = Convert.ToInt32(Console.ReadLine());
                while (numItem < 0)
                {
                    Console.WriteLine("Invalid Number.");
                    Console.Write("How many item are being purchased? ");
                    numItem = Convert.ToInt32(Console.ReadLine());
                }

                quantity -= numItem;
            }
            catch
            {
                Console.WriteLine("Whoops! There has been an error. Hit enter to continue.");
                Console.ReadLine();
            }
        }

        public override string getName()
        {
            return name;
        }

        public override double getPrice()
        {
            return price;
        }

        public override void setQuantity(int amount)
        {
            // amount should be negative to lessen amount
            quantity += amount;
        }
    }

    /*
     * Next child class starts here!
     * 
     */

    public class Textbook : AbItem
    {
        private int pageNum;

        public Textbook()
        {
            type = "None";
            name = "None";
            quantity = 0;
            price = 0.00;
            pageNum = 0;
        }

        public Textbook(string typeVar, string nameVar, int quantityVar, double priceVar, int pageNumVar)
        {
            type = typeVar;
            name = nameVar;
            quantity = quantityVar;
            price = priceVar;
            pageNum = pageNumVar;
        }
        
        public override double checkPrice()
        {
            return price;
        }

        public override void printInfo()
        {
            Console.WriteLine("Type: " + type);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Pages: " + pageNum);
        }

        public override void purchase()
        {
            int numItem;
            Console.Write("How many item are being purchased? ");

            try
            {
                numItem = Convert.ToInt32(Console.ReadLine());
                while (numItem < 0)
                {
                    Console.WriteLine("Invalid Number.");
                    Console.Write("How many item are being purchased? ");
                    numItem = Convert.ToInt32(Console.ReadLine());
                }

                quantity -= numItem;
            }
            catch
            {
                Console.WriteLine("Whoops! There has been an error. Hit enter to continue.");
                Console.ReadLine();
            }
        }

        public override string getName()
        {
            return name;
        }

        public override double getPrice()
        {
            return price;
        }

        public override void setQuantity(int amount)
        {
            // amount should be negative to lessen amount
            quantity += amount;
        }
    }

    /*
     * Next child class here!
     *
     */

    public class VideoGame : AbItem
    {
        private string genre;

        public VideoGame()
        {
            type = "None";
            name = "None";
            quantity = 0;
            price = 0.00;
            genre = "None";
        }

        public VideoGame(string typeVar, string nameVar, int quantityVar, double priceVar, string genreVar)
        {
            type = typeVar;
            name = nameVar;
            quantity = quantityVar;
            price = priceVar;
            genre = genreVar;
        }

        public override double checkPrice()
        {
            return price;
        }

        public override void printInfo()
        {
            Console.WriteLine("Type: " + type);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Genre: " + genre);
        }

        public override void purchase()
        {
            int numItem;
            Console.Write("How many item are being purchased? ");

            try
            {
                numItem = Convert.ToInt32(Console.ReadLine());
                while (numItem < 0)
                {
                    Console.WriteLine("Invalid Number.");
                    Console.Write("How many item are being purchased? ");
                    numItem = Convert.ToInt32(Console.ReadLine());
                }

                quantity -= numItem;
            }
            catch
            {
                Console.WriteLine("Whoops! There has been an error. Hit enter to continue.");
                Console.ReadLine();
            }
        }

        public override string getName()
        {
            return name;
        }

        public override double getPrice()
        {
            return price;
        }

        public override void setQuantity(int amount)
        {
            // amount should be negative to lessen amount
            quantity += amount;
        }
    }
}
