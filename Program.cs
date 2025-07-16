/*
Write a C# Sharp program to find the largest of three numbers.

Test Data :
    Input the 1st number :25
    Input the 2nd number :63
    Input the 3rd number :10

Expected Output :
    The 2nd Number is the greatest among three

Credit Extra:
    Make it work for 'n' elements.
    Add Ordinal suffixes.
 */

namespace Assignment_2._4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int elementsInArray = 0;

            Console.Write("Input the number of elements to be stored in the array: ");
            while (true)
            {
                if (!int.TryParse(Console.ReadLine().Trim(), out elementsInArray))
                {
                    Console.Write("Please enter an integer for how many elements should be stored in the array: ");
                }
                break;
            }

            decimal[] decimalArray = new decimal[elementsInArray];

            int maxIndex = 0;
            for (int i = 0; i < decimalArray.Length; i++)
            {
                decimalArray[i] = UserInput(i);

                if (decimalArray[i] > decimalArray[maxIndex])
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine($"The {OrdinalSuffix(maxIndex + 1)} number was the highest ({decimalArray[maxIndex]})");
        }


        static decimal UserInput(int currentArrayElement)
        {
            decimal userDefinedArrayElement = 0;

            Console.Write($"Enter {OrdinalSuffix(currentArrayElement+1)} number: ");

            while (true)
            {
                if (decimal.TryParse(Console.ReadLine().Trim(), out userDefinedArrayElement))
                {
                    return userDefinedArrayElement;

                }
                else
                {
                    Console.Write($"Please enter an valid number for number {currentArrayElement+1}: ");
                }
            }
        }

        static string OrdinalSuffix(int elementNumber)
        {
            if (elementNumber == 11 || elementNumber == 12 || elementNumber == 13)
            {
                return elementNumber+"th";
            }
            else
            {
                switch (elementNumber % 10)
                {
                    case 1:
                        return elementNumber+"st";
                    case 2:
                        return elementNumber + "nd";
                    case 3:
                        return elementNumber + "rd";
                    default:
                        return elementNumber + "th";
                }
            }
        }
    }
}
