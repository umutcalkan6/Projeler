using System;
using System.Collections.Generic;
using System.IO; // Dosya işlemleri için bu kütüphane şart!
using System.Windows.Forms;


namespace Atyarışı
{
    public static class YarisVerileri
    {
        public static List<string> GecmisSonuclar = new List<string>();

        // Dosyanın kaydedileceği yol (Projenin çalıştığı klasörde "GecmisYarislar.txt" oluşturur)
        private static string dosyaYolu = AppDomain.CurrentDomain.BaseDirectory + "GecmisYarislar.txt";

        // YENİ METOT: Veriyi hem listeye hem de dosyaya ekler
        public static void Kaydet(string sonuc)
        {
            // 1. Önce geçici hafızadaki listeye ekle (Program açıkken hızlı erişim için)
            GecmisSonuclar.Add(sonuc);

            // 2. Sonra dosyaya kalıcı olarak ekle (AppendAllText: Var olanın altına ekler)
            // Dosya yoksa otomatik oluşturur.
            // Araya özel bir ayraca (----------) koyuyoruz ki okurken kolay olsun.
            File.AppendAllText(dosyaYolu, sonuc + "\n<<AYIRAC>>\n");
        }

        // YENİ METOT: Program açılınca dosyadan eski verileri çeker
        public static void VerileriYukle()
        {
            // Eğer dosya varsa oku
            if (File.Exists(dosyaYolu))
            {
                // Tüm metni oku
                string tumMetin = File.ReadAllText(dosyaYolu);

                // <<AYIRAC>> kelimesine göre parçalayıp listeye doldur
                string[] sonuclar = tumMetin.Split(new string[] { "\n<<AYIRAC>>\n" }, StringSplitOptions.RemoveEmptyEntries);

                GecmisSonuclar.AddRange(sonuclar);
            }
        }

        // Bu metodu YarisVerileri sınıfının içine ekle
        public static void GecmisiTemizle()
        {
            // 1. Hafızadaki listeyi boşalt
            GecmisSonuclar.Clear();

            // 2. Bilgisayardaki dosyayı sil
            if (File.Exists(dosyaYolu))
            {
                File.Delete(dosyaYolu);
            }
        }

        public static decimal OyuncuBakiyesi = 100000;
    
    public static int SuankiAyak = 1;     // Şu an kaçıncı yarıştayız?
        public static int ToplamAyak = 4;     // Toplam kaç yarış olacak?
        public static decimal BuyukHavuz = 0; // Biriken toplam para

        // Kimin kaç doğrusu var? (İsim -> Puan)
        public static Dictionary<string, int> OyuncuPuanlari = new Dictionary<string, int>();

        // Ayakları sıfırlamak için bir metot
        public static void TurnuvayiSifirla()
        {
            SuankiAyak = 1;
            BuyukHavuz = 0;
            OyuncuPuanlari.Clear();
        }
    
    public static Dictionary<string, int> AtKazanmaSayilari = new Dictionary<string, int>();

        // Turnuva başlarken istatistikleri sıfırlayan metot
        public static void IstatistikleriSifirla()
        {
            AtKazanmaSayilari.Clear();

            // At isimlerini buraya elle ekleyelim ki başta hepsi 0 olsun
            // (Senin at isimlerin neyse onları yaz)
            AtKazanmaSayilari.Add("Gülbatur", 0);
            AtKazanmaSayilari.Add("Poyraz", 0);
            AtKazanmaSayilari.Add("Karayel", 0);
            AtKazanmaSayilari.Add("Şahbatur", 0);
            AtKazanmaSayilari.Add("Rüzgar", 0);
        }
    }
}

