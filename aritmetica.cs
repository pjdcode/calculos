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
    internal class Aritmetica
    {
        /// <summary>
        /// operação soma
        /// </summary>
        /// <returns>retorna a soma de dois números</returns>
        public int Somar(int x, int y)
        {
            return x+y;
        }

        /// <summary>
        /// operação substrair
        /// </summary>
        /// <returns>retorna a subtração de dois números</returns>
         public int Subtrair(int x, int y)
        {
            return x-y;
        }
    }
}
