using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoECasting
{
    class ConversaoECasting
    {
        static void Main(string[] args)
        {
            // como o float é 4 bytes e o double é 8 bytes
            // da para fazer uma conversão normal(de float para double)
            float x = 4.5f;
            double y = x;

            Console.WriteLine($"Covnersão de float para double: {y}");

            //porém como o double usa mais bytes quando for fazer a conversão pode
            //ter perdas de bytes, por isso deve usar o (float)
            double a = 2.3;
            float b = (float)a;

            Console.WriteLine($"Conversão de double para float: {b}");


            int c = 5;
            int d = 2;

            // 5/2 deveria retornar 2.5, porém retorna 2
            double resultado = c / d;
            Console.WriteLine($"Deveria retornar 2,5 porém o resultado é: {resultado}");

            //colocando o "(double)", da certo e retorna o valor 2.5
            double resultado1 =(double) c / d;
            Console.WriteLine($"O Resultado esperado é 2,5 e o resultado é: {resultado1}");
        }


    }
}
