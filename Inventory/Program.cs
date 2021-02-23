using System;
using System.Linq;
using System.Collections.Generic;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive a journal with some Collecting items, separated with ', '(comma and space).
            //After that, until receiving "Craft!" you will be receiving different commands. 
            //Commands(split by " - "):
            List<string> journalCollectingItems = Console.ReadLine()
                 .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="Craft!")
                {
                    break;
                }

                string[] commands = input
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string command = commands[0];
                string item = commands[1];
                

                switch (command)
                {
                    case "Collect":
                        if (journalCollectingItems.Contains(item))
                        {
                            continue;
                        }
                        else
                        {
                            journalCollectingItems.Add(item);
                        }
                        break;
                    case "Drop":
                        if (journalCollectingItems.Contains(item))
                        {
                            journalCollectingItems.Remove(item);
                        }
                        break;
                    case "Renew":
                        if (journalCollectingItems.Contains(item))
                        {
                            journalCollectingItems.Remove(item);
                            journalCollectingItems.Add(item);
                        }
                        break;
                    case "Combine Items":
                        string[] specialCase = item
                            .Split(":", StringSplitOptions.RemoveEmptyEntries);
                        string oldItem = specialCase[0];
                        string newItem = specialCase[1];

                        if (journalCollectingItems.Contains(oldItem))
                        {
                            int idx = journalCollectingItems.IndexOf(oldItem);
                            journalCollectingItems.Insert(idx + 1, newItem);
                        }
                        break;
                    default:
                        break;
                }
                //•	"Collect - {item}" – Receiving this command, you should add the given item in your inventory.
                //If the item already exists, you should skip this line.
                
                //•	"Drop - {item}" – You should remove the item from your inventory, if it exists.
                
                //•	"Combine Items - {oldItem}:{newItem}" – 
                //You should check if the old item exists, if so, add the new item after the old one. Otherwise, ignore the command.
                
                //•	"Renew – {item}" – If the given item exists, you should change its position and put it last in your inventory.

            }
            Console.WriteLine(string.Join(", ",journalCollectingItems));

        }
    }
}
