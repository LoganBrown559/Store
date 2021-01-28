/*
 *
 * Name: Logan Brown
 * File: Program.cs
 * Date: 1/27/2020
 * Description: Holds main driver for program, as well as a Item Manipulation Class to assist the driver in its functions.
 *
 */
using System;
using System.Collections.Generic;

namespace Store
{
    class Program
    {
        //Here is the main driver
        static void Main(string[] args)
        {
            //The main list that holds all items
            List<AbItem> store = new List<AbItem>();

            //Simple Menu
            Console.WriteLine();
            Console.WriteLine("Welcome to Malacai's Magical Mystical Menagerie of Mutated Multi-Purpose Wares!");
            Console.WriteLine("Choose an option by typing a number:");
            Console.WriteLine();
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Check a Price");
            Console.WriteLine("3. Check Information");
            Console.WriteLine("4. Purchase Item");
            Console.WriteLine("5. Exit Application");
            Console.WriteLine();
            Console.Write("Enter your choice: ");

            //Main number that is a choice from the main menu
            int choice = Convert.ToInt32(Console.ReadLine());
            //Used for a sub menu in choice 1
            int option;

            while (choice != 5)
            {
                switch (choice)
                {
                    case 1:
                        //I do error handling here because it's EASY for someone to try and type the word
                        try
                        {
                            Console.WriteLine();
                            Console.WriteLine("What is the item type?");
                            Console.WriteLine("1. Vegetable");
                            Console.WriteLine("2. Textbook");
                            Console.WriteLine("3. Video Game");
                            Console.Write("Enter a correspondeing number: ");
                            option = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                        }
                        catch
                        {
                            //This ensures the loop goes again
                            option = 0;
                        }

                        //Calls one of the create methods of ItemManip
                        if (option == 1)
                        {
                            store.Add(ItemManip.createVegi());
                        }
                        else if (option == 2)
                        {
                            store.Add(ItemManip.createTextbook());
                        }
                        else if (option == 3)
                        {
                            store.Add(ItemManip.createGame());
                        }
                        else
                        {
                            Console.WriteLine("Invalid Number.");
                        }
                        Console.WriteLine("Item Added!");
                        break;

                    case 2:
                        //A simple find name and return price
                        Console.Write("Name of Item: ");
                        string name = Console.ReadLine();
                        
                        for(int i = 0; i < store.Count; i++)
                        {
                            if (name == store[i].getName())
                            {
                                Console.WriteLine("The price is: " + store[i].getPrice());
                            }
                        }
                        
                        break;

                    case 3:
                        //prints a list then the user chooses a number corresponding
                        Console.WriteLine();
                        Console.WriteLine("Choose the corresponding number to the item info you want: ");
                        ItemManip.printList(store);

                        Console.Write("Which number do you want? ");
                        try
                        {
                            int selection = Convert.ToInt32(Console.ReadLine());

                            //This is -1 because the user sees a list starting at 1
                            store[selection - 1].printInfo();
                        }
                        catch
                        {
                            //I've triggered this on accident before. Glad I made a catch!
                            Console.WriteLine("I don't know what you did, but you nearly crashed the program.");
                        }
                        break;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Choose item to purchase : ");
                        ItemManip.printList(store);

                        Console.Write("Which number do you want? ");
                        try
                        {
                            int selection = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("And how many are we buying? ");
                            int purchaseNum = Convert.ToInt32(Console.ReadLine());
                            
                            //We make it negative for the setter function
                            purchaseNum = purchaseNum - (purchaseNum * 2);

                            //This is -1 because the user sees a list starting at 1
                            store[selection - 1].setQuantity(purchaseNum);
                        }
                        catch
                        {
                            Console.WriteLine("I don't know what you did, but you nearly crashed the program.");
                        }
                        break;

                    case 5:
                        Console.WriteLine();
                        Console.WriteLine("Closing Program...");
                        break;

                    default:
                        Console.WriteLine("Invalid number entered!");
                        Console.WriteLine();
                        break;
                }

                //This prevents the menu from being printed again if the user wants to quit
                if (choice != 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Welcome to Malacai's Magical Mystical Menagerie of Mutated Multi-Purpose Wares!");
                    Console.WriteLine("Choose an option by typing a number:");
                    Console.WriteLine();
                    Console.WriteLine("1. Add Item");
                    Console.WriteLine("2. Check a Price");
                    Console.WriteLine("3. Check Information");
                    Console.WriteLine("4. Purchase Item");
                    Console.WriteLine("5. Exit Application");
                    Console.WriteLine();
                    Console.Write("Enter your choice: ");

                    choice = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Farewell!");
        }
    }

    /*
     * 
     * The following is a class is for item manipulation and easily resuable code. It's just handy!
     * 
     */
    
    public class ItemManip
    {
        
        //Creates a Vegi object when needed! Asks all questions needed
        public static Vegetable createVegi()
        {
            Console.Write("What is the Vegetable name? ");
            string name = Console.ReadLine();
            
            Console.Write("How many are we adding? ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("What is the retail price? ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the color of the Vegetable? ");
            string color = Console.ReadLine();

            Vegetable rValue = new Vegetable("Vegetable", name, quantity, price, color);

            return rValue;

        }
        
        //Make a textbook hot off the press when needed. Asks all data needed.
        public static Textbook createTextbook()
        {
            Console.Write("What is the Textbook name? ");
            string name = Console.ReadLine();

            Console.Write("How many are we adding? ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the retail price? ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("How many pages are in the book? ");
            int pages = Convert.ToInt32(Console.ReadLine());

            Textbook rValue = new Textbook("Textbook", name, quantity, price, pages);

            return rValue;

        }

        //Creates a Video Game object. Collects all data needed
        public static VideoGame createGame()
        {
            Console.Write("What is the Video Game name? ");
            string name = Console.ReadLine();

            Console.Write("How many are we adding? ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the retail price? ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the Genre? ");
            string genre = Console.ReadLine();

            VideoGame rValue = new VideoGame("Video Game", name, quantity, price, genre);

            return rValue;

        }

        //Takes any list given (that contains items) and prints each item name to console
        public static void printList(List<AbItem> itemList)
        {

            Console.WriteLine("Here is the list of items:");
            Console.WriteLine();

            for (int i = 0; i < itemList.Count; i++)
            {
                Console.WriteLine((i+1) + ". " + itemList[i].getName());
                
            }
        }
    }
}
