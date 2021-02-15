using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eficiência
{
    class Calculo
    {
        public decimal Calc(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9, int qtd)
        {
            int acima = 0;

            decimal media = (n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9) / qtd;
            if(n1 > media && n1 != 0)
            {
                acima = acima + 1;
            }
            if (n2 > media && n2 != 0)
            {
                acima = acima + 1;
            }
            if (n3 > media && n3 != 0)
            {
                acima = acima + 1;
            }
            if (n4 > media && n4 != 0)
            {
                acima = acima + 1;
            }
            if (n5 > media && n5 != 0)
            {
                acima = acima + 1;
            }
            if (n6 > media && n6 != 0)
            {
                acima = acima + 1;
            }
            if (n7 > media && n7 != 0)
            {
                acima = acima + 1;
            }
            if (n8 > media && n8 != 0)
            {
                acima = acima + 1;
            }
            if (n9 > media && n9 != 0)
            {
                acima = acima + 1;
            }

            decimal resultado = (100 * acima) / qtd;
            return resultado;
        }
    }
}
