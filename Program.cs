
using System;


namespace BuildASynth
{
    class Program
    {
        static void Main()
        {

            /*FakeVST or Build -A- Synth Modular V.1.0. T.Scott George. Main portfolio piece in CSharp.
             
             Building VST aka Vurtual Instrument in this case a Synthesizer.
             A user can pick different moduals for a modular Synth, Oscilators, reverbs, filters, etc.

             The choices can be stored in a text file.
             */
            string OCSs, FLTs, Revb, CHOR, DLY, DIST, CHSNM;



            

            //List of muduals available. Probably can be done with fewer linse of code. More work to be done on this.
            // Step one the Oscillators
            Console.WriteLine("Choose 1-5 OSCs: ");
            OCSs = Console.ReadLine();
            String Result = Console.ReadLine();


            int oscillators;

            bool isOscillatorsValid = false;
            while (!isOscillatorsValid)
            {
                OCSs = Console.ReadLine();
                if (!int.TryParse(OCSs, out oscillators))
                {
                    Console.WriteLine("Not a valid option, try again.");
                    continue;


                }
                if (oscillators >= 6)
                {
                    Console.WriteLine("Please choose fewer");
                    continue;
                }
                isOscillatorsValid = true;
            }


            /* Step two: Filter section. If you know synths you know that you dont have to choose the filter(s) first, these
            steps are only for example */
            Console.WriteLine("Choose Filters: Available: Lowpass, Highpass, Bandpass ");
            FLTs = Console.ReadLine();

         


        
            //Step three: reverbs

            Console.WriteLine("Choose a Reverb: Available: Hall, Short, Deep Space");
            Revb = Console.ReadLine();



            //Step four: Chorus
            Console.WriteLine("Choose a Chorus: Available:  Soft, double");
            CHOR = Console.ReadLine();


            //Step five: Deley

            Console.WriteLine("Choose a Delay: Available: Granular, Ping Pong  ");
            DLY = Console.ReadLine();

            //Step six: Distortion
            Console.WriteLine("Choose a Distortion: Available: Fuzztone, Wavefolding ");
            DIST = Console.ReadLine();



            //Step seven: choose a name for your Synth
            Console.WriteLine("Please choose a name for your new Synth!: ");
            CHSNM = Console.ReadLine();


            Console.WriteLine("Thanks! Your new synth is ready to buy! Please depost $2.2MILLION DOLLARS!");

          
            Console.WriteLine($"Your Synth has the following features:\nOCS: {OCSs}\nFLTs: {FLTs}\nRevb {Revb}\nCHOR: {CHOR}\nDLY: {DLY}\nDIST: {DIST}\nCHSNM: {CHSNM}");

            Console.ReadLine();
        }
    }
}