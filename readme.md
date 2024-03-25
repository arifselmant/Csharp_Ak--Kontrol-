# CSharp 3.Proje 
# Arif Selman Telli
## Yamanevler Enderun Bilişim

 ##  Proje1 Kullanıcıdan iki sayı ve bir işlem (+, -, x, /) isteyen ve ardından işlem hesaplayıp sonucu ekrana yazan br C# programı yazınız. 
 ```c#
Console.WriteLine("Bir Sayı Giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bir Sayı Giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hangi İşlemi Yapmak İstersiniz");
Console.WriteLine("1.Toplama");
Console.WriteLine("2.Çıkarma");
Console.WriteLine("3.Çarpma");
Console.WriteLine("4.Bölme");

string işlem = Console.ReadLine();

if (işlem == "1");
{
    Console.WriteLine($"{sayi1} + {sayi2} = {sayi1 + sayi2}");
}

if (işlem == "2");

{
    Console.WriteLine($"{sayi1} - {sayi2} = {sayi1 - sayi2}");
}

if (işlem == "3");

{
    Console.WriteLine($"{sayi1} * {sayi2} = {sayi1 * sayi2}");
}

if (işlem == "4");

{
    Console.WriteLine($"{sayi1} / {sayi2} = {sayi1 / sayi2}");
}
````
## Proje2
## Kullanıcıdan iki sayı ve bir şlem (+, -, x, /) sembolü isteyen ve ardından işlem hesaplayıp sonucu ekrana yazan br C# programı yazınız.Eğer işlem sembolü öncek sembollerden farklıysa, "Tanınmayan karakter" metnn gösternz.


```c#
Console.WriteLine("1. Sayıyı Giriniz");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("2. Sayıyı Giriniz");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Hangi İşlemi Yapmak İstersiniz");
Console.WriteLine("1. Toplama");
Console.WriteLine("2. Çıkarma");
Console.WriteLine("3. Çarpma");
Console.WriteLine("4. Bölme");

string selection = Console.ReadLine();
switch (selection)

case "1":
Console.WriteLine($"{number1} + {number2} = {number1 + number2}");  
break;

case "2":
Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
break;
 
case "3":
Console.WriteLine($"{number1} * {number2} = {number1 * number2}");
break;

case "4":
Console.WriteLine($"{number1} / {number2} = {number1 / number2}");
break; 
````
## Proje3

##Bir sayı (x) isteyen ve bu sayının pozitif mi yoksa negatif mi olduğunu yanıtlayan br C# programı yazın.

````c#
Console.WriteLine("Bir Sayı Giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());

if (sayi >= 0)
{
    Console.WriteLine("Sayınız Pozitif");
}

if (sayi < 0)

    Console.WriteLine("Sayınız Negatif");
````


## Proje4
## C# dilinde iki sayıyı (x, y) isteyen ve en büyüğünü görüntüleyen bir program yazın. 

````c# 
Console.WriteLine("Birinci sayıyı girin."); 
     sayi1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("İkinci sayıyı girin.");
     sayi2 = Convert.ToInt32(Console.ReadLine());

    if(sayi1 > sayi2)
    Console.WriteLine("1. sayı olan {0} daha büyük.",sayi1);
    else
    Console.WriteLine("2. sayı olan {0} daha büyük.", sayi2);
````

## Proje5
## C#'ta br sayı (x) isteyen ve 10 * x' görüntüleyen bir program oluşturun. Kullanıcı 0 girene kadar tekrarlanmalıdır. 
```c#
    Console.WriteLine("Birinci Sayıyı Giriniz:"); 

    int x = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("İkinci Sayıyı Giriniz:");
    int y = Convert.ToInt32(Console.ReadLine());
    while (x <= y) 
{    Console.WriteLine(x++); }

````

## Proje6

## Kullanıcıdan bir diz sayı (x, y) talep eden ve bunları ekranda görüntüleyen br C# programı oluşturun.

```c#	

        Console.Write("Başlangıç sayısını giriniz: ");
        int baslangic = Convert.ToInt32(Console.ReadLine());

        Console.Write("Bitiş sayısını giriniz: ");
        int bitis = Convert.ToInt32(Console.ReadLine());

        for (int i = baslangic; i <= bitis; i++)
        {
            Console.WriteLine(i);
        }
    


  
````
# Proje7

## C# dilinde sayı isteyen ve toplamlarını gösteren bir program yazın. Kullanıcı 0 girene kadar numara isteyn ve program bittğinde Bitti gösterlin
````C#
int toplam = 0;
        Console.WriteLine("Sayıları giriniz (Çıkmak için 0 giriniz):");

        
        for (int sayi = Convert.ToInt32(Console.ReadLine()); sayi != 0; sayi = Convert.ToInt32(Console.ReadLine()))
        {
            toplam += sayi;
        }

        
        
        int sayi = Convert.ToInt32(Console.ReadLine());
        while (sayi != 0)
        {
            toplam += sayi;
            sayi = Convert.ToInt32(Console.ReadLine());
        }
        

        Console.WriteLine($"Toplam: {toplam}");
        Console.WriteLine("Bitti");
````

## Proje 8
## Kullanıcıdan 5 tam sayı steyen ve aşağıdak matematksel statstkler ekranda görüntüleyen br C# programı oluşturun 

````c#
Console.WriteLine("Bir Sayı Giriniz");
int sayı1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bir Sayı Giriniz");
int sayı2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bir Sayı Giriniz");
int sayı3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bir Sayı Giriniz");
int sayı4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bir Sayı Giriniz");
int sayı5 = Convert.ToInt32(Console.ReadLine());

int ortalama = (sayı1 + sayı2 + sayı3 + sayı4 + sayı5 /5);
int toplama = (sayı1 + sayı2 + sayı3 + sayı4 + sayı5);
Console.WriteLine("Girdiğiniz Sayıların Toplamı "+toplama);
Console.WriteLine("Girdiğiniz Sayıların Ortalaması "+ortalama);

if (sayı1>sayı2 && sayı1>sayı3 && sayı1>sayı4 && sayı1>sayı5)
{
Console.WriteLine("Girdiğiniz Sayıların En Büyüğü"+sayı1);
}

if (sayı2>sayı3 && sayı2>sayı4 && sayı2>sayı1 && sayı2>sayı5)
{
    Console.WriteLine("En Büyük Sayı"+sayı2);
}
if (sayı3>sayı4 && sayı3>sayı1 && sayı3>sayı2 && sayı3>sayı5)
{
    Console.WriteLine("En BüYÜK Sayı"+sayı3);
}
if (sayı4>sayı1 && sayı4>sayı2 && sayı4>sayı3 && sayı4>sayı5)
{
    Console.WriteLine("En Büyük Sayı"+sayı4);
}

if (sayı5>sayı1 && sayı5>sayı2 && sayı5>sayı3 && sayı5>sayı4)
{
    Console.WriteLine("En Büyük Sayı"+sayı3);
}

if (sayı5<sayı1 && sayı5<sayı2 && sayı5<sayı3 && sayı5<sayı4)
{
    Console.WriteLine("Minimum Sayı"+sayı5);
}
if (sayı4<sayı1 && sayı4<sayı2 && sayı4<sayı3 && sayı4<sayı5)
{
    Console.WriteLine("Minimum Sayı"+sayı4);
}
if (sayı3<sayı1 && sayı3<sayı2 && sayı3<sayı5 && sayı3<sayı4)
{
    Console.WriteLine("Minimum Sayı"+sayı3);
}
if (sayı2<sayı1 && sayı2<sayı5 && sayı2<sayı3 && sayı2<sayı4)
{
    Console.WriteLine("Minimum Sayı"+sayı2);
}
if (sayı1<sayı5 && sayı1<sayı2 && sayı1<sayı3 && sayı1<sayı4)
{
    Console.WriteLine("Minimum Sayı"+sayı1);
}



````

# Proje 9
## C# dlnde br sayı (x) ve br mktar (y) steyen br program yazın. Bu sayıyı mktarın (y) katıkadar göstern 
````c#

        Console.Write("Bir sayı giriniz (x): ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Bir miktar giriniz (y): ");
        int y = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < y; i++)
        {
            Console.WriteLine(x);
        }
  



````
# Proje 10
## 1'den 500'e kadar 3'ün  ve  5'n katları olan sayıları gösteren br C# programı oluşturun. 

````c#
for (int i = 1; i <= 500;
i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i);}}
````

# Proje 11
## C# dlnde kullanıcıdan kullanıcı adı ve şfre steyen br erşm kontrolü yazın. Her ks de tamsayı olmalıdır ve grş 12 ve şfre 1234 olduğunda "grş başarılı yazmalı"  yanlışsa  vetamsayı olmalıdır n fazla 3 deneme yapana kadar tekrarlanmalıdır. 
````c# 
int hak =3;
while (true )
{
    if (hak == 0){
        Console.WriteLine("Hakkınız Bitti :");
        break;
    }
    else 
    {
    Console.WriteLine("Giriş Yapınız : ");
    int giriş = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Şifre Giriniz : ");
    int şifre = Convert.ToInt32(Console.ReadLine());

    if (giriş == 12 && şifre == 1234)
    {
        Console.WriteLine("Giriş Başarılı ");
        break;
    }
    else
    {
        Console.WriteLine("Giriş Başarısız");
        hak--;
    }
    }
}

`````

# Proje 12 
## C# dlnde kullanıcıdan k sayı steyen ve bölme şlem le bölmenn ger kalanını gösteren br program yazın. İknc sayı olarak 0 grlrse kullanıcıya bldrm yapın ve lk ayı olarak 0 grlrse programı sonlandırın.

````c#

        Console.Write("Birinci sayıyı giriniz (Programı sonlandırmak için 0 giriniz): ");
        int sayi1 = Convert.ToInt32(Console.ReadLine());

        if (sayi1 == 0)
        {
            Console.WriteLine("Program sonlandırıldı.");
            return;
        }

        Console.Write("İkinci sayıyı giriniz (Bölme işlemi için 0'dan farklı bir sayı giriniz): ");
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        if (sayi2 == 0)
        {
            Console.WriteLine("Bir sayıyı 0'a bölemezsiniz. Lütfen 0'dan farklı bir sayı giriniz.");
        }
        else
        {
            int kalan = sayi1 % sayi2;
            Console.WriteLine($"Bölme işleminin geri kalanı: {kalan}");
        }
    


````

# Proje 13
## Kullanıcıdan br sayı aralığı (x, y) steyen ve x'ten y'ye kadar çarpım tablosunu görüntüleyen br C# programı oluşturun. 

 ````c#
 Console.WriteLine("Bir Sayı Giriniz");
 int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Bir Y Sayısı Giriniz");
 int y = Convert.ToInt32(Console.ReadLine());
  
for (int i = x; i <= y; i++)
            {
 Console.WriteLine($"Çarpım tablosu {i} için:");
for (int j = 1; j <= 10; j++)
  {
 Console.WriteLine($"{i} * {j} = {i * j}");
}
Console.WriteLine();
    }

    Console.ReadLine(); aralığı (x, y) steyen ve x'ten y'ye kadar çarpım tablosunu görüntüleyen br C# programı oluşturun.

````
# Proje 14
## Br öğrencnn notunu br tamsayıdan hesaplayan br C# programı oluşturun. Kullanıcıdan br sayı (x) steyn ve aşağıdakler yanıtlayın: 

````c#
Console.WriteLine("Bir Sayı Giriniz");
int sayı = Convert.ToInt32(Console.ReadLine());

switch (sayı)
{


    case 10: Console.WriteLine("A+"); break;
    case 9: Console.WriteLine("A") ;break;
    case 8: Console.WriteLine("-B") ;break;
    case 7: Console.WriteLine("C") ;break;
    case 6: Console.WriteLine("E") ;break;
    case 5: Console.WriteLine("F") ;break;
    case 4: Console.WriteLine("G") ;break;
    case 3: Console.WriteLine("H") ;break;
    case 2: Console.WriteLine("Ğ") ;break;
    case 1: Console.WriteLine("I") ;break;
    case 0: Console.WriteLine("İ") ;break;

    default :  Console.WriteLine("Böyle Bir Sayı Yok"); break;

}
````
# Proje 15
## Kullanıcıdan k tamsayı (x, y) steyen ve bu sayıların aralığını (k sayı da dahl olmak üzere) üç farklı yöntemle gösteren br C# programı oluşturun:

````C#
Console.Write("Birinci Sayıyı Giriniz: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci  Sayıyı Giriniz: ");
int y = Convert.ToInt32(Console.ReadLine());

// For döngüsü ile
Console.WriteLine("\n For Döngüsü İle:");
for (int i = x; i <= y; i++)


{
Console.Write(i + " ");
}



        // While döngüsü ile
        Console.WriteLine("\n While Döngüsü İle:");
        int j = x;
        while (j <= y)
        {
            Console.Write(j + " ");
            j++;
        }
````

# PROJE 16
## Poztf br tamsayının kaç basamağı olduğunu hesaplayan programı c# le hazırlayın.  Kullanıcı negatf br tamsayı grdğnde, program uyarı mesajı göstermel ve karşılık gelen poztf sayı le devam etmeldr.

````C#
     Console.Write("Bir Sayı Giriniz ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi < 0)
        {
            Console.WriteLine("Negatif bir sayı girdiniz. Pozitif karşılığı ile devam ediliyor...");
            sayi = Math.Abs(sayi);
        }

        int basamakSayisi = sayi.ToString().Length;


     
        Console.WriteLine("Girilen sayının basamak sayısı: " + basamakSayisi);
````

# Proje 17
## Sadece br for döngüsü ve char değşkenler kullanarak alfabenn büyük harflern gösteren br C# programı yazın. 

```` c# 

        for (char harf = 'A'; harf <= 'Z'; harf++)
        {
            Console.WriteLine(harf);
        }
    


`````

# Proje 18
## C# dlnde, br sayının mutlak değern hesaplayıp gösteren br program yazın. Eğer sayı poztfse, mutlak değer tam olarak sayı x'tr. Eğer sayı negatfse, mutlak değer -x'tr." 


````c#
 Console.Write("Bir Sayı Giriniz ");
    int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi < 0)
        {
            Console.WriteLine("Negatif bir sayı girdiniz. Pozitif karşılığı ile devam ediliyor...");
            sayi = Math.Abs(sayi);
        }

        int basamakSayisi = sayi.ToString().Length;


     
        Console.WriteLine("Girilen sayının basamak sayısı: " + basamakSayisi);

````

# Proje 19
## C# dlnde, kullanıcıdan k tamsayı steyen ve çarpımlarını gösteren, ancak * operatörünü kullanmadan gerçekleştren br program oluşturun. Ardışık toplamları kullanmalısınız. 

````c#

Console.WriteLine("Bir Sayı Giriniz");
    int sayi1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Bir Sayı Giriniz");
    int sayi2 = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < 1; i++)
    {
        Console.WriteLine($"{sayi1} x {sayi2} = {sayi1 * sayi2}");
````

# Proje 20
## C# dlnde kullanıcıdan br tamsayı soran ve bu sayının asal sayı olup olmadığını yanıtlayan br program yazın.

````c#
    Console.Write("Bir Sayı Giriniz ");
    int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi < 0)
        {
            Console.WriteLine("Negatif bir sayı girdiniz. Pozitif karşılığı ile devam ediliyor...");
            sayi = Math.Abs(sayi);
        }

        int basamakSayisi = sayi.ToString().Length;


     
        Console.WriteLine("Girilen sayının basamak sayısı: " + basamakSayisi);
*/
````

# Proje 21
## C# dlnde, x'ten y'ye kadar olan tek sayıları azalan sırada gösteren br program 
oluşturun. 

````c# 
 Console.Write("Lütfen başlangıç değeri (x) giriniz: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Lütfen bitiş değeri (y) giriniz: ");
        int y = Convert.ToInt32(Console.ReadLine());

        for (int i = y; i >= x; i--)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
````
# Proje 22
## Süpermarket kasasını smüle eden ve para üstünü hesaplamak çn br C# programıoluşturun. Ürün fyatı (x) ve verlen para (y) alan ve gerye para üstü veren programı yazın.

 ```` c# 
 Console.WriteLine("Ürün fiyatını girin: ");
        int urunFiyati = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Verilen para miktarını girin: ");
        int verilenPara = Convert.ToInt32(Console.ReadLine());

        int paraUstu = verilenPara - urunFiyati;

        if (paraUstu < 0)
        {
            Console.WriteLine("Yetersiz para ödendi.");
        }
        else if (paraUstu == 0)
        {
            Console.WriteLine("Para üstü yok.");
        }
        else
        {
            Console.WriteLine($"Para üstü: {paraUstu} TL");


            int yuzlukAdet = (int)(paraUstu / 100);
            paraUstu %= 100;
            if (yuzlukAdet > 0)
                Console.WriteLine($"{yuzlukAdet} adet 100 TL");

            int elliAdet = (int)(paraUstu / 50);
            paraUstu %= 50;
            if (elliAdet > 0)
                Console.WriteLine($"{elliAdet} adet 50 TL");

            int yirmiAdet = (int)(paraUstu / 20);
            paraUstu %= 20;
            if (yirmiAdet > 0)
                Console.WriteLine($"{yirmiAdet} adet 20 TL");

            int onlukAdet = (int)(paraUstu / 10);
            paraUstu %= 10;
            if (onlukAdet > 0)
                Console.WriteLine($"{onlukAdet} adet 10 TL");

            int beslikAdet = (int)(paraUstu / 5);
            paraUstu %= 5;
            if (beslikAdet > 0)
                Console.WriteLine($"{beslikAdet} adet 5 TL");

            int ikilikAdet = (int)(paraUstu / 2);
            paraUstu %= 2;
            if (ikilikAdet > 0)
                Console.WriteLine($"{ikilikAdet} adet 2 TL");

            int birlikAdet = (int)paraUstu;
            if (birlikAdet > 0)
                Console.WriteLine($"{birlikAdet} adet 1 TL");

````

# Proje 22
##  KOŞULLU OPERATÖR İÇ İÇE(Zorluk: Orta)Kullanıcıdan k tamsayı (a, b) steyen ve bunlardan kaç tanesnn poztf olduğunu kontrol eden br C# programı oluşturun.

````c#
Console.WriteLine("Bir Tam Sayı Giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bir Tam Sayı Giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());

if (sayi1 < 0 && sayi2 < 0)
{
    Console.WriteLine("Girdiğiniz Tüm Sayılar Negatif");
}

else if (sayi1 == 0)
{
    Console.WriteLine("Girilen Sayı 0");
}

else if (sayi2 == 0)
{
    Console.WriteLine("Girilen Sayı 0");
}

else if (sayi1 > 0 && sayi2 > 0)
{
    Console.WriteLine("Girilen Tüm Sayılar Pozitifdir");
}
else if (sayi1 < 0 || sayi2 < 0)
{
    Console.WriteLine("Girilen 1 Sayı Negatifdir");
}

````
# Proje 23
## Kullanıcıdan k sayı steyen ve koşullu operatör (?) kullanarak aşağıdakler yanıtlayan br C# programı oluşturun: 
````c#
Console.WriteLine("Bir Sayı Giriniz");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bir Sayı Giriniz");
int sayi2 = Convert.ToInt32(Console.ReadLine());

if (sayi1  > 0 )
{
    Console.WriteLine(" Sayı1  Pozitif");
}

if (sayi2  > 0 )
{
    Console.WriteLine(" Sayı2 Pozitif");
}




    else if (sayi1 < 0) 
    {
    Console.WriteLine("Sayı 1 Negatif");
    }

    else if (sayi2 < 0) 
    {
    Console.WriteLine("Sayı 2 Negatif");
    }
    
    
    else if (sayi1 == 0 )
    {
    Console.WriteLine("Sayı1 0 Lütfen Başka Bir Sayı Giriniz");
    }


else if (sayi2 == 0 )
{
    Console.WriteLine("Sayı2 0 Lütfen Başka Bir Sayı Giriniz");
}
````
# Proje 24
## Kullanıcıdan k tamsayı (a, b) steyen ve bunlardan kaç tanesnn poztf olduğunu kontrol eden br C# programı oluşturun

````c#

        Console.WriteLine("Bir Sayı Giriniz (a): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("bİr Sayı Giriniz (b): ");
        int b = Convert.ToInt32(Console.ReadLine());

        int pozitif_sayi = 0;

        if (a > 0) pozitif_sayi++;
        if (b > 0) pozitif_sayi++;

        Console.WriteLine($"Girilen sayılardan{pozitif_sayi}tanesi pozitiftir.");
    
  
