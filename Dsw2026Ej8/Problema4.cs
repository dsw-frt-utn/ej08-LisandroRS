using System;

/*Problema N° 4
Crear un método público CalcularPromedio, dentro de una clase Problema4, que reciba:
● int? nota1
● int? nota2
● int? nota3
Debe retornar un double.
Condiciones:
● Debe calcular el promedio solo con las notas que tengan valor.
● Si las tres notas son null, debe retornar 0.
● Si una nota tiene valor menor que 0 o mayor que 10, debe ignorarse.
● No debe lanzar excepción si alguna nota es null.*/

namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3) {

            double suma = 0;
            int notasValidas = 0;

            if (nota1 != null && nota1 >= 0 && nota1 <= 10)
            {
                suma = suma + nota1.Value;
                notasValidas++;
            }

            if (nota2 != null && nota2 >= 0 && nota2 <= 10)
            {
                suma = suma + nota2.Value;
                notasValidas++;
            }

            if (nota3 != null && nota3 >= 0 && nota3 <= 10)
            {
                suma = suma + nota3.Value;
                notasValidas++;
            }

            if (notasValidas == 0)
            {
                return 0;
            }

            return suma / notasValidas;
        }
    }
