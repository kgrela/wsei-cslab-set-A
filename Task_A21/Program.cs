using System;

namespace Task_A21
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPalindrom = true;

            Console.WriteLine("Enter a word: ");
            string str = Console.ReadLine();

            str = str.ToLower();
            char[] tab = str.ToCharArray();
            char[] reversedTab = new char[str.Length];
            Array.Copy(tab, reversedTab, str.Length);
            Array.Reverse(reversedTab);

            /*

            Console.WriteLine("tab: ");
            for(int i=0;i<tab.Length;i++)
            {
                Console.Write(tab[i]);
            }

            Console.WriteLine("reversedTab: ");
            for (int i = 0; i < reversedTab.Length; i++)
            {
                Console.Write(reversedTab[i]);
            }

            */
            
            for(int i=0;i<tab.Length;i++)
            {
                if(tab[i] != reversedTab[i])
                {
                    isPalindrom = false;
                    break;
                }
            }

            Console.WriteLine(isPalindrom);
        }
    }
}
