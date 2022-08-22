using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static bool? Check(string str)
        {
            Dictionary<char, char> sk = new Dictionary<char, char>
            {
                {'(',')'},
                {'{','}'},
                {'[',']'},
            };
            bool cont = false;
            Stack<char> stack = new Stack<char>();
            foreach (char c in str)
            {
                if (sk.ContainsKey(c))
                {
                    stack.Push(sk[c]);
                    cont = true;
                }
                if (sk.ContainsValue(c))
                {
                    if (stack.Count == 0 || stack.Pop()!=c)
                    {
                        return false;
                    }
                    cont = true;
                }
            }
            if (stack.Count == 0 && cont)
                return true;
            else if (cont)
                return false;
            else
                return null;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();
            if (Check(str) == true)
            {
                Console.WriteLine("Скобки расставлены верно!");
            }
            else if (Check(str) == false)
            {
                Console.WriteLine("Скобки расставлены неверно!");
            }
            else
            {
                Console.WriteLine("Скобки отсутствуют в строке!");
            }
            Console.ReadKey();
        }
    }
}
