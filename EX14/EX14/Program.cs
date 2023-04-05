using EX14.Entities;
using System.Globalization;

namespace EX13
{
    class Program
    {
        static void Main(string[] args)
        {
            int QuantProd;
            List<Product> ProdsList = new List<Product>();
            ImportPorduct ProdImported = new ImportPorduct();

            Console.Write("Enter the number of products:");
            QuantProd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= QuantProd; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                string TypeProd = Console.ReadLine();
                Console.Write("Name: ");
                string NameProd = Console.ReadLine();
                Console.Write("Price: ");
                double PriceProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double FeeProd;
                DateTime DateManuProd;

                if (TypeProd.ToLower() == "i")
                {
                    Console.Write("Customs fee: ");
                    FeeProd = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ProdImported = new ImportPorduct(NameProd, PriceProd, FeeProd);
                    ProdsList.Add(ProdImported);
                }
                else if (TypeProd.ToLower() == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateManuProd = DateTime.Parse(Console.ReadLine());
                    UsedProduct ProdUsed = new UsedProduct(NameProd, PriceProd, DateManuProd);
                    ProdsList.Add(ProdUsed);
                }
                else if (TypeProd.ToLower() == "c")
                {
                    Product ProdCommon = new Product(NameProd, PriceProd);
                    ProdsList.Add(ProdCommon);
                } 

            }
            Console.WriteLine("");
            Console.WriteLine("PRICE TAGS:");
            foreach (Product Prods in ProdsList)
            {
                Console.WriteLine(Prods.PriceTag());
            }

        }
    }
}