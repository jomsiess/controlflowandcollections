using System;
using System.Collections.Generic; 

namespace controlflowandcollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            //char[] charactersInString = text.ToCharArray();

            Dictionary<char, int> textNumbers = new Dictionary<char, int>(); 

            foreach (char i in text.ToCharArray())
            {
                if (char.IsLetter(i))
                {
                    if (textNumbers.ContainsKey(i))
                    {
                        textNumbers[i]++;
                    }
                    else
                    {
                        textNumbers.Add(i, 1);
                    }
                }

            }

            foreach (KeyValuePair<char, int> funStuff in textNumbers)
            {
                Console.WriteLine("Key = {0}, Value = {1}", funStuff.Key, funStuff.Value);
            }

        }

    }
}
