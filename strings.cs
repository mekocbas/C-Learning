/*
    Strings = Karakter Dizileri
*/

/*
    char cinsiyet = 'E';

    string cinsiyet2 = "Erkek";

    string ad = "Ahmet";
    string soyad = "Turan";
    string yas = "20";

    // string concat
    string mesaj = ad +" "+ soyad + " isimli kişi " + yas + " yaşındadır.";

    Console.WriteLine(mesaj);
*/

Console.Write("ad: ");
var ad = Console.ReadLine();

Console.Write("soyad: ");
var soyad = Console.ReadLine();

Console.Write("yaş: ");
var yas = Console.ReadLine();

//string interpolation
string mesaj = $"{ad} {soyad} isimli kişi {yas} yaşındadır.";

Console.WriteLine(mesaj);