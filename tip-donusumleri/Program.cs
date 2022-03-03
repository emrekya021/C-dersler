//Tip Dönüşümleri

//Explict Conservation (bilinçli dönüşümler)

int x = 5;
byte y = (byte)x;

Console.WriteLine(y);

string c = "Merhaba";
object d = (string)c;

Console.WriteLine(d);


// ToString Methodu

int xx = 6 ;
string yy = xx.ToString();
Console.WriteLine(yy);
