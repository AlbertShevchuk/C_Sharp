using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace plotGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keys = new string[46];
            string protagonistSex;
            string secondaryCharacterSex;

            Console.WriteLine("          ~~~Welcome to Albert's Story Generator~~~\n");
            Console.WriteLine("INSTRUCTIONS:");
            Console.WriteLine("             Type out every answer for the following 45 questions!");
            Console.WriteLine("             Hit the spacebar to get started.");
            Console.ReadKey();


            Console.WriteLine("\n\n\nYour protagonist First Name? ");
            keys[1] = Console.ReadLine();

            Console.WriteLine("\nYour protagonist Last Name? ");
            keys[2] = Console.ReadLine();

            Console.WriteLine("\nWhat Gender is " + keys[1] + " " + keys[2] + "?");
            protagonistSex = Console.ReadLine();
            protagonistSex = protagonistSex.ToLower();

            Console.WriteLine("\nYour secondary character First Name?");
            keys[3] = Console.ReadLine();

            Console.WriteLine("\nYour secondary character Last Name?");
            keys[4] = Console.ReadLine();

            Console.WriteLine("\nWhat Gender is " + keys[3] + " " + keys[4] + "?");
            secondaryCharacterSex = Console.ReadLine();
            secondaryCharacterSex = secondaryCharacterSex.ToLower();

            //Test toLower

            Console.WriteLine(secondaryCharacterSex + " " + protagonistSex);

            Console.WriteLine("\nWhat does the second character want from the protagonist? (e.g. closure, revenge, a hug)");
            keys[5] = Console.ReadLine();

            Console.WriteLine("/nSomething the protagonist would like to say to the second character? (e.g.I love you, I am your father)");
            keys[6] = Console.ReadLine();

            Console.WriteLine("\nThe name of the place where it all happens?");
            keys[7] = Console.ReadLine();

            Console.WriteLine("\nA feature of the place? (e.g. trees, houses, rivers)");
            keys[8] = Console.ReadLine();

            Console.WriteLine("\nFirst adjective that could be used to describe that place?");
            keys[9] = Console.ReadLine();

            Console.WriteLine("\nSecond adjective that could be used to describe that place?");
            keys[10] = Console.ReadLine();

            Console.WriteLine("\nFirst emotion adjective? (e.g. happy, sad, grumpy)");
            keys[11] = Console.ReadLine();

            Console.WriteLine("\nSecond emotion adjective? (e.g. happy, sad, grumpy)");
            keys[12] = Console.ReadLine();

            Console.WriteLine("\nThird emotion adjective? (e.g. happy, sad, grumpy)");
            keys[13] = Console.ReadLine();

            Console.WriteLine("\nForth emotion adjective? (e.g. happy, sad, grumpy)");
            keys[14] = Console.ReadLine();

            Console.WriteLine("\nAn adjective that could describe an object");
            keys[15] = Console.ReadLine();

            Console.WriteLine("\nFirst adjective to describe somebody's character?");
            keys[16] = Console.ReadLine();

            Console.WriteLine("\nSecond adjective to describe somebody's character?");
            keys[17] = Console.ReadLine();

            Console.WriteLine("\nThird adjective to describe somebody's character?");
            keys[18] = Console.ReadLine();

            Console.WriteLine("\nForth adjective to describe somebody's character?");
            keys[19] = Console.ReadLine();

            Console.WriteLine("\nFith adjective to describe somebody's character?");
            keys[20] = Console.ReadLine();

            Console.WriteLine("\nSixth adjective to describe somebody's character?");
            keys[21] = Console.ReadLine();

            Console.WriteLine("\nAn occasion? (e.g. party, holiday, funeral)");
            keys[22] = Console.ReadLine();

            Console.WriteLine("\nFirst verb? (e.g. running, rampaging, loving)");
            keys[23] = Console.ReadLine();

            Console.WriteLine("\nSecond verb? (e.g. running, rampaging, loving)");
            keys[24] = Console.ReadLine();

            Console.WriteLine("\nThird verb? (e.g. running, rampaging, loving)");
            keys[25] = Console.ReadLine();

            Console.WriteLine("\nSomething/somebody vulnerable, singular? (e.g. old lady, baby bird, toddler)");
            keys[26] = Console.ReadLine();

            Console.WriteLine("\nA noun you might compare the main character to? (e.g. angel, giant, saint)");
            keys[27] = Console.ReadLine();

            Console.WriteLine("\nA noun you might compare the other character to? (e.g. brute, monster, coward)");
            keys[28] = Console.ReadLine();

            Console.WriteLine("\nA type of music? (e.g. reggae, jazz, piano)");
            keys[29] = Console.ReadLine();

            Console.WriteLine("\nThe protagonist's favourite drink, singular? (e.g. tea, port, beer)");
            keys[30] = Console.ReadLine();

            Console.WriteLine("\nAn object?");
            keys[31] = Console.ReadLine();

            Console.WriteLine("\nAnother object?");
            keys[32] = Console.ReadLine();

            Console.WriteLine("\nCurrency, plural? (e.g. pounds, dollar, euros)");
            keys[33] = Console.ReadLine();

            Console.WriteLine("\nA noun to do with the weather? (e.g. rain, snow, sun)");
            keys[34] = Console.ReadLine();

            Console.WriteLine("\nFirst animal, plural? (e.g. dogs, cats, kangaroos)");
            keys[35] = Console.ReadLine();

            Console.WriteLine("\nSecond animal, plural? (e.g. dogs, cats, kangaroos)");
            keys[36] = Console.ReadLine();

            Console.WriteLine("\nThird animal, plural? (e.g. dogs, cats, kangaroos)");
            keys[37] = Console.ReadLine();

            Console.WriteLine("\nA body part, plural? (e.g. legs, arms, hair)");
            keys[38] = Console.ReadLine();

            Console.WriteLine("\nAnother body part, plural? (e.g. legs, arms, hair)");
            keys[39] = Console.ReadLine();

            Console.WriteLine("\nFirst adjective to describe physical characteristics? (e.g. big, skinny, ginger)");
            keys[40] = Console.ReadLine();

            Console.WriteLine("\nSecond adjective to describe physical characteristics? (e.g. big, skinny, ginger)");
            keys[41] = Console.ReadLine();

            Console.WriteLine("\nThird adjective to describe physical characteristics? (e.g. big, skinny, ginger)");
            keys[42] = Console.ReadLine();

            Console.WriteLine("\nForth adjective to describe physical characteristics? (e.g. big, skinny, ginger)");
            keys[43] = Console.ReadLine();

            Console.WriteLine("And finally, what's your pen name?");
            keys[44] = Console.ReadLine();


            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n" + keys[16] + " " + keys[1] + " " + keys[2]);
            Console.WriteLine("A Short Story");
            Console.WriteLine("by " + keys[44]);

            Console.WriteLine("\n" + keys[1] + " " + keys[2] + " had always loved " + keys[9] + " " + keys[7] + " with its raspy, fast " + keys[8] + ". It was a place where " + (protagonistSex == "male" ? "he " : "she ") + "felt " + keys[11] + ".");



        }
    }
}
