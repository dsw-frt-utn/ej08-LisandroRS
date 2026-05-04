using System;

/*Crear un método público CompararCopias, dentro de una clase Problema3, que reciba:
● int originalValue
● Product product
El método debe:
1. Copiar originalValue en una variable local.
2. Incrementar solo la copia.
3. Copiar la referencia de product en otra variable local.
4. Modificar la descripción del producto copiado mediante el método disponible en la
clase.
5. Retornar una cadena con el formato:
valorOriginal-valorCopia-descripcionProducto
*/

namespace Dsw2026Ej8
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int copia = originalValue;
            copia++;

            Product productoCopia = product;
            productoCopia.setDescription("Nueva Descripcion");

            return $"{originalValue}-{copia}-{productoCopia.getDescription()}";

        }
    }
   
}
