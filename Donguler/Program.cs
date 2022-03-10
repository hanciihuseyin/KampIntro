// See https://aka.ms/new-console-template for more information

string kurs1 = "Yazılım Geliştirici Kampı";
string kurs2 = "Programlamaya başlangıç için temel kurs";
string kurs3 = "Java";

Console.WriteLine(kurs1);
Console.WriteLine(kurs2);   
Console.WriteLine(kurs3);

Console.WriteLine("");

string[] kurslar = new string[] { "Programlamaya başlangıç için temel kurs",
    "Yazılım Geliştirici Kampı", 
    "Java"};


for (int i =0; i<kurslar.Length; i++)
{
    Console.WriteLine(kurslar[i]);
}
Console.WriteLine("");
Console.WriteLine("for bitti");
Console.WriteLine("");
foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}

Console.WriteLine("");
Console.WriteLine("Sayfa Sonu - footer");

 
