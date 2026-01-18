using Atyarışı;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Atyarışı
{
    public partial class Form2 : Form
    {
        List<Bahis> _oyuncular;
        List<At> _atlar;

        // Yapıcı metodu değiştiriyoruz, böylece Form1'den verileri alabiliriz
        public Form2(List<Bahis> gelenOyuncular)
        {
            InitializeComponent();
            _oyuncular = gelenOyuncular;

            // KODLARI BURAYA TAŞIDIK (Burasi form açılırken %100 çalışır)
            _atlar = new List<At>();
            _atlar.Add(new At(1, "Şahbatur", pbAt1, lblAtIsmi1));
            _atlar.Add(new At(2, "Gülbatur", pbAt2, lblAtIsmi2));
            _atlar.Add(new At(3, "Rüzgar", pbAt3, lblAtIsmi3));
            _atlar.Add(new At(4, "Poyraz", pbAt4, lblAtIsmi4));
            _atlar.Add(new At(5, "Karayel", pbAt5, lblAtIsmi5));

            // Atları başlangıca koy
            foreach (var at in _atlar)
            {
                at.BasaDon();
            }
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Tüm atları koştur
            foreach (var at in _atlar)
            {
                at.Kos();

                // Bitiş çizgisini geçti mi kontrolü
                // Atın genişliği + sol konumu >= Bitiş çizgisinin sol konumu
                if (at.ResimKutusu.Right >= lblBitis.Left)
                {
                    timer1.Stop(); // Yarışı durdur
                    YarisiBitir(at); // Kazanan atı metoda gönder
                    break; // Döngüden çık
                }
            }
        }


        private void YarisiBitir(At kazananAt)
        {
            // --- 1. İSTATİSTİK GÜNCELLEME ---

            // Eğer kazanan atın ismi listemizde varsa puanını artır
            if (YarisVerileri.AtKazanmaSayilari.ContainsKey(kazananAt.Isim))
            {
                YarisVerileri.AtKazanmaSayilari[kazananAt.Isim]++;
            }
            else
            {
                // Listede yoksa (örn: yeni eklenen bir at) ekle ve 1 yap
                YarisVerileri.AtKazanmaSayilari.Add(kazananAt.Isim, 1);
            }
            // --- 2. HAVUZ HESABI ---
            decimal toplamHavuz = 0;      // Tüm atlara yatırılan toplam para
            decimal kazananAtaYatirlan = 0; // Sadece şampiyon ata yatırılan para

            foreach (var o in _oyuncular)
            {
                toplamHavuz += o.YatirilanMiktar;

                if (o.OynananAtNumarasi == kazananAt.AtNumarasi)
                {
                    kazananAtaYatirlan += o.YatirilanMiktar;
                }
            }

            // --- 3. GANYAN (ORAN) HESAPLAMA ---
            // Gerçek hayattaki formül: Toplam Para / Kazanan Ata Yatırılan Para
            decimal ganyan = 0;

            if (kazananAtaYatirlan > 0)
            {
                ganyan = toplamHavuz / kazananAtaYatirlan;
            }
            else
            {
                // Kimse bilemediyse ganyan hesaplanamaz, para sonraki ayağa devreder (Devir)
                ganyan = 0;
            }

            // --- 4. SONUÇ EKRANI ---
            string sonucMesaji = $"[{DateTime.Now.ToShortTimeString()}] {YarisVerileri.SuankiAyak}. AYAK SONUCU\n";
            sonucMesaji += $"ŞAMPİYON: {kazananAt.Isim.ToUpper()}\n";
            sonucMesaji += $"TOPLAM HAVUZ: {toplamHavuz} TL\n";

            if (ganyan > 0)
                sonucMesaji += $"RESMİ GANYAN (ORAN): {Math.Round(ganyan, 2)}\n"; // Örn: 1'e 4.50 verdi
            else
                sonucMesaji += "KAZANAN OLMADI! PARA DEVRETTİ.\n";

            sonucMesaji += "----------------------------------\n";

            // --- 5. DAĞITIM ---
            bool bizKazandikMi = false;
            decimal bizimKazancimiz = 0;

            foreach (var oyuncu in _oyuncular)
            {
                if (oyuncu.OynananAtNumarasi == kazananAt.AtNumarasi)
                {
                    // Kazanç Formülü: Yatırdığı Para x Ganyan
                    decimal kazanc = Math.Round(oyuncu.YatirilanMiktar * ganyan);

                    sonucMesaji += $"{oyuncu.Ad}: {Math.Round(kazanc, 2)} TL KAZANDI!\n";

                    // Eğer bizsek parayı cüzdana ekle
                    if (!oyuncu.BotMu)
                    {
                        YarisVerileri.OyuncuBakiyesi += kazanc;
                        bizKazandikMi = true;
                        bizimKazancimiz = kazanc;
                    }
                }
                else
                {
                    sonucMesaji += $"{oyuncu.Ad}: Kaybetti...\n";
                }
            }

            // --- 6. SONRAKİ AYAK KONTROLÜ ---
            if (YarisVerileri.SuankiAyak < YarisVerileri.ToplamAyak)
            {
                sonucMesaji += "\n>>> SIRADAKİ AYAK BAŞLIYOR >>>";

                // Eğer kimse bilemediyse, bu para bir sonraki yarışın havuzuna eklenmeli (DEVİR)
                // Bunu yapmak için YarisVerileri'ne 'DevredenPara' diye bir değişken ekleyebilirsin.
                // Şimdilik basitçe uyarı verelim.

                YarisVerileri.SuankiAyak++;
            }
            else
            {
                sonucMesaji += "\n=== GÜNÜN YARIŞLARI SONA ERDİ ===";
                YarisVerileri.TurnuvayiSifirla();
            }

            // --- 7. KAYDET VE GÖSTER ---
            YarisVerileri.Kaydet(sonucMesaji);

            // Kazanma/Kaybetme ses efekti veya özel mesajı
            if (bizKazandikMi)
            {
                MessageBox.Show($"TEBRİKLER! {Math.Round(bizimKazancimiz, 2)} TL KAZANDINIZ!\n\n" + sonucMesaji, "Kazandın!");
            }
            else
            {
                MessageBox.Show("Üzgünüz, bu ayakta kazanamadınız.\n\n" + sonucMesaji, "Sonuçlar");
            }

            Form1 anaForm = (Form1)Application.OpenForms["Form1"];
            if (anaForm != null) anaForm.Show();
            this.Hide();
        }



        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // Tüm atları koştur
            foreach (var at in _atlar)
            {
                at.Kos();

                // Bitiş çizgisini geçti mi kontrolü
                // Atın genişliği + sol konumu >= Bitiş çizgisinin sol konumu
                if (at.ResimKutusu.Right >= lblBitis.Left)
                {
                    timer1.Stop(); // Yarışı durdur
                    YarisiBitir(at); // Kazanan atı metoda gönder
                    break; // Döngüden çık
                }
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Bu kod, açık olan tüm formları ve programı tamamen kapatır.
        }
    }
    }
