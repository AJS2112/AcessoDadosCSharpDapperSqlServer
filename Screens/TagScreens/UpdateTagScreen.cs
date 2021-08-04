using System;
using BlogBalta.Models;
using BlogBalta.Repositories;

namespace BlogBalta.Screens.TagScreens
{
    public static class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Atualizando uma tag");
            Console.WriteLine("-------------------");

            Console.Write("Id: ");
            var id = Console.ReadLine();

            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            var tag = new Tag
            {
                Id = Convert.ToInt32(id),
                Name = nome,
                Slug = slug
            };
            Update(tag);

            Console.ReadKey();
            MenuTagScreen.Load();
        }

        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>(Database.Connection);
                repository.Update(tag);
                System.Console.WriteLine("Tag atualizada com sucesso!");
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Não foi possivel atualizar a tag");
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}