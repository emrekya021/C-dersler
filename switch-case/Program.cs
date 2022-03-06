// Ayları tahmin etmek

int month = DateTime.Now.Month;

switch (month)
{
    case 3:
    Console.WriteLine("Mart Ayındasınız");
    break;
    
    default:
    break;
}



switch (month)
{
    case 3:
    case 4:
    case 5:
    Console.WriteLine("İlkbahar Mevsimindesiniz");
    break;
    
    case 6:
    case 7:
    case 8:
    Console.WriteLine("Yaz Mevsimindesiniz");
    break;

    case 9:
    case 10:
    case 11:
    Console.WriteLine("Sonbahar Mevsimindesiniz");
    break;

    case 12:
    case 1:
    case 2:
    Console.WriteLine("Kış Mevsimindesiniz");
    break;
    
    default:
    break;
}