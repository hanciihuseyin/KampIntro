// See https://aka.ms/new-console-template for more information

Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.KursunEgitmeni = "Hüseyin Hanci";
kurs1.IzlenmeOrani = 68;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.KursunEgitmeni = "Yunus Tabak";
kurs2.IzlenmeOrani = 64;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.KursunEgitmeni = "Atakan Keçeci";
kurs3.IzlenmeOrani = 80;

Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

foreach (Kurs kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + "   " + kurs.KursunEgitmeni + "   "
        + "   " + kurs.IzlenmeOrani);
}

class Kurs
{
    public string KursAdi { get; set; }
    public string KursunEgitmeni { get; set; }
    public int IzlenmeOrani { get; set; }
}
