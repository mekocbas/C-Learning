/*
    C# Veri Tipleri

    Value Types:
        Tam sayı:            byte, short, int, long
        Ondalıklı sayılar:   float, double, decimal
        Diğer Veri Tipleri:  char, boolean, struct

    Reference Types:
        String, Class, Array, Interface
*/

/*
    Veri Tipi Dönüşümü
    // implicit casting => bilinçsiz tür dönüşümü
    // explicit casting => bilinçli tür dönüşümü
*/

int a = 10;
long b = a;

long d = 20;
int e = (int)d;

double f = 20.5;
float g = (float)f;

double h = 10.5;
int i = (int)h;