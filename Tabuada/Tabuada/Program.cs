using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, res;//declaração de variaveis
            Console.Clear();
            Console.WriteLine("Tabuada do 1 a 10");//Titulo
            Console.WriteLine("\n\nDigite o numero que deseja a Tabuada:");
            y = int.Parse(Console.ReadLine());
            for (x = 1; x <= 10; x++)//x=1 se x menor ou igual a 10 x+1
            {
                res = y * x;
                Console.WriteLine("{0} x {1} = {2}", y, x, res);//Apresentação do resutado ao usuário
            }
            Console.ReadKey();
        }
    }
}
