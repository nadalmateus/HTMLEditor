using System;
using System.Text.RegularExpressions;

namespace HTMLEditor
{
    public class Viewer
    {
        public static void Show(string text)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("MODO VISUALIZAÇÃO");
            Console.WriteLine("___________");
            Replace(text);
            Console.WriteLine("___________");
            Console.ReadKey();
            Menu.Show();

        }

        public static void Replace(string text)
        {
            var strong = new Regex(@"<\s*<strong[^a]*>(.*?)<\s*/\*strong>");
            Console.WriteLine(strong);
        }
    }
}