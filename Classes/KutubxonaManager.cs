using System.Reflection.Metadata;

namespace Kutubxona.Classes
{
    public class KutubxonaManager
    {
        public static void KitoblarRoyxati(List<Kitob> kitoblar)
        {
            Console.WriteLine("\nKitoblar ro'yxati: ");
            for (int integer = 0; integer < kitoblar.Count; integer++)
                Console.WriteLine($"{integer + 1}. {kitoblar[integer].Nomi} ({kitoblar[integer].QolganKitoblar} ta mavjud)");

        }
        
        public static void KitoblarHaqida(Kitob kitob)
        {
            Console.WriteLine($"\nID: {kitob.Id}");
            Console.WriteLine($"Nomi: {kitob.Nomi}");
            Console.WriteLine($"Muallifi: {kitob.Muallifi}");
            Console.WriteLine($"Mavjud kitoblar: {kitob.QolganKitoblar}/{kitob.JamiKitoblar}");
            Console.WriteLine("Olganlar: " + string.Join(",", kitob.Olganlar));
            
        }

        public static void KitobOlish (Kitobxon user, Kitob kitob)
        {
            if (kitob.QolganKitoblar > 0)
            {
                kitob.QolganKitoblar--;
                user.OlganKitoblari++;
                user.KitoblarListi.Add(kitob.Id);
                kitob.Olganlar.Add(user.Login);
                Console.WriteLine("Kitobni mutoala qilishingiz mumkin!");
            }
            else Console.WriteLine("Bu kitobdan qolmagan!");

        }

        public static void KitobniQaytarish(Kitobxon user, Kitob kitob)
        {
            if (user.KitoblarListi.Contains(kitob.Id))
            {
                kitob.QolganKitoblar++;
                user.OlganKitoblari--;
                user.KitoblarListi.Remove(kitob.Id);
                kitob.Olganlar.Remove(user.Login);
                Console.WriteLine("Kitob muvaffaqiyatli qaytarildi!");
            }
            else Console.WriteLine("Sizda bu kitob yo'q!");
        }
    }
}