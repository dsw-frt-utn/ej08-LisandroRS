using System;

namespace Dsw2026Ej8.Problema5
{
    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        {
            decimal totalConDescuento = getAmount() * 0.90m;

            return totalConDescuento;
        }
    }
}
