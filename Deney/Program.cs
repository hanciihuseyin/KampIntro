// See https://aka.ms/new-console-template for more information

Urun urun1 = new Urun();
urun1.TisortRengi = "Beyaz";
urun1.AyakkabiRengi = "Siyah";
urun1.PantolonRengi = "Mavi";

Urun urun2 = new Urun();
urun2.TisortRengi = "Pembe";
urun2.AyakkabiRengi = "Kırmızı";
urun2.PantolonRengi = "Yeşil";

Urun[] urunler = new Urun[] { urun1, urun2 };
foreach (Urun a in urunler)
{
    Console.WriteLine(a.TisortRengi + " " +
    a.AyakkabiRengi + " " + a.PantolonRengi);
}

class Urun
{
    public string TisortRengi { get; set; }
    public string AyakkabiRengi { get; set; }
    public string PantolonRengi { get; set; }
}
