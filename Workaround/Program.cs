
using Business.Concrete;
using Entities.Concrete;



Person person1 = new Person();
person1.FirstName = "YAVUZ SELİM";
person1.LastName = "KORKMAZ";
person1.DateOfBirthYear = 2004;
person1.NationalIdentity = 123;



PttManager pttManager = new PttManager(new PersonManager()); //PTT ICIN
pttManager.GiveMask(person1);

EczaneManager eczaneManager = new EczaneManager(new PersonManager()); //ECZANE ICIN
eczaneManager.GiveMask(person1);


/*
static void SelaamVer(string isim="isimsiz") {
    Console.WriteLine("Merhaba "+isim); //void methodlar sadece işi yapar bir şey döndürmez
}


int sonuc = Topla(6,58);

static int Topla(int sayi1,int sayi2=10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : "+sonuc);
    return sonuc;
} 



SelaamVer("Yavuz");
SelaamVer("Mehmet");
SelaamVer("Ayşe");
SelaamVer();



//Diziler / Arrays

string[] ogrenciler = new string[3]; //string ogrenciler stack kısmında new string diyince heap de 3 elemanlı yer oluşur 
ogrenciler[0] = "Engin";
ogrenciler[1] = "Kerem";
ogrenciler[2] = "Yavuz";

ogrenciler = new string[4]; //new gördüğü anda heap de 4 elemanlı yeni bir alan tanımlıyor //garbage collector //array,class,interface,abstract bunların tamamı referans tip
ogrenciler[3] = "ali cabbar";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "ankara", "istanbul", "izmir" }; //101
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" }; //102

sehirler2 = sehirler1;
sehirler1[0] = "adana";
Console.WriteLine(sehirler2[0]);

int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;
Console.WriteLine(sayi2); //int double bool deger tiplerdir her sey stackde her sey deger uzerinden gider 
//refereans tiplerde referans numarasını deger tiplerde deger atıyoruz 


foreach (string sehir in sehirler1) //dizi formatindaki yapilari doner
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> { "Ankara","İstanbul","İzmir"};
yeniSehirler1.Add("İzmer");

foreach(string sehirler in yeniSehirler1)
{
    Console.WriteLine(sehirler);
}


//degiskenler();
static void degiskenler() //refactor method
{
    string mesaj = "selam";
    double tutar = 10000; //database den gelir
    int sayi = 100;
    bool girisYapmisMi = false;

    string ad = "Yavuz";
    string soyad = "Korkmaz";
    int dogumYili = 2005;
    long tcNo = 12345678910; //daha büyük sayı için long  // bunları nesneye (class) alabiliriz


    Console.WriteLine(tutar * 1.18);

    Console.WriteLine(tutar * 1.18);

    Console.ReadLine();
}


Vatandas vatandas1 = new Vatandas();
class Vatandas
{
    public string Ad { get; set; }

    public string Soyad { get; set;}

    public int DogumYili { get; set; }

    public long TcNo { get; set; }

    //PascalCasing
}

*/