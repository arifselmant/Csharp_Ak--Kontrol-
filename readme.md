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
##Kullanıcıdan iki sayı ve bir şlem (+, -, x, /) sembolü isteyen ve 
ardından işlem hesaplayıp sonucu ekrana yazan br C# programı yazınız.Eğer işlem sembolü öncek sembollerden farklıysa, "Tanınmayan karakter" metnn gösternz.

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
##C# dilinde üç sayıyı (x, y, z) isteyen ve en büyüğünü görüntüleyen bir program yazın. 

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
##C#'ta br sayı (x) isteyen ve 10 * x' görüntüleyen bir program oluşturun. Kullanıcı 0 girene kadar tekrarlanmalıdır. 
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

int toplam = 0;

while(true)
{
Console.WriteLine("  Sayı Giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());

toplam += sayi;


if (sayi == 0)
{
    break;
}

else 
{
    Console.WriteLine(toplam);

}

}

    Console.WriteLine(toplam);
    Console.WriteLine(" Programdan Çıkış Yapıldı ...");

````
# Proje7

## C# dilinde sayı isteyen ve toplamlarını gösteren bir program yazın. Kullanıcı 0 girene kadar numara isteyn ve program bittğinde Bitti gösterlr.

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

    Console.WriteLine("Minimum Sayı"+sayı1);

````
## Proje 8
## Kullanıcıdan 5 tam sayı steyen ve aşağıdak matematksel statstkler ekranda görüntüleyen br C# programı oluşturun 

````c#
Console.WriteLine("Bir X Sayısı Giriniz");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bir Y Sayısı Giriniz");
int y = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <y; i++)
{
    Console.Write(x);
}````


## Proje 9
## C# dilinde bir sayı (x) ve bir miktar (y) isteyen br program yazın. Bu sayıyı mktarın (y) katı kadar göster
