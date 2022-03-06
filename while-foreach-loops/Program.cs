string bosluk = "---------******---------";

// 1'den başlayarak consol da dediğimiz sayıya(sayı dahil) ortalama hesaplayıp console yazdırma

// For

Console.WriteLine("Ekrana bir sayı giriniz");

int sayi = int.Parse(Console.ReadLine());
int toplam = 0;

for (int sayac = 0; sayac <= sayi; sayac++)
{
    toplam += sayac;
}
Console.WriteLine(toplam / sayi);

Console.WriteLine(bosluk);

//While

// 'A' dan 'Z' ye kadar ki tüm harfler

char harf = 'a';

while (harf <= 'z')
{
   Console.Write(harf);
   harf ++; 
}

Console.WriteLine(bosluk);

// Foreach

string[] arabalar = {"Ford","Wolswagen","Vosvos","Bugatti"};

foreach (var araba in arabalar)
{
    Console.WriteLine(araba);
}