using System;
using System.Collections.Generic;
using System.Text;



namespace OhmsLaw
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.White;

            DateTime.Now.ToString();
            Console.Write(DateTime.Now);



            Console.Write("  ****************************************************************************************************************************************");









            Console.Write("  Choose a number: 1= HARDWARE 2= FIRMWARE  3= SOFTWARE  4= DESKTOP GUI  5= CLOUD BASED GUI APP  6= OTHER FUNCTION");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine(" .............................................. Please enter a selection below:");
            string str = Console.ReadLine();
            Console.CursorTop = 18;
            Console.WindowWidth = 120;


            // Begins the new space dedicated to new trial code  additions
            // Begins the new space dedicated to new trial code  additions





















            // Marks the End of area for new trial code additions
            // Marks the End of area for new trial code additions
            
            int switchexp = int.Parse(str);

            switch (switchexp)
            {


                case 1:

                    //double value;

                    //double a;
                    //double r;
                    //double v;
                    //Console.ForegroundColor = (ConsoleColor.Blue );
                    Console.ForegroundColor = ConsoleColor.White;


                    Console.Write("GUIDELINE FOR HARDWARE.......................................................");
                    Console.Out.NewLine = "\r\n\r\n";




                    Console.WriteLine(" The purpose of this guideline is to inform the tester on how to begin hardware testing.  ");
                    Console.WriteLine(" All hardware testing will include:    ");
                    Console.WriteLine(" POWER  -   INPUT TO OUTPUT PERFORMANCE  -  NOISE  -  ESD  -  TEMPERATURE      ");
                    Console.WriteLine(" POWER: Check with a device to protect from harm by using a variac for example which tests the current levels and can   indicate a problem before damaging anything.   ");
                    Console.WriteLine(" INPUT TO OUTPUT: Check for signal input to output performance injecting a signal and measuring results, determining    specs.   ");
                    Console.WriteLine(" NOISE: Check for noise levels from input to output, switching, popping or crackling, hiss etc. use ap for testing. ");
                    Console.WriteLine(" ESD: Perform esd and other static testing as well as EMI testing as needed.   ");
                    Console.WriteLine(" TEMPERATURE: Use the thermatron and other devices applying heat to the board or box testing for long term function.  ");
                    Console.Read();






                    break;

                case 2:

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("GUIDELINE FOR FIRMWARE..........................................................");

                    Console.Out.NewLine = "\r\n\r\n";
                    Console.WriteLine("The purpose of this guideline is to     inform the tester on how to begin Firmware testing.  ");
                    Console.WriteLine(" The following are just suggestions and do not need to be followed unless indicated.  ");
                    Console.WriteLine("If the painted and screened box is available check front and back screening for correct labels for each function.  ");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("1) Observe the box front panel and locate all knobs displays and buttons.  ");
                    Console.WriteLine("2) Press buttons and turn knobs while looking for visible setting changes and lit leds. ");

                    Console.WriteLine("3) When checking buttons some buttons have leds and leds should have correct brightness and color.  ");
                    Console.WriteLine("4) For each area with a menu, test all setting changes and characters while rotating knobs and encoders. ");
                    Console.WriteLine("5) Check the back side of the box for correct labeling.  ");
                    Console.WriteLine("6) Observe all connections on the back and prepare to check input and output connectors as well as misc other connectors  i.e blulink, ethernet etc.");
                    Console.WriteLine("7) When powering the box make sure to wait until something shows on the display. ");
                    Console.WriteLine("8) When a display is shown check all knobs for correct changes when rotating and be aware of encoders that push in.  ");
                    Console.WriteLine("9) Check all display characters using the following routine: left to right, top to bottom.  ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("10) *VERY IMPORTANT* BE SURE TO UPDATE THE FIRMWARE EACH TIME AN UPDATE BECOMES AVAILABLE. ");
                    //Console.WriteLine("10) ");

                    Console.Read();
                    break;


                case 3:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("GUIDELINE FOR SOFTWARE..............................................................");
                    Console.Out.NewLine = "\r\n\r\n";

                    Console.WriteLine("The purpose of this guideline is to inform the tester on how to begin software testing");
                    Console.WriteLine("1) Software testing will involve testing files by deleting and replacing files using a Filezilla type ftp.");
                    Console.WriteLine("2) Check the box menus to verify that the files being used for software can be added to and deleted from the box. ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" *VERY IMPORTANT* BE SURE TO UPDATE THE APP SOFTWARE EACH TIME AN UPDATE BECOMES AVAILABLE. ");


                    Console.Read();
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("GUIDELINE FOR DESKTOP GUI APP.......................................................");
                    Console.Out.NewLine = "\r\n\r\n";
                    Console.WriteLine("The purpose of this guideline is to inform the tester on how to begin desktop gui app testing");
                    Console.WriteLine("When testing the desktop gui keep in mind that the gui should interact with the box and vice versa.");
                    Console.WriteLine("1) Check for proper sync to the box and continued syncing as gui is used.");
                    Console.WriteLine("2) Make a note of all sections and how to navigate to each field.  ");
                    Console.WriteLine("3) Check settings for each field or menu for complete setting changes, check for correct spelling.");
                    Console.WriteLine("4) Use the box to test for gui control from the box. The box and gui should mirror each other.  ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("5) *VERY IMPORTANT* BE SURE TO UPDATE THE APP SOFTWARE EACH TIME AN UPDATE BECOMES AVAILABLE. ");
                    Console.Read();
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("GUIDELINE FOR CLOUD BASED GUI APP...................................................");
                    Console.Out.NewLine = "\r\n\r\n";
                    Console.WriteLine("The purpose of this guideline is to inform the tester on how to begin cloud based gui app testing");
                    Console.WriteLine("When testing the cloud based gui app keep in mind that the gui should interact with the box and vice versa.");
                    Console.WriteLine("1) Check for proper sync to the box and continued syncing as gui is used.");
                    Console.WriteLine("2) Make a note of all sections and how to navigate to each field.  ");
                    Console.WriteLine("3) Check settings for each field or menu for complete setting changes, check for correct spelling.");
                    Console.WriteLine("4) Use the box to test for gui control from the box. The box and gui should mirror each other.  ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("5) *VERY IMPORTANT* BE SURE TO UPDATE THE APP SOFTWARE EACH TIME AN UPDATE BECOMES AVAILABLE. ");
                    Console.Read();
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("POINTERS FOR OTHER FUNCTION TESTING.................................................");
                    Console.Out.NewLine = "\r\n\r\n";
                    Console.WriteLine("The purpose of this guideline is to inform the tester on how to begin other function testing");
                    Console.WriteLine(" Test other function such as blu link etc. for among others the following:  ");
                    Console.WriteLine("1) Continuity and consistency with connection.  ");
                    Console.WriteLine("2) Performance.  ");
                    Console.WriteLine("3) Noise issues, interference.  ");
                    Console.WriteLine("4) Correct transfer of data.  ");
                    Console.Read();
                    break;





            }


        }
    }
}
    


