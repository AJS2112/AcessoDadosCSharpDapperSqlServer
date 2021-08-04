using System;
using BlogBalta.Models;
using BlogBalta.Repositories;

namespace BlogBalta.Screens.TagScreens
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Deletando uma tag");
            Console.WriteLine("-----------------");

            Console.Write("Informe o Id da tag a ser excluida: ");
            var id = Console.ReadLine();


            Delete(int.Parse(id));

            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Delete(id);
                System.Console.WriteLine("Tag deletada com sucesso!");
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Não foi possivel deletar a tag");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}