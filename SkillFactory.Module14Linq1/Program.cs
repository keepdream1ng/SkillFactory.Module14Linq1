using System;
namespace SkillFactory.Module14Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dummy data. 
            var phoneBook = new List<Contact>();

            phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
            phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

            // Ordering list in alphabetical order.
            phoneBook = phoneBook.OrderBy(x => x.Name)
                                 .ThenBy(x => x.LastName)
                                 .ToList();
            Console.WriteLine(BookUI.Intstructions);
            int pageToShow = 1;

            // Control for the phonebook UI, when Q is pressed the program will end.
            while (true)
            {
                pageToShow = Console.ReadKey(true).Key switch
                {
                    ConsoleKey.D1 => 1,
                    ConsoleKey.D2 => 2,
                    ConsoleKey.D3 => 3,
                    // Adding option to break on.
                    ConsoleKey.Q  => 0,
                    _             => pageToShow,
                };
                if (pageToShow == 0) break;

                BookUI.ShowPage(pageToShow, phoneBook);
            }
        }
    }
}