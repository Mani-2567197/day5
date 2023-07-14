using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Al
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al=new ArrayList();
            var item="";
            Console.WriteLine("Enter the nuber to insert how many values into list");
            int l1=int.Parse(Console.ReadLine());
            Console.WriteLine("=====================================================");
            Console.WriteLine("Enter the values to insert into list");
            for (int i=0; i<l1; i++)
            {
               item=Console.ReadLine();
               al.Add(item);  
            }
            Console.WriteLine("Total no.of Elements in the ArrayList:\t"+al.Count);
            Console.WriteLine("****************************************");
            Console.WriteLine("To perform insert,remove or search");
            string opt = Console.ReadLine();
            int index = al.IndexOf(opt);
            if (index == -1)
            {
                     Console.WriteLine($" item {opt} is not found in the list");
                     Console.WriteLine("Do you wanna insert into the list if yes press y otherwise press any key");
                     string conf = Console.ReadLine();
                   if (conf == "y")
                   {
                    al.Add(opt);
                   }
            }
            else
            {
                    Console.WriteLine(opt + " is in the list");
                    Console.WriteLine("Do you wanna delete if yes press y otherwise press any key");
                    string conf = Console.ReadLine();
                   if(conf=="y")
                   {
                        al.Remove(opt);
                   }
            }
            Console.WriteLine("*******Items in the Array List:");
            foreach(var i in al)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}





            
