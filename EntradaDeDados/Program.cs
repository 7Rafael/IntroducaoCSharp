using System;
using System.Globalization;

namespace EntradaDeDados
{
    public class EntradaDeDados
    {
        static void Main(string[] args)
        {
            
            #region strings
           
            Console.WriteLine("Digite uma frase");
            string frase = Console.ReadLine();

            Console.WriteLine("Digite 3 palavras");
            string[] vet = Console.ReadLine().Split(' ');
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];

            Console.WriteLine($"A frase que foi digitada é: {frase}");
            Console.WriteLine($"A primeira palavra digitada foi: {p1}");
            Console.WriteLine($"A segunda palavra digitada foi: {p2}");
            Console.WriteLine($"A terceira palavra digitada foi: {p3}");
       
            #endregion
            
            #region Cadastro

            Console.WriteLine("Digite seu Nome, Sexo, Idade e Altura, deixando espaço entre cada item");
            string[] v = Console.ReadLine().Split(' ');
            string nome = v[0];
            char sexo = char.Parse(v[1].ToUpper());
            int idade = int.Parse(v[2]);
            double altura = double.Parse(v[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"Seu nome é: {nome}");
            Console.WriteLine($"Seu sexo é: {sexo}");
            Console.WriteLine($"Sua idade é: {idade}");
            Console.WriteLine($"Sua altura é: {altura.ToString("F2", CultureInfo.InvariantCulture)}");
           
            #endregion
        }

    }

}
