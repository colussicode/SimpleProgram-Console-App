﻿using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - Abrir arquivo de texto.");
            Console.WriteLine("2 - Criar novo arquivo.");
            Console.WriteLine("0 - Sair.");

            short option = short.Parse(Console.ReadLine());

            switch(option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;
            }
        }

        static void Abrir()
        {

        }

        static void Editar()
        {
            Console.Clear();

            Console.WriteLine("Digite seu texto abaixo: (ESC para sair)");
            Console.WriteLine("-----------------------");
            string text = "";

            while(Console.ReadKey().Key != ConsoleKey.Escape)
            {
                string newText = Console.ReadLine();

                text = newText;

                Console.WriteLine(text);
                Console.ReadKey();
            }
        }
    }
}