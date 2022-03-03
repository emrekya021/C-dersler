Console.WriteLine("Selam seçilmiş kişi eğer saat 21:00'den önce ise oyunu kazandın");

int time = DateTime.Now.Hour;

if(time<21){
    Console.WriteLine("Kazandınnn :D");
}else
{
    Console.WriteLine("Kaybettin yarına kadar bekle :[");
}

Console.WriteLine("-------------------xxxxxxxxxxxxxx-------------------");

int time2 = DateOnly.MaxValue.Day;

Console.WriteLine(time2);

Console.WriteLine("-------------------xxxxxxxxxxxxxx-------------------");

int saat = DateTime.Now.Hour;

if(saat == 21){
    Console.WriteLine("Atam Dolma Bahçede");
}else{
    Console.WriteLine("Başka bir zaman geri gel");
}
