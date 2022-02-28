using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondKata.DiamondGenerator
{
    public class DiamondGenerator
    {
        string[] diamond = new string[100];
        int numberOfLetter = 0;
        public char[] GetAlphabet()
        {
            char[] alphabet = new char[26]
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z'
            };
            return alphabet;
        }
        public bool IsValidLetter(char input)
        {
            if (GetAlphabet().Contains(input))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        public int Search_LetterInArray(char _inputFromUser)
        {
            char[] alphabet = GetAlphabet();
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == _inputFromUser)
                {
                    numberOfLetter = i;
                    break;
                }
            }
            return numberOfLetter;
        }
        public string GenerateHalfDiamond(int _numberOfLetter)
        {
            string result = "";
            char[] alphabet = GetAlphabet();
            for (int i = 0; i <= _numberOfLetter; i++)
            {
                for (int j = 0; j < _numberOfLetter - i; j++)
                {
                    diamond[i] += " ";
                }
                diamond[i] += alphabet[i];
                if (alphabet[i] != 'A')
                {
                    for (int j = 0; j < 2 * i - 1; j++)
                    {
                        diamond[i] += " ";
                    }
                    diamond[i] += alphabet[i];
                }
                Console.WriteLine(diamond[i]);
                result += diamond[i];
            }
            return result;
        }
        public void GenerateReverseDiamond(int _numberOfLetter)
        {
            for (int i = _numberOfLetter - 1; i >= 0; i--)
            {
                Console.WriteLine(diamond[i]);
            }
        }
    }
}