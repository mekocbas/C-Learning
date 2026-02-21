/*
    Strings = Karakter Dizileri
*/

/*
    char cinsiyet = 'E'; // Tek bir karakter tutar. Tek tırnak kullanılır (' ')
                         // char sadece 1 harf saklar.

    string cinsiyet2 = "Erkek"; // Tek bir karakter tutar. Tek tırnak kullanılır (' ')
                                // char sadece 1 harf saklar.

    string ad = "Ahmet";
    string soyad = "Turan";
    string yas = "20";

    // string concat (concatenation = birleştirme)
    string mesaj = ad +" "+ soyad + " isimli kişi " + yas + " yaşındadır.";

    Console.WriteLine(mesaj);
*/

/*
    Console.Write("ad: ");
    var ad = Console.ReadLine(); // Kullanıcının yazdığı değeri okur.
                                 // var otomatik tip belirler (burada string olur).

    Console.Write("soyad: ");
    var soyad = Console.ReadLine();

    Console.Write("yaş: ");
    var yas = Console.ReadLine(); // Kullanıcıdan yaş alır (string olarak).

    //string interpolation
    string mesaj = $"{ad} {soyad} isimli kişi {yas} yaşındadır.";
    // $ işareti string interpolation başlatır.
    // {} içine değişken yazılır.
    // Bu yöntem + ile birleştirmeden daha temiz ve okunaklıdır.

    Console.WriteLine(mesaj);
*/
//---------------------------------------------------------------------------------------------
/*
    Çalışma 01

    String Birleştirme (Concat)

    Kullanıcıdan:
    Ad
    Soyad
    Meslek

    Bilgilerini al ve + operatörü kullanarak şu formatta yazdır:
    Ahmet Turan isimli kişi Yazılımcı olarak çalışıyor.
*/

/*
    Console.Write("Ad: ");
    string ad = Console.ReadLine();

    Console.Write("Soyad: ");
    string soyad = Console.ReadLine();

    Console.Write("Meslek: ");
    string meslek = Console.ReadLine();

    string mesaj = ad + " " + soyad + " isimli kişi " + meslek + " olarak çalışıyor.";
    Console.WriteLine(mesaj);
*/
//---------------------------------------------------------------------------------------------
/*
    Çalışma 02

    String Interpolation

    Bu sefer aynı şeyi yap ama:
    Ad
    Soyad
    Doğum yılı
    Al.

    Kişinin yaşını hesapla (2026 - doğumYili).

    Ve interpolation kullanarak şöyle yazdır:
    Ahmet Turan 26 yaşındadır.

    ⚠️ Burada yaş int olmalı. String değil.
*/

/*
    Console.Write("Ad: ");
    string ad = Console.ReadLine();

    Console.Write("Soyad: ");
    string soyad = Console.ReadLine();

    Console.Write("Doğum Yılı: ");
    int dogumYili = Convert.ToInt32(Console.ReadLine());

    int yas = 2026 - dogumYili;

    string mesaj = $"{ad} {soyad} {yas} yaşındadır";

    Console.WriteLine(mesaj);
*/
//---------------------------------------------------------------------------------------------
/*
    Çalışma 03

    Tip Dönüşümü

    Kullanıcıdan iki sayı al.

    Ama Console.ReadLine() string döndürür biliyorsun.

    Bu iki sayıyı toplayıp sonucu yazdır.

    Örnek:

    Sayı 1: 5
    Sayı 2: 7
    Toplam: 12
*/

/*
    Console.WriteLine("2 adet sayı girin.");

    Console.Write("1.Sayı: ");
    int sayi1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("2.Sayı: ");
    int sayi2 = Convert.ToInt32(Console.ReadLine());

    int toplam = sayi1 + sayi2;

    Console.WriteLine(toplam);
*/
//---------------------------------------------------------------------------------------------
/*
    Büyük Harfli İsim Formatı

    Kullanıcıdan:
    ad
    soyad
    Al.

    Sonra şu formatta yazdır:
    A.Turan
*/

/*
    Console.Write("Ad: ");
    string ad = Console.ReadLine();

    Console.Write("Soyad: ");
    string soyad = Console.ReadLine();

    string mesaj = $"{ad[0]}.{soyad}";

    Console.WriteLine(mesaj);
*/
//---------------------------------------------------------------------------------------------
/*
    Kullanıcı Mesaj Oluşturma

    Kullanıcıdan:
    ad
    soyad
    şehir
    Al.

    Ve şu şekilde yazdır:
    Merhaba ben Ahmet Turan, İstanbul şehrinde yaşıyorum.
*/

/*
    Console.WriteLine("Merhaba, ad, soyad ve şehir bilgisi girin ve sizin için mesaj oluşturalım.");

    Console.Write("Ad: ");
    string ad = Console.ReadLine();

    Console.Write("Soyad: ");
    string soyad = Console.ReadLine();

    Console.Write("Şehir: ");
    string sehir = Console.ReadLine();

    string mesaj = $"Merhaba ben {ad} {soyad}, {sehir} şehrinde yaşıyorum.";

    Console.WriteLine(mesaj);
*/
//---------------------------------------------------------------------------------------------
