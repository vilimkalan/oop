using LV5.interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LV5.classes2
{
    internal class DataConsolePrinter
    {
        public void Display(IDataset dataset)
        {
            var podaci = dataset.GetData();
            if (podaci != null)
            {
                foreach (List<string> redak in podaci)
                {
                    Console.WriteLine(string.Join(" | ", redak));
                }
            }
            else
            {
                Console.WriteLine("Pristup odbijen: Podaci su null.");
            }
        }
    }
}
