using System.Globalization;

namespace EX14.Entities
{
    class ImportPorduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportPorduct()
        {
        }

        public ImportPorduct(string name, double price, double customsfee)
            :base(name, price)
        {
            CustomsFee = customsfee;
        }

        public override string PriceTag()
        {
            return $"{Name} $ {(Price + CustomsFee).ToString("F02", CultureInfo.InvariantCulture)} (Customs fee: {CustomsFee.ToString("F02", CultureInfo.InvariantCulture)})";
        }
    }
}
