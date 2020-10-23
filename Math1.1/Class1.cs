using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math1._1
{
    public class Aritmetica
    {

        public Aritmetica()
        {
            
        }
        public static double SumaDosValoresDecimales(Double Num1, Double Num2)
        {
            return Num1 + Num2;
        }

        public static Double RestaDosNumerosDecimales(Double Num1, Double Num2)
        {
            return Num1 - Num2;
        }
        public static Double divisionDosNumeros(Double Num1, Double Num2)
        {
            if (Num2 == 0)
            {
                throw new Exception("!!DENOMINADOR No Puede Ser 0");
            }
            return Num1 / Num2;
        }
        public static Double MultiplicacionDosNumeros(Double Num1, Double Num2)
        {
            return Num1 * Num2;
        }
    }
}
