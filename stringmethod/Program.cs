

string yazi = "Stardew Valley";
string yazi1 = "Hoşgeldin";

// Yazıdaki karakter sayısını belirtir Length
Console.WriteLine(yazi.Length);

// Ya hep ya hiç ToUpper , ToLower
Console.WriteLine(yazi.ToUpper());
Console.WriteLine(yazi1.ToLower());

// Remove
Console.WriteLine(yazi.Remove(4,5));
Console.WriteLine(yazi1.Remove(6));

// Replace
Console.WriteLine(yazi.Replace("Star","*"));

// Split (Önemli!!!)
Console.WriteLine(yazi.Split(' ')[1]);
