using System;
using System.Globalization;

namespace OperadoresAritimeticos
{
    public static class OperadoresAritimeticos
    {
        public static void Main(string[] args)
        {

            //Operadores e significado

            #region addition
            int a = 10;
            int b = 20;
            Console.WriteLine($"Resultado esparo é 30, e o resultado é: {a+b}");

            #endregion

            #region subtraction
            int c = 20;
            int d = 10;
            Console.WriteLine($"Resultado esparo é 10, e o resultado é: {c - d}");
            #endregion

            #region multiplicação

            int e = 2;
            int f = 3;
            Console.WriteLine($"Resultado esparo é 6, e o resultado é: {e * f}");

            #endregion

            #region divisão          

            float x = 17f;
            float z = 3f;
            Console.WriteLine($"resutado esperado é 5,6666665 e o resultado é: {x / z}");

            #endregion

            #region Mod
            //O operador do Mod é "%"
            // Mod é o resto da divisão ex: 17%3 é 2

            Console.WriteLine($"resutado esperado é 2 e o resultado é: {x%z}");
            

            #endregion
        }
    }
}

