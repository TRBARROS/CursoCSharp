using System;
using System.Globalization;

namespace EX12
{
    class Program
    {
        static void Main(string[] args)
        {
            string MatrizXeY;
            string[] PosiSplit;
            int MatrizX;
            int MatrizY;
            int[,] MatrizBi;

            Console.WriteLine("Digite com os valores x e y da matriz:");
            MatrizXeY = Console.ReadLine();

            char[] delimiters = { ' ' };
            string[] SubMatriz = MatrizXeY.Split(delimiters);
            MatrizX = int.Parse(SubMatriz[0]);
            MatrizY = int.Parse(SubMatriz[1]);

            MatrizBi = new int[MatrizX,MatrizY];

            for (int i = 0; i < MatrizX; i++)
            {
                string MatrizValues = Console.ReadLine();
                string[] MatrizSplit = MatrizValues.Split(" ");

                for (int j = 0; j < MatrizY; j++)
                {
                    MatrizBi[i, j] = int.Parse(MatrizSplit[j]);
                    //Console.WriteLine(MatrizSplit[j]);
                }
            }

            for (int i = 0; i < MatrizX; i++)
            {
                Console.WriteLine(" ");
                for (int j = 0; j < MatrizY; j++)
                {
                    Console.Write(MatrizBi[i,j]);
                }
            }
            Console.WriteLine(" ");

            for (int i = 0; i < 2; i++) {

                Console.WriteLine("Digite uma posição:");
                PosiSplit = Console.ReadLine().Split(",");
                Console.WriteLine($"Valor da posição digitada: {MatrizBi[Convert.ToInt32(PosiSplit[0]), Convert.ToInt32(PosiSplit[1])]}");

                int PosiLeft = 0;
                int PosiRight = 0;
                int PosiUp = 0;
                int PosiDown = 0;

                try
                {
                    PosiLeft = MatrizBi[Convert.ToInt32(PosiSplit[0]), Convert.ToInt32(PosiSplit[1]) - 1];
                    Console.WriteLine($"Position Left: {PosiLeft}");
                }
                catch ( Exception e )
                {
                    Console.Write("");
                }

                try
                {
                    PosiRight = MatrizBi[Convert.ToInt32(PosiSplit[0]), Convert.ToInt32(PosiSplit[1]) + 1];
                    Console.WriteLine($"Position Right: {PosiRight}");
                }
                catch (Exception e)
                {
                    Console.Write("");
                }

                try
                {
                    PosiUp = MatrizBi[Convert.ToInt32(PosiSplit[0]) - 1, Convert.ToInt32(PosiSplit[1])];
                    Console.WriteLine($"Position Up: {PosiUp}");
                }
                catch (Exception e)
                {
                    Console.Write("");
                }

                try
                {
                    PosiDown = MatrizBi[Convert.ToInt32(PosiSplit[0]) + 1, Convert.ToInt32(PosiSplit[1])];
                    Console.WriteLine($"Position Down: {PosiDown}");
                }
                catch (Exception e)
                {
                    Console.Write("");
                }
            }
        }
    }
}