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

    }
}

