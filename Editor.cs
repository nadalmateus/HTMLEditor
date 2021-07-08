using System;
using System.Text;

namespace HTMLEditor
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO EDITOR");
            Console.WriteLine("___________");
            var file = new StringBuilder();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.WriteLine("___________");
            Console.WriteLine("Deseja salvar o arquivo?");
            Viewer.Show(file.ToString());
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");



        }
        public static void Start()
        {

        }
    }
}