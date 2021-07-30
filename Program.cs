using System;
using BlogBalta.Screens.TagScreens;
using Microsoft.Data.SqlClient;

namespace BlogBalta
{
    class Program
    {
        private const string CONNECTION_STRING = "Data source=localhost; Initial Catalog=BlogBalta; Persist Security Info=True; Integrated Security=SSPI;";
        static void Main(string[] args)
        {
            Database.Connection = new SqlConnection(CONNECTION_STRING);
            Database.Connection.Open();

            Load();

            Console.ReadKey();
            Database.Connection.Close();
        }

        private static void Load()
        {
            Console.Clear();
            Console.WriteLine("Menu Blog:");
            Console.WriteLine("---------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("");
            Console.WriteLine("1 - Gestão de usuário");
            Console.WriteLine("2 - Gestão de perfil");
            Console.WriteLine("3 - Gestão de categoria");
            Console.WriteLine("4 - Gestão de tag");
            Console.WriteLine("5 - Vincular perfil/usuário");
            Console.WriteLine("6 - Vincular post");
            Console.WriteLine("7 - Relatórios");

            Console.WriteLine("");
            Console.WriteLine("");

            var option = short.Parse(Console.ReadLine()!);

            switch (option)
            {
                case 4:
                    MenuTagScreen.Load();
                    break;
                default: Load(); break;
            }
        }
    }
}
