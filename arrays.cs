/*
Tek Boyutlu Diziler
*/

/*
    string[] adlar = new string[5];

    adlar[0] = "Ahmet";
    adlar[1] = "Ali";
    adlar[2] = "Ayşe";
    adlar[3] = "Hasan";
    adlar[4] = "Canan";

    string[] adlar = {"Ahmet","Ali","Ayşe","Hasan","Canan"};
*/
//-------------------------------------------------------------------------------------------------------------------------------

/*
Çok Boyutlu Diziler
*/

/*
int[,] sayilar = new int[3,5];

sayilar[0,0] = 10;  sayilar[1,0] = 10;  sayilar[2,0] = 10; 
sayilar[0,1] = 20;  sayilar[1,1] = 20;  sayilar[2,1] = 20; 
sayilar[0,2] = 30;  sayilar[1,2] = 30;  sayilar[2,2] = 30; 
sayilar[0,3] = 40;  sayilar[1,3] = 40;  sayilar[2,3] = 40; 
sayilar[0,4] = 50;  sayilar[1,4] = 50;  sayilar[2,4] = 50; 

int[,] sayilar = {
    {10,20,30,40,50}
    {10,20,30,40,50}
    {10,20,30,40,50}
};
*/

/*
    Soru 01

    // öğrenciler ve notlar isminde 2 tane dizi oluşturunuz ve dizi elemanlarını kullanıcıdan aldığınız değerlerle doldurunuz. (3 öğrenci)

    // öğrenciler dizisi kaç elemanlıdır, yazdırınız.
    //  ilk 2 öğrencinin ad ve not bilgisini yazdırınız.
    // tüm öğrencilerin not ortalaması nedir?
*/

/*
    var ogrenciler = new string[3];
    var notlar = new int[3];

    Console.Write("1.öğrenci adı: ");
    ogrenciler[0] = Console.ReadLine() ?? "Öğrenci adı girilmedi";

    Console.Write("1.öğrenci notu: ");
    notlar[0] = Convert.ToInt32(Console.ReadLine());

    Console.Write("2.öğrenci adı: ");
    ogrenciler[1] = Console.ReadLine() ?? "Öğrenci adı girilmedi";

    Console.Write("2.öğrenci notu: ");
    notlar[1] = Convert.ToInt32(Console.ReadLine());

    Console.Write("3.öğrenci adı: ");
    ogrenciler[2] = Console.ReadLine() ?? "Öğrenci adı girilmedi";

    Console.Write("3.öğrenci notu: ");
    notlar[2] = Convert.ToInt32(Console.ReadLine());

    foreach (var ogrenci in ogrenciler[..2])
    {
        Console.WriteLine(ogrenci);
    }

    foreach (var not in notlar[..2])
    {
        Console.WriteLine(not);
    }

    Console.WriteLine($"Öğrenciler dizisi {ogrenciler.Length} elemanlıdır.");

    var not1 = notlar[0];
    var not2 = notlar[1];
    var not3 = notlar[2];

    var ortalama = (not1 + not2 + not3) / 3;

    Console.WriteLine($"Öğrencilerin nor ortalaması: {ortalama}");
*/
