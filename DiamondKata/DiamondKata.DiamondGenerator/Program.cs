using System;

namespace DiamondKata.DiamondGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {

            DiamondGenerator diamondGenerator = new DiamondGenerator();
            char[] optionalLetter = diamondGenerator.GetAlphabet();

            Console.WriteLine(" --------------------- ");
            Console.WriteLine(" Please choose letter from these to create a diamond: (Use uppercase)");
            foreach (var letter in optionalLetter)
            {
                Console.Write(" " + letter + ", ");
            }
            Console.WriteLine("\n  -------------------- ");

            //Add input letter
            char inputFromUser = Console.ReadKey().KeyChar;
            Console.WriteLine(" ");

            //Generate diamond
            int numberOfLetter = diamondGenerator.Search_LetterInArray(inputFromUser);
            diamondGenerator.GenerateHalfDiamond(numberOfLetter);
            diamondGenerator.GenerateReverseDiamond(numberOfLetter);

            Console.ReadKey();
        }

    }
}
