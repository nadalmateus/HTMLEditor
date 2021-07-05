using System;

namespace HTMLEditor
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawnScreen();
            WriteOptions();
            var options = short.Parse(Console.ReadLine());
            HandleMenuOption(options);
        }

        public static void DrawnScreen()

        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
                Console.Write("-");

            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 10; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                    Console.Write(" ");


                Console.Write("|");
                Console.Write("\n");
            }


        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.Write("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.Write("==============================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.Write("1 - Criar um novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.Write("2 - Editar um arquivo existente");
            Console.SetCursorPosition(3, 8);
            Console.Write("3 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("");

        }
        public static void HandleMenuOption(short options)
        {
            switch (options)
            {
                case 1: Editor.Show(); break;
                case 2: Console.WriteLine("View"); break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }


    }
}