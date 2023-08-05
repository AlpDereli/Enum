// See https://aka.ms/new-console-template for more information

using System.Diagnostics.SymbolStore;

Console.WriteLine(Gunler.Cumartesi);
Console.WriteLine((int)Gunler.Cumartesi);




int s = 44;
if (s < (int)sicaklik.normal)
{
    Console.WriteLine("Disari cikmak icin havanin isinmasini bekle");
}
if (s>=(int)sicaklik.coksicak)
{
    Console.WriteLine("Sakin disari cikma");
}


enum Gunler
{
    Pazartesi,
    Sali,
    Carsamba,
    Persembe,
    Cuma = 23,
    Cumartesi,
    Pazar
}

enum sicaklik
{
    soguk = 5,
    normal =20,
    sicak = 30,
    coksicak=40
}