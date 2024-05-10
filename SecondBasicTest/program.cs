using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int qt = int.Parse(Console.ReadLine());

        for (int i = 0; i < qt; i++)
        {
            string[] v = Console.ReadLine().Split();
            string a = v[0];
            string b = v[1];

            if (a.EndsWith(b))
                Console.WriteLine("encaixa");
            else
                Console.WriteLine("nao encaixa");
        }
    }
}
