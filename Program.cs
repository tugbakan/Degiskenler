    //                     PATİKA / C#101 / DEGISKENLER ÖDEV
    /*Değişken isimleri:
     string 3degisken; (Rakamla başlayamaz.)
     string class;     (Özel isim olamaz)
     string a+b;       (Operatör içeremez) */

    byte a=5;            // 1 byte
    sbyte b=5;           // 1 byte

    short c=5;           // 2 byte
    ushort d=5;          // 2 byte

    Int16 i16=2;         // 2 byte
    int i=2;             // 4 byte
    Int32 i32=2;         // 4 byte
    Int64 i64=2;         // 8 byte
    uint ui=2;           // 4 byte

    long l=4;            // 8 byte
    ulong ul;            // 8 byte
    
    //Reel Sayılar için:
    float f=5;           // 4 byte
    double dbl=5;        // 8 byte
    decimal dc=5;        // 16 byte

    char ch='2';         //2 byte
    string str = "2";    //Sınırsız

    bool b1=true;
    bool b2=false;

    DateTime dt = DateTime.Now;

    object o1= "x";
    object o2= 'y';
    object o3= 5;
    object o4= 4.5;

    //String Tanımlama Şekilleri:

    string str1="";
    string str2= null;
    string str3=string.Empty;

    string ad= "Tugba";
    string soyad="Kan";
    string tamIsim= ad + " "+ soyad;

    //Integer Tanımlama Şekilleri:

    int int1=2;
    int int2=3;
    int carpim= int1*int2;

    //Boolean Tanımlama Şekilleri:

    bool bool1=10<2; //False döner.
    bool bool2=10>2; //True döner.

    //Değişken Dönüşümleri

    //ToString()
    string str20= "20";
    int int20= 20 ;
    string yeniDeger= str20+ int20.ToString();
    Console.WriteLine(yeniDeger); //Çıktısı 2020

    //Convert.To32
    int yeniDeger2= int20 + Convert.ToInt32(str20);
    Console.WriteLine(yeniDeger2); // Çıktısı 40

    //Parse
    int yeniDeger3= int20 + int.Parse(str20);
    Console.WriteLine(yeniDeger3); //Çıktısı 40

    //DateTime
    string datetime1= DateTime.Now.ToString("dd.MM.yyyy"); // Günü, ayı, yılı aralarına "." koyarak tanımladık.
    string hour1= DateTime.Now.ToString("HH:mm");   //Saati ve dakikayı tanımladık.

    Console.WriteLine(datetime1);
    Console.WriteLine(hour1);