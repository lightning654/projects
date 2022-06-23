using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adds_removes_outputs_items_in_list
{
    class Program
    {
        static List<string> Pocket = new List<string>();

        // Subroutine to put data into the list
        static void PutInPocket(string Item)
        {
            Pocket.Add(Item);
        }

        // Subroutine to remove data from the list
        static void TakeOutOfPocket(string Item)
        {
            Pocket.Remove(Item);
        }
        // Subroutine to output the list
        static void ShowPocket()
        {
            foreach (string Item in Pocket)
            {
                Console.WriteLine(Item);
            }
        }

        //Main program
        static void Main(string[] args)
        {
            PutInPocket("Wallet");
            PutInPocket("Keys");
            PutInPocket("Tissue");
            TakeOutOfPocket("Keys");
            ShowPocket();
            Console.ReadLine();
        }
    }
}

