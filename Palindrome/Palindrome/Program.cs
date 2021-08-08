using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            string reverse = "";
            Console.WriteLine("Please enter your text:");
            text = Console.ReadLine();
            for (int i = text.Length - 1; i >= 0; i--) //String Reverse  
            {
                reverse += text[i].ToString();
            }
            if (reverse == text) // Checking whether string is palindrome or not  
            {
                Console.WriteLine("Text is Palindrome \nEntered text was {0} and Reverse text is {1}", text, reverse);
            }
            else
            {
                Console.WriteLine("Text is not Palindrome \nEntered text was {0} and Reverse text is {1}", text, reverse);
            }
        }
    }
}
