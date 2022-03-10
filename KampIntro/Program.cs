// See https://aka.ms/new-console-template for more information

string kategoriEtiketi = "Kategori";



int ogrenciSayisi = 32000;
double faizOrani = 1.45;
bool sistemeGirisYapmısMi = false;
double dolarDun = 7.35;
double dolarBugun = 7.45; 

if (dolarDun>dolarBugun)
{
    Console.WriteLine("Azalış butonu.");
}
else if (dolarDun<dolarBugun)
{
    Console.WriteLine("Artış butonu.");
}
else
{
    Console.WriteLine("Değişmedi");
}


if (sistemeGirisYapmısMi == true)
{
    Console.WriteLine("Kullanıcı ayarları butonu");
}
else
{
    Console.WriteLine("Giriş yap butonu");
}
Console.WriteLine(kategoriEtiketi);