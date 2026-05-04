using System;

namespace Dsw2026Ej8.Problema5
{
    public class Sale
    {
        decimal _amount;

        public decimal getAmount()
        {
            return _amount;
        }
        public void setAmount(decimal amount) {
            _amount= amount;
    }

        public virtual decimal CalculateTotal()
        {
            return _amount;
        }

}