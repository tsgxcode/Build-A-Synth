using System;
using System.IO;

namespace BuildASynth
{
    class Program
    {
        static void Main(string[] args)
        {

            /*FakeVST or Build -A- Synth Modular V.1.0. T.Scott George. Main portfolio piece in CSharp.
             
             Building VST aka Vurtual Instrument in this case a Synthesizer.
             A user can pick different moduals for a modular Synth, Oscilators, reverbs, filters, etc.
             The choices can be stored in a text file.
             */
            string OCSs, FLTs, CHOR, DLY, CHSNM;

            //List of muduals available. Probably can be done with fewer linse of code. More work to be done on this.
            // Step one the Oscillators
            Console.WriteLine("Choose 1-5 OSCs: ");
            OCSs = Console.ReadLine();
           
            bool isOscillatorsValid = false;
            while (!isOscillatorsValid)

            {
               
                if (!int.TryParse(OCSs, out int oscillators))

                {
                    Console.WriteLine("Not a valid option, try again.");
                    continue;
                }
                if (oscillators > 5) 
                {
                    Console.WriteLine("Please choose fewer");
                    continue;
                }

                else if (oscillators < 0)
                {
                    Console.WriteLine("Please choose one or more");
                    continue;
                }
                
                isOscillatorsValid = true;
                {
                    break;
                }
            }

          
            


            /* Step two: Filter section. If you know synths you know that you dont have to choose the filter(s) first, these
            steps are only for example */
            Console.WriteLine("Choose Filters: Available types are: Lowpass, Highpass, Bandpass ");
            FLTs = Console.ReadLine();

            //Step three: Chorus
            Console.WriteLine("Pick a Chorus: Available:  Soft, double");
            CHOR = Console.ReadLine();

            //Step four: Deley
            Console.WriteLine("Pick a Delay: Available: Granular, Ping Pong  ");
            DLY = Console.ReadLine();

            //Step five: choose a name for your Synth
            Console.WriteLine("Please choose a name for your new Synth!: ");
            CHSNM = Console.ReadLine();


            Console.WriteLine("Thanks! Your new synth is ready to buy! Please depost $2.2MILLION DOLLARS!");

            //This line was shortend to one line from multiple lines, mostly from memory and what seemed to make sense. This is to simply document my progress in memorizing.
            Console.WriteLine($"Your Synth has the following features:\nOCS: {OCSs}\nFLTs: {FLTs}\nCHOR  {CHOR}\nDLY: {DLY}\nCHSNM: {CHSNM}");

         
        }
    }
}