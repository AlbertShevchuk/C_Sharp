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
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 10000);

            Console.WriteLine("          ~~~Welcome to Albert's Story Generator~~~\n");
            Console.WriteLine("INSTRUCTIONS:");
            Console.WriteLine("             Type out every answer for the following 46 questions!");
            Console.WriteLine("             Hit the spacebar to get started.");
            Console.ReadKey();


            Console.WriteLine("\n\n\nYour protagonist (main character) First Name? ");
            keys[1] = Console.ReadLine();

            Console.WriteLine("\nYour protagonist Last Name? ");
            keys[2] = Console.ReadLine();

            Console.WriteLine("\nWhat Gender is " + keys[1] + " " + keys[2] + "?" + " (male, female)");
            protagonistSex = Console.ReadLine();
            protagonistSex = protagonistSex.ToLower();

            Console.WriteLine("\nYour secondary character First Name?");
            keys[3] = Console.ReadLine();

            Console.WriteLine("\nYour secondary character Last Name?");
            keys[4] = Console.ReadLine();

            Console.WriteLine("\nWhat Gender is " + keys[3] + " " + keys[4] + "?" + " (male, female)");
            secondaryCharacterSex = Console.ReadLine();
            secondaryCharacterSex = secondaryCharacterSex.ToLower();

            Console.WriteLine("\nWhat does the second character want from the protagonist? (e.g. closure, revenge, a hug)");
            keys[5] = Console.ReadLine();

            Console.WriteLine("\nSomething the protagonist would like to say to the second character? (e.g.I love you, I am your father)");
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

            Console.WriteLine("\nAnd finally, what's your pen name?");
            keys[44] = Console.ReadLine();


            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n" + keys[16] + " " + keys[1] + " " + keys[2]);
            Console.WriteLine("A Short Story");
            Console.WriteLine("by " + keys[44]);

            Console.WriteLine("\n" + keys[1] + " " + keys[2] + " had always loved " + keys[9] + " " + keys[7] + " with its raspy, fast " + keys[8] + ". It was a place where " + (protagonistSex == "male" ? "he " : "she ") + "felt " + keys[11] + ".");

            Console.WriteLine("\n" + (protagonistSex == "male" ? "He " : "She ") + " was a " + keys[16] + ", " + keys[17] + ", " + keys[30] + " drinker with " + keys[40] + " " + keys[38] + " and " + keys[41] + " " + keys[39] + ". " + (protagonistSex == "male" ? "His " : "Her ") + "friends saw " + (protagonistSex == "male" ? "him " : "her ") + "as an embarrassed, raw " + keys[27] + ". Once, " + (protagonistSex == "male" ? "he " : "she ") + "had even helped a spotless " + keys[26] + " recover from a flying accident. That's the sort of " + (protagonistSex == "male" ? "man he " : "woman she ") + "was.");

            Console.WriteLine("\n" + keys[1] + " walked over to the window and reflected on " + (protagonistSex == "male" ? "his " : "her ") + keys[10] + " surroundings. The " + keys[34] + " teased like " + keys[23] + " " + keys[35] + ".");

            Console.WriteLine("\n" + "Then " + (protagonistSex == "male" ? "he " : "she ") + "saw something in the distance, or rather someone. It was the figure of " + keys[3] + " " + keys[4] + ". " + keys[3] + " was a " + keys[19] + " " + keys[28] + " with " + keys[43] + " " + keys[38] + " and " + keys[42] + " " + keys[39] + ".");

            Console.WriteLine("\n" + keys[1] + " gulped. " + (protagonistSex == "male" ? "He " : "She ") + "was not prepared for " + keys[3] + ".");

            Console.WriteLine("\n" + "As " + keys[1] + " stepped outside and " + keys[3] + " came closer, " + (protagonistSex == "male" ? "he " : "she ") + "could see the bad smile on " + (secondaryCharacterSex == "male" ? "his " : "her ") + "face.");

            Console.WriteLine("             ~~~Hit the spacebar to continue reading~~~");
            Console.ReadKey();

            Console.WriteLine("\n" + keys[3] + " gazed with the affection of " + randomNumber + " " + keys[18] + " confused " + keys[37] + ". " + (secondaryCharacterSex == "male" ? "He " : "She ") + "said, in hushed tones, 'I love you and I want " + keys[5] + "'.");

            Console.WriteLine("\n" + keys[1] + " looked back, even more " + keys[14] + " and still fingering the " + keys[15] + " " + keys[31] + "." + "'" + keys[3] + ", " + keys[6] + ",' " + (protagonistSex == "male" ? "he " : "she ") + " replied.");

            Console.WriteLine("\n" + "They looked at each other with " + keys[12] + " feelings, like two envious, tight " + keys[36] + " " + keys[24] + " at a very " + keys[20] + " " + keys[22] + ", which had " + keys[29] + " music playing in the background and two " + keys[21] + " uncles " + keys[25] + " to the beat.");

            Console.WriteLine("\n" + keys[1] + " regarded " + keys[3] + "'s " + keys[43] + " " + keys[38] + " and " + keys[42] + " " + keys[39] + ". 'I feel the same way!' revealed " + keys[1] + " with a delighted grin.");

            Console.WriteLine("\n" + keys[3] + " looked " + keys[13] + ", her emotions blushing like a vast, stormy " + keys[32] + ".");

            Console.WriteLine("\n" + "Then " + keys[3] + " came inside for a nice drink of " + keys[30] + ".");

            Console.WriteLine("\nTHE END");

            Console.ReadKey();
            Console.ReadKey();
        }
    }
}