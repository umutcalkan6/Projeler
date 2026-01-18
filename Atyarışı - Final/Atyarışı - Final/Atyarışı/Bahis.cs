namespace Atyarışı
{
    public class Bahis
    {
        public string Ad { get; set; }
        public int OynananAtNumarasi { get; set; } // Hangi ata oynadı?
        public decimal YatirilanMiktar { get; set; }
        public bool BotMu { get; set; } // Bu kişi bot mu gerçek oyuncu mu?

        // Yapıcı Metot
        public Bahis(string ad, int atNo, decimal miktar, bool botMu)
        {
            Ad = ad;
            OynananAtNumarasi = atNo;
            YatirilanMiktar = miktar;
            BotMu = botMu;
        }
    }
}