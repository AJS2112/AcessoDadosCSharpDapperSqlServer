using System;
using BlogBalta.Models;
using BlogBalta.Repositories;

namespace BlogBalta.Screens.TagScreens
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Nova Tag");
            Console.WriteLine("--------");

            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Slug: ");
            var slug = Console.ReadLine();

            Create(new Tag { Name = nome, Slug = slug });
            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Create(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Create(tag);
                Console.WriteLine("Cadastro com sucesso");

            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Não foi possivel salvar a tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}