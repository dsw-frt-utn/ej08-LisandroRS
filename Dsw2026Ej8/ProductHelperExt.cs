using System;

namespace Dsw2026Ej8
{

    public partial class ProductHelper
    {
        private string formatearMoneda(decimal price)
        {
            return price.ToString("C");
        }
    }
}