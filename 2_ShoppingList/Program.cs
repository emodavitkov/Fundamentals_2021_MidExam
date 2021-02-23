using System;
using System.Linq;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            //You will receive an initial list with groceries separated by "!".
            //After that you will be receiving 4 types of commands, until you receive "Go Shopping!"
            
            List<string> groceriesList = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input?.ToUpper()=="GO SHOPPING!")
                {
                    break;
                }

                string[] command = input.Split(" ",StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string commandType = command[0];

                switch (commandType)
                {
                    case "Urgent":
                        string itemUrgent = command[1];
                        if (groceriesList.Contains(itemUrgent))
                        {
                            continue;
                        }
                        groceriesList.Insert(0,itemUrgent);
                        break;

                    case "Unnecessary":
                        string itemUnnecessary = command[1];
                        if (!groceriesList.Contains(itemUnnecessary))
                        {
                            continue;
                        }
                        groceriesList.Remove(itemUnnecessary);
                        break;

                    case "Correct":
                        string itemOld = command[1];
                        string itemNew = command[2];
                        if (!groceriesList.Contains(itemOld))
                        {
                            continue;
                        }
                        int correctIdx = groceriesList.IndexOf(itemOld);
                        groceriesList.Remove(itemOld);
                        groceriesList.Insert(correctIdx,itemNew);
                        break;

                    //•	Rearrange {item} - if the grocery exists in the list, remove it from its current position and add 
                     //   it at the end of the list.

                    case "Rearrange":
                        string itemRearange = command[1];
                        
                        if (!groceriesList.Contains(itemRearange))
                        {
                            continue;
                        }
                        
                        groceriesList.Remove(itemRearange);
                        groceriesList.Add(itemRearange);
                        break;

                    default:
                        break;
                }

            }

            Console.WriteLine(string.Join(", ",groceriesList));
            //•	Urgent {item} -add the item at the start of the list.  If the item already exists, skip this command.
            
            //•	Unnecessary { item} -remove the item with the given name, only if it exists in the list. 
            //Otherwise skip this command.

            //•	Correct {oldItem} {newItem} – if the item with the given old name exists, change its name with the new one.
            //If it doesn't exist, skip this command.

           





        }
    }
}
