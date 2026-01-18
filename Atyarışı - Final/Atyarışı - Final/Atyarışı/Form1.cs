using Atyarışı;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Atyarışı
{
    public partial class Form1 : Form
    {
        bool sozlesmeImzalandi = false; // Başlangıçta imzalanmamış (false) kabul ediyoruz
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            YarisVerileri.VerileriYukle();
            YarisVerileri.IstatistikleriSifirla();

            AtIsimleriniYukle();
            BotlariHazirla();
            lblBakiye.Text = "BAKİYE: " + YarisVerileri.OyuncuBakiyesi.ToString() + " TL";
        }

        private void AtIsimleriniYukle()
        {
            // Comboboxlara at isimlerini dolduralım
            string[] atlar = { "Şahbatur", "Gülbatur", "Rüzgar", "Poyraz", "Karayel" };

            ComboBox[] combos = { cmbAt1, cmbAt2, cmbAt3, cmbAt4, cmbAt5 };

            foreach (var combo in combos)
            {
                combo.Items.AddRange(atlar);
            }
        }

        private void BotlariHazirla()
        {
            // 1. Oyuncu sensin, o yüzden textbox1 boş kalsın.
            // 2, 3, 4 ve 5. satırlar BOT olacak.

            Random rnd = new Random();

            // Bot İsimleri
            txtAd2.Text = "Bot Ahmet";
            txtAd3.Text = "Bot Mehmet";
            txtAd4.Text = "Bot Ayşe";
            txtAd5.Text = "Bot Fatma";

            // Botlar Rastgele At Seçsin ve Para Yatırsın
            ComboBox[] botCombos = { cmbAt2, cmbAt3, cmbAt4, cmbAt5 };
            NumericUpDown[] botMiktarlar = { nudMiktar2, nudMiktar3, nudMiktar4, nudMiktar5 };

            for (int i = 0; i < 4; i++)
            {
                // Rastgele at seçimi (0-4 arası index)
                botCombos[i].SelectedIndex = rnd.Next(0, 5);

                // Rastgele miktar (10 ile 100 arası)
                botMiktarlar[i].Value = rnd.Next(10, 991) * 100;
            }
        }

        private void btnYarisiBaslat_Click(object sender, EventArgs e)
        {
            if (sozlesmeImzalandi == false)
            {
                MessageBox.Show("Yarışa girmek için önce 'ÖN SÖZLEŞME'yi onaylamanız gerekmektedir!",
                                "Eksik İşlem",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Burası çok önemli: Kodu burada keser, aşağıya inmez.
            }
            // 1. Oyuncu (Sen) verilerini kontrol et
            if (string.IsNullOrEmpty(txtAd1.Text) || cmbAt1.SelectedIndex == -1 || nudMiktar1.Value == 0)
            {
                MessageBox.Show("Lütfen kendi bilgilerinizi eksiksiz girin!");
                return;
            }
            decimal oynananMiktar = nudMiktar1.Value;
            if (oynananMiktar <= 0)
            {
                MessageBox.Show("Lütfen bir bahis miktarı girin!");
                return;
            }
            if (oynananMiktar > YarisVerileri.OyuncuBakiyesi)
            {
                MessageBox.Show($"Yetersiz Bakiye!\nŞu anki paranız: {YarisVerileri.OyuncuBakiyesi} TL\nLütfen daha düşük bir miktar girin.", "Hata");
                return;
            }
            if (YarisVerileri.SuankiAyak == 1)
            {
                YarisVerileri.OyuncuPuanlari.Clear();
                YarisVerileri.BuyukHavuz = 0;

                // Senin puanını sıfırla
                YarisVerileri.OyuncuPuanlari.Add(txtAd1.Text, 0);

                // Botların puanını sıfırla (Bot isimlerini kodunda nasıl tuttuğuna göre değişir ama genelde sabittir)
                // Eğer bot isimlerin sabitse direkt şöyle ekle:
                YarisVerileri.OyuncuPuanlari.Add("Bot Ahmet", 0);
                YarisVerileri.OyuncuPuanlari.Add("Bot Mehmet", 0);
                YarisVerileri.OyuncuPuanlari.Add("Bot Ayşe", 0);
                YarisVerileri.OyuncuPuanlari.Add("Bot Fatma", 0);
            }
            YarisVerileri.OyuncuBakiyesi -= oynananMiktar; // Parayı düş
            lblBakiye.Text = "BAKİYE: " + YarisVerileri.OyuncuBakiyesi.ToString() + " TL"; // Ekrani güncelle


            // Tüm oyuncuları bir listeye alıp Form2'ye göndereceğiz
            List<Bahis> oyuncular = new List<Bahis>();

            // Senin Bilgilerin
            oyuncular.Add(new Bahis(txtAd1.Text, cmbAt1.SelectedIndex + 1, nudMiktar1.Value, false));

            // Botların Bilgileri (Döngüyle de alınabilir ama senin kontrol isimlerine göre tek tek yazalım daha net olsun)
            oyuncular.Add(new Bahis(txtAd2.Text, cmbAt2.SelectedIndex + 1, nudMiktar2.Value, true));
            oyuncular.Add(new Bahis(txtAd3.Text, cmbAt3.SelectedIndex + 1, nudMiktar3.Value, true));
            oyuncular.Add(new Bahis(txtAd4.Text, cmbAt4.SelectedIndex + 1, nudMiktar4.Value, true));
            oyuncular.Add(new Bahis(txtAd5.Text, cmbAt5.SelectedIndex + 1, nudMiktar5.Value, true));

            // Form2'yi aç ve verileri gönder
            Form2 yarisFormu = new Form2(oyuncular);
            yarisFormu.Show();
            this.Hide(); // Form1'i gizle
        }

        private void GecmisYarislar_Click(object sender, EventArgs e)
        {
            Form3 gecmisPenceresi = new Form3();
            gecmisPenceresi.ShowDialog(); // ShowDialog, pencere kapanmadan arkaya tıklanmasını engeller.
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            lblBakiye.Text = "BAKİYE: " + YarisVerileri.OyuncuBakiyesi.ToString() + " TL";
            lblAyakBilgisi.Text = $"{YarisVerileri.SuankiAyak}. AYAK / {YarisVerileri.ToplamAyak}";

            // Eğer final ayağıysa kullanıcıyı gaza getir
            if (YarisVerileri.SuankiAyak == YarisVerileri.ToplamAyak)
            {
                lblAyakBilgisi.Text =  "     (FİNAL!)";
                lblAyakBilgisi.BackColor = Color.Red;   // Arka plan Kırmızı
                lblAyakBilgisi.ForeColor = Color.White;
            }
            else
            {
                // --- NORMAL İSE: SPOR LACİVERTİ ---
                lblAyakBilgisi.BackColor = Color.DarkSlateBlue; // Şık bir Lacivert
                lblAyakBilgisi.ForeColor = Color.White;         // Yazı Beyaz
            }
        }


        private void btnOnSozlesme_Click(object sender, EventArgs e)
        {
            // Sözleşme formunu oluştur
            SozlesmeForm sozlesme = new SozlesmeForm();

            // Formu "Diyalog" olarak aç (Yani bu kapanmadan arkaya tıklanamaz)
            // Ve sonucun "OK" olup olmadığını kontrol et
            if (sozlesme.ShowDialog() == DialogResult.OK)
            {
                sozlesmeImzalandi = true;
                MessageBox.Show("Sözleşme başarıyla imzalandı!", "Bilgi");

                // Butonu yeşil yap ve metnini değiştir
                Button btn = (Button)sender; // Tıklanan butonu yakala
                btn.BackColor = System.Drawing.Color.LightGreen;
                btn.Text = "SÖZLEŞME\nONAYLANDI";
                btn.Enabled = false; // Artık tekrar tıklanmasın
            }
        }

        
            private void btnIstatistik_Click(object sender, EventArgs e)
        {
            string mesaj = "🏆 ATLARIN PERFORMANS DURUMU 🏆\n";
            mesaj += "----------------------------------\n";

            string enCokKazananIsim = "";
            int enYuksekSayi = -1;

            // Listeyi döngüyle gez
            foreach (var veri in YarisVerileri.AtKazanmaSayilari)
            {
                mesaj += $"{veri.Key}: {veri.Value} Galibiyet\n";

                // En çok kazananı bulma mantığı
                if (veri.Value > enYuksekSayi)
                {
                    enYuksekSayi = veri.Value;
                    enCokKazananIsim = veri.Key;
                }
            }

            mesaj += "----------------------------------\n";

            if (enYuksekSayi > 0)
            {
                mesaj += $"👑 ŞU ANKİ KRAL: {enCokKazananIsim.ToUpper()} ({enYuksekSayi} Galibiyet)";
            }
            else
            {
                mesaj += "Henüz hiçbir at yarış kazanmadı.";
            }

            MessageBox.Show(mesaj, "İstatistikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    }

