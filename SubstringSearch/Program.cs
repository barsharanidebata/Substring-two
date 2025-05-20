using System;

namespace SubStringSearch
{
    class Program
    {      
        static void Main()
        {
            Console.WriteLine("Give input1: ");
            string str = Console.ReadLine();

            Console.WriteLine("Give input2 (sub-string): ");
            string substr = Console.ReadLine();

            StringSearcher obj = new StringSearcher();
            Validation val = new Validation();

            if (!val.CheckValidation(str))
            {
                return;
            }
            obj.FindSubstrings(str, substr);
        }
    }
}