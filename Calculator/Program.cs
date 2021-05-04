﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
            Subtracao();
            Divisao();
        }

        static void Soma()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Primeiro Valor: ");
                var v1 = float.Parse(Console.ReadLine() ?? string.Empty);
            
                Console.WriteLine("Segundo valor Valor: ");
                var v2 = float.Parse(Console.ReadLine() ?? string.Empty);

                Console.WriteLine("");
                
                var resultado = v1 + v2;
                Console.WriteLine($"O resultado da soma é: {resultado}");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Valor invalido, tente outro valor!");
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadKey();
                Soma();
                throw;
            }
        }

        static void Subtracao()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Primeiro Valor: ");
                var v1 = float.Parse(Console.ReadLine() ?? string.Empty);
            
                Console.WriteLine("Segundo valor Valor: ");
                var v2 = float.Parse(Console.ReadLine() ?? string.Empty);

                Console.WriteLine("");
                
                var resultado = v1 - v2;
                Console.WriteLine($"O resultado da subtração é: {resultado}");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Valor invalido, tente outro valor!");
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadKey();
                Subtracao();
                throw;
            }
        }

        static void Divisao()
        {
            Console.Clear();
            try
            {
                Console.WriteLine("Primeiro Valor: ");
                var v1 = float.Parse(Console.ReadLine() ?? string.Empty);
            
                Console.WriteLine("Segundo valor Valor: ");
                var v2 = float.Parse(Console.ReadLine() ?? string.Empty);

                Console.WriteLine("");
                
                var resultado = v1 / v2;
                Console.WriteLine($"O resultado da Divisão é: {resultado}");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Valor invalido, tente outro valor!");
                Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadKey();
                Divisao();
                throw;
            }
        }
    }
}