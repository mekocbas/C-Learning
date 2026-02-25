/*
    ARİTMATİK OPERATÖRLER
*/

/*
    var a = 10;
    var b = 3;
    var c = 2;

    // var sonuc = a + b;
    // var sonuc = a - b;
    // var sonuc = a * b;
    // var sonuc = a / b;
    // var sonuc = (a + b) * c;
    // var sonuc = a % b; // 10 % 3 = 1 (kalanı verir)
    // var sonuc = a++; 

    Console.WriteLine(sonuc);
*/
//--------------------------------------------------------------------------------------------------------------------------------------
/*
    Soru01

    // a = 10, b = 5, c = 20 ise c - a farkının b katı kaçtır?
*/

/*
    var sonuc = (c-a) * b; (Sonuç 50)
*/
//--------------------------------------------------------------------------------------------------------------------------------------
/*
    Soru 02

    int? a = 50; int b = 20; ise a + b değerini hesaplayınız. (eğer null ise sonuç nedir?)
*/

/*
    int? a = null;
    int b = 20;

    var sonuc = (a ?? 0) + b;
*/
//--------------------------------------------------------------------------------------------------------------------------------------
/*
    Soru 03

    a=10; b=20; ise a=b--; atamasından sonra a ve b değerleri ne olur?
*/

/*
int a = 10;
int b = 20;
a=b--;

Console.WriteLine(a);
Console.WriteLine(b);

Sonuç a= 20 b=19
*/
//--------------------------------------------------------------------------------------------------------------------------------------
/*
    Soru 04

    Klavyeden girilen bir sayının tek / çift kontrolünü yapınız.
*/

/*
    Console.Write("Sayı: ");
    int sayi = Convert.ToInt32(Console.ReadLine());

    var sonuc = sayi % 2;

    Console.WriteLine(sonuc);
*/
//--------------------------------------------------------------------------------------------------------------------------------------
/*
    Soru 05

    int a = 5;
    int b = 2;

    int sonuc = a++ * ++b;

    İşlem bittikten sonra:
    a kaç?
    b kaç?
    sonuc kaç?
*/

/*
    int a = 5;
    int b = 2;

    int sonuc = a++ * ++b;

    Cevap
    a = 6
    b = 3
    sonuc = 15
*/
//--------------------------------------------------------------------------------------------------------------------------------------
/*
    Soru 06

int a = 10;
    int b = 3;

    int sonuc = a / b + a % b * 2;
*/

int a = 10;
int b = 3;

int sonuc = a / b + a % b * 2;

Console.WriteLine(sonuc);





