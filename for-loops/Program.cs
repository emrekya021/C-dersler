
Console.WriteLine("Bir Sayı Giriniz ;");

int sayi = int.Parse(Console.ReadLine());

int teksayi = 0;

for (int i = 0; i < sayi; i++)
{
    if (i%2 == 1)
    {
        teksayi += i;  
    
    }

}
    Console.WriteLine(teksayi); 

Console.WriteLine("--------------***************----------------");

for (int a = 1; a < 10; a++)
{
    
    if(a == 4)
    break;
    Console.WriteLine(a);
    
}

Console.WriteLine("--------------***************----------------");

for (int a = 1; a < 10; a++)
{
    
    if(a == 4)
    continue;
    Console.WriteLine(a);
    
}