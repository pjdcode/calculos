using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    /// <summary>
    /// implementa operações aritméticas
    /// </summary>
    internal static class Aritmetica
    {
        /// <summary>
    /// Tipo de conversão de temperatura a executar.
    /// </summary>
    public enum ConversaoTemperatura
    {
        Nulo = 0,
        CelsiusFahrenheit,
        FahrenheitCelsius
    }


        /// <summary>
        /// operação soma
        /// </summary>
        /// <returns>retorna a soma de dois números</returns>
        public static int Somar(int x, int y)
        {
            return x+y;
        }

        /// <summary>
        /// operação substrair
        /// </summary>
        /// <returns>retorna a subtração de dois números</returns>
         public static int Subtrair(int x, int y)
        {
            return x-y;
        }

        /// <summary>
        /// Operação de multiplicação.
        /// </summary>
        /// <returns>Retorna o resultado da multiplicação de dois números.</returns>
        public static int Multiplicar(int x, int y) 
        {
            return x * y;
        }



    }
}
