﻿using System;

namespace While_Exemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (var contador = 200; contador >= 100; contador--)
            //{
            //Console.WriteLine("Contador: " + contador);
            //}

            float nota;
            bool check = true;
            string texto = "";
            while (check == true)
            {
                Console.WriteLine("\nInsira sua nota" + texto);
                nota = float.Parse(Console.ReadLine());

                if (nota >= 0 && nota <= 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Nota válida");
                    Console.ForegroundColor = ConsoleColor.White;
                    check = false;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nota inválida");
                    Console.ForegroundColor = ConsoleColor.White;
                    texto = " novamente";
                }
            }
        }
    }
}
