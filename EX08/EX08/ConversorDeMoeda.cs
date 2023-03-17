using System;

namespace EX08
{
    class ConversorDeMoeda
    {
        public static double Calculo(Double Cot, Double Qtde)
        {
            return (Cot * Qtde) + ((Cot * Qtde) * 0.06);
        }
    }
}
