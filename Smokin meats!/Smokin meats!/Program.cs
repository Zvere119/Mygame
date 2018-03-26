using System;
using System.Collections.Generic;
using System.Text;

namespace Smokinmeats
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine(" Choose a meat: 1=Beef  2=Pork  3= Chicken/Turkey ");
            Console.Write("please enter a selection");
            string str = Console.ReadLine();
            int switchexp = int.Parse(str);

            switch (switchexp)
            {
                case 1:

                    double value;

                    double a;
                   

                    Console.WriteLine(" Enter weight");
                    a = Convert.ToDouble(Console.ReadLine());
                    value = a * 1.5;
                    Console.WriteLine(" Your cooking time is- {0} hours.", value);
                    Console.WriteLine(" Your cooking temperature is 225 degrees.");
                    Console.WriteLine(" Internal meat temperature should be 170 degrees.");
                    Console.WriteLine(" Woods to use: Hickory, Mesquite,Oak, Cherry.");

                    System.Threading.Thread.Sleep(10000);
                    break;

                case 2:

                    Console.WriteLine(" Enter weight");
                    a = Convert.ToDouble(Console.ReadLine());
                    value = a * 1.5;
                    Console.WriteLine(" Your cooking time is- {0} hours.", value);
                    Console.WriteLine(" Your cooking temperature is 225 degrees.");
                    Console.WriteLine(" Internal meat temperature should be 165 degrees.");
                    Console.WriteLine(" Woods to use: Hickory,Apple(most other fruit woods),Grapevines,Alder.");

                    System.Threading.Thread.Sleep(10000);
                    break;
                case 3:

                    Console.WriteLine(" Enter weight");
                    a = Convert.ToDouble(Console.ReadLine());
                    value = a * .50;
                    Console.WriteLine(" Your cooking time is- {0} hours.", value);
                    Console.WriteLine(" Your cooking temperature is 250 degrees.");
                    Console.WriteLine(" Internal meat temperature should be 165 degrees.");
                    Console.WriteLine(" Woods to use: Hickory,Apple(most other fruit woods),Grapevines,Alder.");
                    System.Threading.Thread.Sleep(10000);
                    break;
            }


        }
    }
}
