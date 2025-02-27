namespace Kutubxona.Classes
{
    public class Kitob
    {
        public int Id { get; set; } 
        public string Nomi { get; set; }
        public string Muallifi { get; set; }
        public int JamiKitoblar { get; set; }
        public int QolganKitoblar { get; set; }
        public List<string> Olganlar { get; set; }

        public static void KitobQoshish()
        {
            var newBook = new Kitob();
            Console.Write("Kitob ID: ");
            newBook.Id = int.Parse(Console.ReadLine());
            Console.Write("Nomi: ");
            newBook.Nomi = Console.ReadLine();
            Console.Write("Muallifi: ");
            newBook.Muallifi = Console.ReadLine();
            Console.Write("Jami soni: ");
            newBook.JamiKitoblar = int.Parse(Console.ReadLine());
            newBook.QolganKitoblar = newBook.JamiKitoblar;

            var kitoblar = FileManager.LoadKitoblar();
            kitoblar.Add(newBook);
            FileManager.SaveKitoblar(kitoblar);
            Console.WriteLine("Kitob qo'shildi!");
        }
        

    }
}

