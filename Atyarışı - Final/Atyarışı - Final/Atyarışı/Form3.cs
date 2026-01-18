using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atyarışı
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // 1. Önce kutuyu temizle
            rtbGecmis.Clear();

            // 2. Kayıt var mı kontrol et
            if (YarisVerileri.GecmisSonuclar.Count == 0)
            {
                rtbGecmis.Text = "Henüz tamamlanmış bir yarış kaydı bulunmamaktadır.";
                return;
            }

            // 3. Dosyadan/Listeden gelen verileri tersten yazdıralım 
            // (Böylece en son yarış en üstte görünür)
            for (int i = YarisVerileri.GecmisSonuclar.Count - 1; i >= 0; i--)
            {
                string kayit = YarisVerileri.GecmisSonuclar[i];

                // Araya görsellik olsun diye çizgi ekleyelim
                rtbGecmis.AppendText(kayit + "\n");
                rtbGecmis.AppendText("============================================\n\n");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // Kullanıcıya soralım: Emin misin?
            DialogResult cevap = MessageBox.Show("Tüm geçmiş yarış kayıtları kalıcı olarak silinecek.\nEmin misiniz?",
                                                 "Geçmişi Sil",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {
                // 1. Verileri temizle (Dosya + Liste)
                YarisVerileri.GecmisiTemizle();

                // 2. Ekrandaki kutuyu (RichTextBox) temizle
                rtbGecmis.Clear();
                rtbGecmis.Text = "Kayıtlar başarıyla silindi.";

                MessageBox.Show("Geçmiş tertemiz oldu!", "Bilgi");
            }
        }
    }
}
