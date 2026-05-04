using System;

/*Crear un método público CrearResumenVenta, dentro de una clase Problema2, que
reciba:
● long productCode
● string productDescription
● int quantity
● decimal unitPrice
El método debe crear internamente una clase anónima con los datos:
● Code
● Description
● Quantity
● Total
Debe retornar una cadena con el formato:
Code-Description-Total
Condiciones:
● Total debe calcularse como quantity * unitPrice.
● Si quantity es menor o igual a 0, el total debe ser 0.
● El método debe usar una clase anónima dentro de su implementación.
*/

namespace Dsw2026Ej8
{

	public class Problema2
	{
		public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
		{
			decimal total;

			if (quantity > 0)
			{
				total = quantity * unitPrice;
			}
			else
			{
				total = 0;
			}

			var anonimo = new
			{
				Code = productCode,
				Description = productDescription,
				Quantity = quantity,
				Total = total,
			};

			return $"{anonimo.Code}-{anonimo.Description}-{anonimo.Total}";
		}
	}
}
