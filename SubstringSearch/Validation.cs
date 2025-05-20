using System;

public class Validation
{
    /// <summary>
    /// check all the validations...
    /// </summary>
    /// <param name="inputString">the main string to search validation.</param>
    /// <returns>Return true or false based on condition.   </returns>
    public bool CheckValidation(string inputString)
    {
        bool isValid = true;
        string symbols = "";
        bool hasNumber = false;
        bool hasSymbol = false;

        foreach (char c in inputString)
        {
            if (!((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z')))
            {
                isValid = false;

                if (c >= '0' && c <= '9')  
                {
                    hasNumber = true;
                }
                else
                {
                    hasSymbol = true;
                    symbols += c + " ";
                }
            }
        }

        if (!isValid)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Input string is not valid... Please enter a valid string which contains letters only.");
            Console.ResetColor();

            if (hasNumber)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("It contains number(s).");
                Console.ResetColor();
            }

            if (hasSymbol)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("It contains special symbol(s): " + symbols.Trim());
                Console.ResetColor();
            }

            return false;
        }

        return true;
    }
}
