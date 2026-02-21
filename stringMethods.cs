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

Console.Write("Email adresinizi girin: ");
string email = Console.ReadLine();

var emailDomainBaslangic = email.IndexOf("@"); 

var emailDomain = email.Substring(emailDomainBaslangic + 1);

Console.WriteLine(emailDomain);