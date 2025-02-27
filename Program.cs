using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Reflection.Metadata;
using Kutubxona.Classes;

namespace Kutubxona.Classes
{
    class Program
    {
        static void Main()
        {
            Kitobxon foydalanuvchi = null;

            while (true)
            {
                if (foydalanuvchi == null)
                {
                    Console.WriteLine("\nMenyu\n1. Kirish\n2. Ro'yxatdan o'tish\n3. Chiqish");
                    var tanlov = Console.ReadLine();
                    switch (tanlov)
                    {
                        case "1": foydalanuvchi = SaytManager.Login(); break;
                        case "2": foydalanuvchi = SaytManager.Resister();break;
                        case "3": return;
                    }
                }
                else 
                {
                    var kitoblar = FileManager.LoadKitoblar();
                    Console.WriteLine("\n1. Kitoblar ro'yxati\n2. Kitob qidirish\n3. Kitob olish\n4. Kitob qaytarish\n5. Chiqish");
                    var tanlov = Console.ReadLine();

                    switch (tanlov)
                    {
                        case "1":
                            KutubxonaManager.KitoblarRoyxati(kitoblar);
                            break;
                        case "2":
                            KutubxonaManager.KitoblarRoyxati(kitoblar);
                            Console.WriteLine("Kitob raqamini tanlang: ");
                            int index = Convert.ToInt32(Console.ReadLine())- 1;
                            KutubxonaManager .KitoblarHaqida(kitoblar[index]);
                            break;
                        case "3":
                            KutubxonaManager.KitoblarRoyxati(kitoblar);
                            Console.WriteLine("Kitob raqamini tanlang: ");
                            int ijaraIndex = Convert.ToInt32(Console.ReadLine())- 1;  
                            KutubxonaManager.KitobOlish(foydalanuvchi,kitoblar[ijaraIndex]);
                            FileManager.SaveKitoblar(kitoblar);
                            FileManager.SaveKitobxonlar(new List<Kitobxon> { foydalanuvchi });
                            break;
                        case "4":
                            KutubxonaManager.KitoblarRoyxati(kitoblar);
                            Console.WriteLine("Kitob raqamini tanlang: ");
                            int qaytarishIndex = Convert.ToInt32(Console.ReadLine())- 1; 
                            KutubxonaManager.KitobniQaytarish(foydalanuvchi, kitoblar[qaytarishIndex]);
                            FileManager.SaveKitoblar(kitoblar);
                            FileManager.SaveKitobxonlar(new List<Kitobxon> { foydalanuvchi });
                            break; 
                        case "5":
                            foydalanuvchi = null;
                            break;        

                    }
                }

            }
        }
    }
}