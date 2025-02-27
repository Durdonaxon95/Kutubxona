namespace Kutubxona.Classes
{
    public class SaytManager
    { 
        public static Kitobxon Login()
        { 
            Console.Write("Loginni kiriting: ");
            string login = Console.ReadLine();
            Console.Write("Parolni kiriting: ");
            string parol = Console.ReadLine();

            var kitobxonlar = FileManager.LoadKitobxonlar();
            var kitobxon = kitobxonlar.Find(k => k.Login == login && k.Parol == parol);
            if (kitobxon == null)
            {
                throw new Exception("Noto'g'ri Login yoki Parol kiritdingiz.");
            }
            return kitobxon;
        }
         
        public static Kitobxon Resister()
        {
            Console.Write("Loginni kiriting: ");
            string login = Console.ReadLine();
            Console.Write("Parolni kiriting: ");
            string parol = Console.ReadLine();
            Console.Write("Ismingizni kiriting: ");
            string ism = Console.ReadLine();
            Console.Write("Familyangizni kiriting: ");
            string familiya = Console.ReadLine();
            Console.Write("Yoshingizni kiriting: ");
            int yoshi = Convert.ToInt32(Console.ReadLine());
#pragma warning disable CS8601 // Possible null reference assignment.
            var kitobxon = new Kitobxon
            {
                Login = login,
                Parol = parol,
                Ism = ism,
                Familiya = familiya,
                Yoshi = yoshi,
                Id = new Random().Next(1000, 9999)
            };
#pragma warning restore CS8601 // Possible null reference assignment.

            var kitobxonlar = FileManager.LoadKitobxonlar();
            if (kitobxonlar.Any(k => k.Login == login))
            {
                throw new Exception("Bu login allaqachon mavjud.");
            }

            kitobxonlar.Add(kitobxon);
            FileManager.SaveKitobxonlar(kitobxonlar);

            return kitobxon;
        } 
    }
}