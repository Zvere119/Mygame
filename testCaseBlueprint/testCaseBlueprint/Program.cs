using System;
using System.Collections.Generic;
using System.Text;



namespace OhmsLaw
{
    class Program
    {
        static void Main()
        {

            Console.Write(" Choose a value: 1= Hardware 2= Firmware  3= Software  4= Desktop gui  5= cloud based gui app  6= Other function");

            Console.WriteLine("please enter a selection");
            string str = Console.ReadLine();
            
           
            int switchexp = int.Parse(str);

            switch (switchexp)
                    
            {
                    
                     
                case 1:

                    //double value;

                    //double a;
                    //double r;
                    //double v;
                    //Console.ForegroundColor = (ConsoleColor.Blue );
                   
                    Console.Write("GUIDELINE FOR HARDWARE.........................................................");
                    Console.Out.NewLine = "\r\n\r\n";
                    


                 
                    Console.WriteLine("The purpose of this guideline is to inform the tester on how to perform hardware testing.  ");
                    Console.WriteLine(" All hardware testing will include:    ");
                    Console.WriteLine(" Power     Temperature     Input to ouput performance   Noise    Esd      ");
                    Console.WriteLine("POWER: Check with a device to protect from any harm by using a variac for example which will test the current levels and indicate any problem.   ");
                    Console.WriteLine("Temperature: Use the thermatron and other devices providing heat  ");
                    Console.WriteLine("Input to output: Check for signal input to output performance injecting a signal level determine specs.  ) ");
                    Console.WriteLine("Noise: Check for noise levels from input to output, switching, popping or crackling, hiss etc. using an ap program. ");
                    Console.WriteLine("Esd: Perform esd and other static testing as well as EMI testing as needed.   ");


                   
                  

                    System.Threading.Thread.Sleep(50000);
                    break;

                case 2:


                    Console.Write("GUIDELINE FOR FIRMWARE..........................................................");
                    
                    Console.Out.NewLine = "\r\n\r\n";
                    Console.WriteLine("The purpose of this guideline is to inform the tester on how to perform Firmware testing.  ");
                    Console.WriteLine(" The following are just suggestions and do not need to br followed unless indicated.  ");
                    Console.WriteLine("If the painted and screened box is available check front and back screening for correct labels for each function.  ");
                    Console.WriteLine("1) *VERY IMPORTANT* Be sure to update firmware each time an update becaomes available.  ");
                    Console.WriteLine("2) Observe the box front panel  and locate all knobs displays and buttons.  ");

                    Console.WriteLine("3) Check all buttons and leds if they are present for brightness and propper color.  ");
                    Console.WriteLine("4) For each area with a menu, test all setting changes and characters while rotating knobs and encoders. ");
                    Console.WriteLine("5) Check the back of the box for correct labeling.  ");
                    Console.WriteLine("6) Observe all connections and prepare to check inputs and outputs as well a misc other connectors(i.e blulink, ethernet, ");
                    Console.WriteLine("7) When powering the box make sure to wait until something shows on the display. ");
                    Console.WriteLine("8) When a display is shown check all knobs for correct changes when rotating and be aware of encoder that push in.  ");
                    Console.WriteLine("9) Check all display characters using the following routine: left to right, top to bottom.  ");
                    Console.WriteLine("10) ");
                    System.Threading.Thread.Sleep(50000);
                    break;
                case 3:

                    Console.Write("GUIDELINE FOR SOFTWARE.........................................................."); ;
                    Console.Out.NewLine = "\r\n\r\n";
                 
                    Console.WriteLine("The purpose of this guideline is to inform the tester on how to perform software testing");
                    Console.WriteLine(" Software testing will involve testing files by deleting and replacing using a filezilla ftp.");
                    Console.WriteLine("Make a note of the files being used for software to be added and deleted from the box.) ");
                
                    System.Threading.Thread.Sleep(5000);
                    break;
                case 4:
                    Console.Write("GUIDELINE FOR DESKTOP GUI APP...................................................");
                    Console.Out.NewLine = "\r\n\r\n";
                    Console.WriteLine("The purpose of this guideline is to inform the tester on how to perform desktop gui app testing");
                    Console.WriteLine("When testing the desktop gui keep in mind that the gui should interact with the box and visa versa.");
                    Console.WriteLine("1) Check for propper sync to the box and continued syncing as gui is used.");
                    Console.WriteLine("2) Check all sections for changes to each field.  ");
                    Console.WriteLine("3) Check settings for each effect or menu for complete changes, check for wording differences.");
                    Console.WriteLine("4) Use the box to test for gui control from the box. They should mirror each other.  ");
                    System.Threading.Thread.Sleep(50000);
                    break;
                case 5:
                    Console.Write("GUIDELINE FOR CLOUD BASED GUI APP...............................................");
                    Console.Out.NewLine = "\r\n\r\n";
                    Console.WriteLine("The purpose of this guideline is to inform the tester on how to perform cloud based gui app testing");
                    Console.WriteLine("When testing the cloud based gui app keep in mind that the gui should interact with the box and visa versa.");
                    Console.WriteLine("1) Check for propper sync to the box and continued syncing as gui is used.");
                    Console.WriteLine("2) Check all sections for changes to each field.  ");
                    Console.WriteLine("3) Check settings for each effect or menu for complete changes, check for wording differences.");
                    Console.WriteLine("4) Use the box to test for gui control from the box. They should mirror each other.  ");
                    System.Threading.Thread.Sleep(50000);
                    break;
                case 6:
                    Console.Write("POINTERS FOR OTHER FUNCTION TESTING.........................................................");
                    Console.Out.NewLine = "\r\n\r\n";
                    Console.WriteLine("The purpose of this guideline is to inform the tester on how to perform other function testing");
                    Console.WriteLine(" Test other function such as blu link etc. for among others the following:  ");
                    Console.WriteLine("1) Continuity and consistency with connection.  ");
                    Console.WriteLine("2) Performance.  ");
                    Console.WriteLine("3) Noise issues, interference.  ");
                    Console.WriteLine("4) Correct transfer of data.  ");
                    System.Threading.Thread.Sleep(50000);
                    break;





            }


        }
    }
}

