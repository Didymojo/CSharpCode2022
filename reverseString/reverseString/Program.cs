using System;

namespace ReverseString

{
    internal class Program
    {
        static void Main(string[] args)
        {
            String sentence = "Hello World!";
            String reversedSentence = reverseContent(sentence);
            Console.WriteLine("Backwards Hello World: " + reversedSentence);
             
        }

        private static string reverseContent(string sentence)
        {
            String reversed = " ";

            //i = how many times the loop will run; keep running it until counting variable is >=0; -- run backwards in increments of 1
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                //+= adds/concatenates whatever is at position i onto the reversed string 
                reversed += sentence[i];
            }

             return reversed;
            

        }
    }
}