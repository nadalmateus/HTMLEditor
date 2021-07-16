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
            var worlds = text.Split(' ');
            for (int i = 0; i < worlds.Length; i++)
            {
                if (strong.IsMatch(worlds[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(
                        worlds[i].Substring(
                            worlds[1].IndexOf('>') + 1,
                              (
                                  (worlds[1].LastIndexOf('>') + -1) -
                              worlds[1].LastIndexOf('>')
                             )
                        )

                    );
                    Console.Write(" ");
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.Write(worlds[i]);
                        Console.Write(" ");
                    }

                }
            }
        }
    }
}