using System;
using System.Windows.Forms;

namespace Atyarışı
{
    public class At
    {
        // Özellikler (Properties)
        public int AtNumarasi { get; set; }
        public string Isim { get; set; }
        public PictureBox ResimKutusu { get; set; } // Formdaki PictureBox'ı buraya bağlayacağız
        public Label IsimEtiketi { get; set; }
        public int Hiz { get; set; }

        private static Random rastgele = new Random();

        // Yapıcı Metot (Constructor)
        public At(int numara, string isim, PictureBox resim, Label etiket)
        {
            AtNumarasi = numara;
            Isim = isim;
            ResimKutusu = resim;
            IsimEtiketi = etiket;

            IsimEtiketi.Text = Isim;
        }

        // Metot: Atın koşmasını sağlar
        public void Kos()
        {
            // Her at her adımda rastgele bir hızla ilerler
            Hiz = rastgele.Next(5, 15);
            ResimKutusu.Left += Hiz;
            IsimEtiketi.Left += Hiz;
        }

        // Metot: Başlangıç noktasına dön
        public void BasaDon()
        {
            ResimKutusu.Left = 0; // Veya başlangıç koordinatı neyse
            IsimEtiketi.Left = 0;
        }
    }
}