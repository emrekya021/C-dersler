// Methodlar

// a ve b yi topla

int a = 5 ;
int b = 4;


int sonuc = topla(a,b);

ekrana_yazdır(Convert.ToString(sonuc));


int topla(int deger1,int deger2)
{
    return(deger1+deger2);
}


void ekrana_yazdır(object yazi){
    Console.WriteLine(yazi);
}