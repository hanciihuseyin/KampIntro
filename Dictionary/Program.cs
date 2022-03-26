// See https://aka.ms/new-console-template for more information

Dictionary<string,int> AdYas = new Dictionary<string,int>();

AdYas.Add("Hüseyin", 24);
AdYas.Add("Yunus", 24);
AdYas.Add("Atakan", 23);

foreach (var adyas in AdYas)
{
    Console.WriteLine(adyas);
}

var eleman = AdYas.Count();
Console.WriteLine();
Console.WriteLine(eleman);

AdYas.Remove("Yunus");
Console.WriteLine();
foreach (var adyas in AdYas)
{
    Console.WriteLine(adyas);
}
