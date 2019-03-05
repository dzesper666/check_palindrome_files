using System;
using System.IO;

namespace Kacper
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstNumber;

            string[] filesArray = Directory.GetFiles(@"C:\Users\ksarama\Documents\Projects\Kacper\files");

            foreach (string element in filesArray)
            {
                string firstLine = readLine(element, 0);

                int firstLineAsInt = convertFirstLineToInt(firstLine);

                bool comparedToZero = equalThanZero(firstLineAsInt);

                Console.WriteLine();
                Console.WriteLine(element.ToString());

                if (comparedToZero)
                {
                    string secondLineInt = readLine(element, 1);
                    firstNumber = convertSecondLine(secondLineInt);

                }
                else
                {
                    firstNumber = firstLineAsInt;
                }

                string secondLine = readLine(element, 1);

                string reversedLine = reverseLine(secondLine);

                if (reversedLine == secondLine)
                {
                    string[] resultYes = { "Yes" };
                    Console.WriteLine("Yes");

                    string fileExtension = ".out";
                    int elementLength = element.ToString().Length;
                    int elementLengthWithoutLastThreeCharacters = elementLength - 3;
                    string elementSplitedName = element.Substring(0, elementLengthWithoutLastThreeCharacters);
                    string file = String.Format("{0}{1}", elementSplitedName, fileExtension);
                    System.IO.File.WriteAllLines(@file, resultYes);
                }
                else
                {
                    string[] resultNo = { "No" };
                    Console.WriteLine("No");

                    string fileExtension = ".out";
                    int elementLength = element.ToString().Length;
                    int elementLengthWithoutLastThreeCharacters = elementLength - 3;
                    string elementSplitedName = element.Substring(0, elementLengthWithoutLastThreeCharacters);
                    string file = String.Format("{0}{1}", elementSplitedName, fileExtension);
                    System.IO.File.WriteAllLines(@file, resultNo);
                }

            }

            string readLine(string element, int number)
            {
                string[] lines = File.ReadAllLines(element);
                var firstLine = lines.GetValue(number).ToString();
                return firstLine;
            }

            int convertFirstLineToInt(string firstLine)
            {
                int stringConvertedToInt = Convert.ToInt16(firstLine);
                return stringConvertedToInt;
            }

            int convertSecondLine(string line)
            {
                char[] stringConvertedToArray = line.ToCharArray();
                return stringConvertedToArray.Length;
            }

            string reverseLine(string line)
            {
                char[] characters = line.ToCharArray();
                Array.Reverse(characters);
                string reversedLine = new String(characters);
                return reversedLine;
            }

            bool equalThanZero(int number)
            {
                if (number != 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
