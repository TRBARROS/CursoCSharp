using System.Globalization;

namespace EX14.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() 
        {
        }

        public UsedProduct(string name, double price, DateTime manufacturedate)
            :base(name, price)
        {
            ManufactureDate = manufacturedate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) $ {Price.ToString("F02", CultureInfo.InvariantCulture)} (Manufactured date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
