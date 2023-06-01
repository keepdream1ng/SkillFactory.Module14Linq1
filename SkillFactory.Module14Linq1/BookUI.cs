namespace SkillFactory.Module14Linq1
{
    public static class BookUI
    {
        public static string Intstructions = "Press 1, 2, 3 for viewing phonebook pages or Q to exit the app.\n";
        private static int _contactPerPage = 2;

        public static void ShowPage(int page, List<Contact> contacts)
        {
            Console.Clear();
            Console.WriteLine(Intstructions);
            var contactpage = contacts.Skip((page - 1) * _contactPerPage)
                                      .Take(_contactPerPage)
                                      .Select(x => $"{x.Name} {x.LastName}: {x.PhoneNumber}");
            Console.WriteLine(String.Join('\n', contactpage));
        }
    }
}
