using System;


namespace EX18.Entities
{
    internal class Contract
    {
        public int NumContrato { get; set; }
        public double ValorContrato { get; set; }
        public double QtdeParcelas { get; set; }
        public Installment Parcelas { get; set; }
        
    }
}
