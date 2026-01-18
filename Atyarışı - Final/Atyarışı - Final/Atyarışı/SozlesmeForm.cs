using System;
using System.Windows.Forms;

namespace Atyarışı

{
    public partial class SozlesmeForm : Form
    {
        public SozlesmeForm()
        {
            InitializeComponent();
       
            // Sözleşme metnini buraya yazıyoruz
            rtbMetin.Text = "FEHMİ KING AT YARIŞI OYUNU - KULLANICI SÖZLEŞMESİ\n\n" +
                            "1. TARAFLAR\n" +
                            "Bu oyun, eğlence amaçlı yapılmış olup Fehmi King tarafından geliştirilmiştir.\n\n" +
                            "2. SANAL PARA\n" +
                            "Oyunda kullanılan paralar tamamen sanaldır. Gerçek para ile alınıp satılamaz. " +
                            "Kaybedilen bakiyelerden geliştirici sorumlu değildir.\n\n" +
                            "3. HİLE VE BOTLAR\n" +
                            "Oyunda bulunan botlar (Ahmet, Mehmet vb.) tamamen rastgele (Random) algoritmalarla hareket eder. " +
                            "Şike veya hile söz konusu değildir.\n\n" +
                            "4. OYUN KURALLARI\n" +
                            "Bakiye sıfırlanırsa oyun biter. Eğlencesine oynayınız.\n\n" +
                            "İyi Eğlenceler!";
        }


        // CheckBox'a çift tıkla ve bu kodu yaz
        private void chkKabul_CheckedChanged(object sender, EventArgs e)
        {
            // Eğer kutucuk işaretliyse butonu aç, değilse kapat
            btnOnayla.Enabled = chkKabul.Checked;
        }

        // Butona çift tıkla ve bu kodu yaz
        private void btnOnayla_Click(object sender, EventArgs e)
        {
            // Formu "OK" sonucuyla kapat
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}