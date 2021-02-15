using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eficiência
{
    class Program
    {
        static void Main(string[] args)
        {
                int n1 = 0;
                int n2 = 0;
                int n3 = 0;
                int n4 = 0;
                int n5 = 0;
                int n6 = 0;
                int n7 = 0;
                int n8 = 0;
                int n9 = 0;
                int qtd = 0;
                decimal media = 0;
                Calculo c = new Calculo();

                Console.WriteLine("Calculo de Eficiência / Alunos acima da média.");

                Console.WriteLine("Informe a quantidade de amostra.");
                qtd = Convert.ToInt32(Console.ReadLine());

                if (qtd == 2)
                {
                    Console.WriteLine("Informe os 2 valorores da amostra.");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    media = c.Calc(n1, n2, n3, n4, n5, n6, n7, n8, n9, qtd);
                }

                if (qtd == 3)
                {
                    Console.WriteLine("Informe os 3 valorores da amostra.");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    n3 = Convert.ToInt32(Console.ReadLine());
                    media = c.Calc(n1, n2, n3, n4, n5, n6, n7, n8, n9, qtd);
                }

                if (qtd == 4)
                {
                    Console.WriteLine("Informe os 4 valorores da amostra.");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    n3 = Convert.ToInt32(Console.ReadLine());
                    n4 = Convert.ToInt32(Console.ReadLine());
                    media = c.Calc(n1, n2, n3, n4, n5, n6, n7, n8, n9, qtd);
                }

                if (qtd == 5)
                {
                    Console.WriteLine("Informe os 5 valorores da amostra.");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    n3 = Convert.ToInt32(Console.ReadLine());
                    n4 = Convert.ToInt32(Console.ReadLine());
                    n5 = Convert.ToInt32(Console.ReadLine());
                    media = c.Calc(n1, n2, n3, n4, n5, n6, n7, n8, n9, qtd);
                }

                if (qtd == 6)
                {
                    Console.WriteLine("Informe os 6 valorores da amostra.");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    n3 = Convert.ToInt32(Console.ReadLine());
                    n4 = Convert.ToInt32(Console.ReadLine());
                    n5 = Convert.ToInt32(Console.ReadLine());
                    n6 = Convert.ToInt32(Console.ReadLine());
                    media = c.Calc(n1, n2, n3, n4, n5, n6, n7, n8, n9, qtd);
                }

                if (qtd == 7)
                {
                    Console.WriteLine("Informe os 7 valorores da amostra.");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    n3 = Convert.ToInt32(Console.ReadLine());
                    n4 = Convert.ToInt32(Console.ReadLine());
                    n5 = Convert.ToInt32(Console.ReadLine());
                    n6 = Convert.ToInt32(Console.ReadLine());
                    n7 = Convert.ToInt32(Console.ReadLine());
                    media = c.Calc(n1, n2, n3, n4, n5, n6, n7, n8, n9, qtd);
                }

                if (qtd == 8)
                {
                    Console.WriteLine("Informe os 8 valorores da amostra.");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    n3 = Convert.ToInt32(Console.ReadLine());
                    n4 = Convert.ToInt32(Console.ReadLine());
                    n5 = Convert.ToInt32(Console.ReadLine());
                    n6 = Convert.ToInt32(Console.ReadLine());
                    n7 = Convert.ToInt32(Console.ReadLine());
                    n8 = Convert.ToInt32(Console.ReadLine());
                    media = c.Calc(n1, n2, n3, n4, n5, n6, n7, n8, n9, qtd);
                }

                if (qtd == 9)
                {
                    Console.WriteLine("Informe os 9 valorores da amostra.");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    n2 = Convert.ToInt32(Console.ReadLine());
                    n3 = Convert.ToInt32(Console.ReadLine());
                    n4 = Convert.ToInt32(Console.ReadLine());
                    n5 = Convert.ToInt32(Console.ReadLine());
                    n6 = Convert.ToInt32(Console.ReadLine());
                    n7 = Convert.ToInt32(Console.ReadLine());
                    n8 = Convert.ToInt32(Console.ReadLine());
                    n9 = Convert.ToInt32(Console.ReadLine());
                    media = c.Calc(n1, n2, n3, n4, n5, n6, n7, n8, n9, qtd);
                }

                Console.WriteLine(media + "%");
                Console.ReadKey();
        }
    }
}
