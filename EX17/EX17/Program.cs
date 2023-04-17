using System;
using System.IO;
using System.Globalization;

namespace EX17
{
    class Program
    {
        static void Main(string[] args)
        {
            string NameProduct;
            double PriceProduct;
            int QtdProduct;
            double ValTot;
            using (StreamReader Sr = new StreamReader(@"C:/Users/thiag/OneDrive/Documentos/CursoCSharp/EX17/Produtos.txt"))
            {
                StreamWriter Sw = null;
                try
                {
                    Sw = new StreamWriter(@"C:/Users/thiag/OneDrive/Documentos/CursoCSharp/EX17/out/summary.csv");

                    while (!Sr.EndOfStream)
                    {
                        string[] ProdctSeparated = Sr.ReadLine().Split(",");
                        NameProduct = ProdctSeparated[0];
                        PriceProduct = double.Parse(ProdctSeparated[1], CultureInfo.InvariantCulture);
                        QtdProduct = int.Parse(ProdctSeparated[2]);

                        ValTot = PriceProduct * QtdProduct;

                        string Line = NameProduct + "," + ValTot.ToString("F02", CultureInfo.InvariantCulture);

                        Sw.WriteLine(Line);
                    }
                }
                finally
                {
                    Sw.Close();
                }
            }
        }
    }
}