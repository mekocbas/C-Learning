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

