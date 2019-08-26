using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairCostCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press E for exit\nPress A for about");
            ConsoleKeyInfo k;           
            k=Console.ReadKey();
              while (k.Key!=ConsoleKey.E & k.Key!=ConsoleKey.A)                
                    {Console.Clear();
                     Console.WriteLine("Press E for exit\nPress A for about");
                     k=Console.ReadKey();                     
                    }  
              if(k.Key==ConsoleKey.A)  
                                     {
                                      Console.Clear();
                                      Console.WriteLine("Project RepairCostCalculator version 1.0.0.0\nPress any key to return ...");
                                      Console.ReadLine();
                                      }
               else
                   Console.WriteLine();       
        }
    }
}

         
        
    
             
             
      
