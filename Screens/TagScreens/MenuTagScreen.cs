using System;

namespace BlogBalta.Screens.TagScreens
{
    public static class MenuTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de Tags:");
            Console.WriteLine("---------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("");
            Console.WriteLine("1 - Listar tags");
            Console.WriteLine("2 - Cadastrar tags:");
            Console.WriteLine("");
            Console.WriteLine("");

            var option = short.Parse(Console.ReadLine()!);
        }
    }
}