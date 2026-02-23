/*
    String Methods
*/

/*
    string mesaj =  "Ahmet Turan isimli kişi 20 yaşındadır.";

    // var sonuc = mesaj.Length;           //Length string'in toplam karakter sayısını verir. //Boşluklar ve nokta da dahil edilir.
    // var sonuc = mesaj.ToLower();        //Tüm harfleri küçük yapar.
    // var sonuc = mesaj.ToUpper();        //Tüm harfleri büyük yapar.
    // var sonuc = mesaj.Trim();           //String’in başındaki ve sonundaki boşlukları siler.
    // var sonuc = mesaj.Split(" ")[0];    //String’i verilen karaktere göre böler. //Burada " " yani boşluğa göre bölüyor. //Split() bir dizi (array) döndürür. //[0] ilk kelimeyi alır.
    // var sonuc = mesaj[0];               //String’in ilk karakterini verir.
    // var sonuc = mesaj.StartsWith("B");  //String verilen değerle başlıyor mu kontrol eder.
    // var sonuc = mesaj.EndsWith(".");    //String verilen değerle bitiyor mu kontrol eder.
    // var sonuc = mesaj.Contains("Ali");  //İçinde verilen kelime var mı kontrol eder.
    // var sonuc = mesaj.IndexOf("abc");   //Verilen değerin başladığı indexi verir. //Bulamazsa -1 döner.
    // var sonuc = mesaj.Substring(6,5);   //Belirtilen index’ten başlayarak belirtilen kadar karakter alır.

    Console.WriteLine(sonuc);
*/
//-------------------------------------------------------------------------------------------------------------------------------
/*
    Soru 01

    Gizli Boşluk

    Kullanıcıdan isim al.

    Kullanıcı başına ve sonuna boşluk koyabilir.

    İsmi temizleyip (Trim) kaç karakter olduğunu yazdır.
*/

/*
    Console.Write("İsim girin: ");
    string isim = Console.ReadLine();

    isim = isim.Trim();

    int karakter = isim.Length;

    Console.WriteLine($"İsim {karakter} tane harften oluşuyor.");
*/
//-------------------------------------------------------------------------------------------------------------------------------
/*
    Soru 02

    Domain Ayıklama

    Kullanıcıdan bir e-posta al.

    Örnek:
    enes@gmail.com

    Sadece domain kısmını yazdır:
    gmail.com
*/

/*
    Console.Write("Email adresinizi girin: ");
    string email = Console.ReadLine();

    var emailDomainBaslangic = email.IndexOf("@"); 

    var emailDomain = email.Substring(emailDomainBaslangic + 1);

    Console.WriteLine(emailDomain);
*/
//-------------------------------------------------------------------------------------------------------------------------------
/*
    Soru 03

    Kullanıcı Adı Üretme

    Kullanıcıdan ad ve soyad al.

    Kullanıcı adı üret:
    adın ilk 3 harfi
    soyadın ilk 3 harfi
    hepsi küçük harf

    Örnek:
    Ahmet Turan

    Çıktı:
    ahmtur
*/

/*
    Console.Write("Ad: ");
    string ad = Console.ReadLine();

    Console.Write("Soyad: ");
    string soyad = Console.ReadLine();

    string adYeni = ad.Substring(0,3);
    string soyadYeni = soyad.Substring(0,3);
    string kullaniciAdi = adYeni+soyadYeni;
    kullaniciAdi = kullaniciAdi.ToLower();

    Console.WriteLine("Kullanıcı adı: " + kullaniciAdi);
*/
//-------------------------------------------------------------------------------------------------------------------------------
/*
    Soru 04

    İlk Kelimeyi Büyük Yap

    Kullanıcıdan bir cümle al.

    Sadece ilk kelimenin ilk harfini büyük yap.

    Örnek:
    ahmet turan yazılım öğreniyor

    Çıktı:
    Ahmet turan yazılım öğreniyor
*/

/*
    Console.Write("Bir cümle girin: ");
    string mesaj = Console.ReadLine();

    string ilkHarf = mesaj.Substring(0,1).ToUpper();
    string geriKalan = mesaj.Substring(1);

    string sonuc = ilkHarf + geriKalan;

    Console.WriteLine(sonuc);
*/
//-------------------------------------------------------------------------------------------------------------------------------
/* 
Soru 05

string kursAdi = ".Net 7 ile C# Programlama Dili";

1- Kaç karaktere sahiptir?
2- Hepsini küçük harf yapınız.
3- '.' ile mi başlamaktadır?
4- C# bilgisi hangi konumda bulunmaktadır?
5- String 'C#' bilgisini içeriyor mu?
6- 'Dili' kelimesi yerine 'Dersleri' yazınız. (replace)
*/

string kursAdi = ".Net 7 ile C# Programlama Dili";

Console.WriteLine($"Bu yazı {kursAdi.Length} karaktere sahip.");
Console.WriteLine(kursAdi.ToLower());
Console.WriteLine($"Cümle . ile mi başlıyor " + kursAdi.StartsWith("."));
Console.WriteLine($"C# yazısının konumu " + kursAdi.IndexOf("C#"));
Console.WriteLine($"Cümle 'C#' bilgisi içeriyor mu? " + kursAdi.Contains("C#"));
var guncel = kursAdi.Replace("Dili","Dersleri");
Console.WriteLine(guncel);
