namespace Kutubxona.Classes
{
    public class Kitobxon
    { 
        public string Login { get; set; }
        public string Parol { get; set; }
        public int Id { get; set; }
        public string Ism { get; set; }
        public string Familiya { get; set; }
        public int Yoshi { get; set; }
        public int OlganKitoblari { get; set; }
        public List<int> KitoblarListi { get; set; } = new List<int>();
        
    }
}