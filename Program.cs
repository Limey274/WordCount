using System;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Congue nisi vitae suscipit tellus mauris. Elementum pulvinar etiam non quam lacus. Ultrices dui sapien eget mi proin. Odio aenean sed adipiscing diam donec adipiscing tristique risus nec.";
            
            Console.WriteLine("This is what we start with: " + str);
            while (str.Length > 0)
            {
                Console.Write(str[0] + " = ");
                int count = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[0] == str[i])
                    {
                        count++;
                    }
                }
                Console.WriteLine(count);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            
        }
    }
}
