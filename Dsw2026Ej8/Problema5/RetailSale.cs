using System;

namespace Dsw2026Ej8.Problema5
{
    public class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return getAmount();
        }
    }
}