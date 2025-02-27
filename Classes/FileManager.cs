using Newtonsoft.Json;
namespace Kutubxona.Classes
{
    public class FileManager
    {
        private const string KitoblarFile = "kitoblar.json";
        private const string KitobxonlarFile = "kitobxonlar.json";

        public static List<Kitob> LoadKitoblar()
        {
            if (File.Exists(KitoblarFile))
            {
                string json = File.ReadAllText(KitoblarFile);
                return JsonConvert.DeserializeObject<List<Kitob>>(json) ?? new List<Kitob>();
            }
            return new List<Kitob>();
        }
        public static void SaveKitoblar(List<Kitob> kitoblar)
        {
            File.WriteAllText(KitoblarFile, JsonConvert.SerializeObject(kitoblar));
        }
        public static List<Kitobxon> LoadKitobxonlar()
        {
            if (File.Exists(KitobxonlarFile))
            {
                string json = File.ReadAllText(KitobxonlarFile);
                return JsonConvert.DeserializeObject<List<Kitobxon>>(json) ?? new List<Kitobxon>();
            }
            return new List<Kitobxon>();
        }
         public static void SaveKitobxonlar(List<Kitobxon> kitobxonlar)
        {
            File.WriteAllText(KitobxonlarFile, JsonConvert.SerializeObject(kitobxonlar));
        }

    }
}