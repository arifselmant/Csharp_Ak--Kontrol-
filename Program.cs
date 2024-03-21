namespace oo2;

class Program
{
    static void Main(string[] args)
    {
        /*1  Console.WriteLine("Bir Sayı Giriniz");
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
*/


/*2
  
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
{
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
}

*/

/*3Console.WriteLine("Bir Sayı Giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());

if (sayi >= 0)
{
    Console.WriteLine("Sayınız Pozitif");
}

if (sayi < 0)
{
    Console.WriteLine("Sayınız Negatif");
}*/


/* 4int sayi1, sayi2;


    Console.WriteLine("Birinci sayıyı girin."); 
     sayi1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("İkinci sayıyı girin.");
     sayi2 = Convert.ToInt32(Console.ReadLine());

    if(sayi1 > sayi2)
    Console.WriteLine("1. sayı olan {0} daha büyük.",sayi1);
    else
    Console.WriteLine("2. sayı olan {0} daha büyük.", sayi2);*/



/*Console.WriteLine("Bir Sayı Giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{sayi * 10} .");*/




/*5 Console.WriteLine("Birinci Sayıyı Giriniz:"); 
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("İkinci Sayıyı Giriniz:");
int y = Convert.ToInt32(Console.ReadLine());
while (x <= y) 
{ Console.WriteLine(x++); }
*/


/*6 
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
*/


 /* 7 Console.WriteLine("Bir Sayı Giriniz");
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

 */

/* 8 Console.WriteLine("Bir X Sayısı Giriniz");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bir Y Sayısı Giriniz");
int y = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <y; i++)
{
    Console.Write(x);
}*/
 /* 9 for (int i = 1; i <= 500;
i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine(i); */
    



   /* 10 int hak =3;
while (true )
{
    if (hak == 0){
        System.Console.WriteLine("Hakkınız Bitti :");
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
        System.Console.WriteLine("Giriş Başarılı ");
        break;
    }
    else
    {
        System.Console.WriteLine("Giriş Başarısız");
        hak--;
    }
    }
}*/
    


/* 11 Console.Write("Birinci sayıyı giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı giriniz: ");
int sayi2 = Convert.ToInt32(Console.ReadLine());

    if (sayi2 == 0)
        {
            Console.WriteLine("İkinci sayı sıfır olamaz. Lütfen farklı bir sayı girin.");
            }
        else if (sayi1 == 0)
        {
        Console.WriteLine("İlk sayı sıfır olduğu için program sonlandırıldı.");
        }
    else
    {
        int bolum = sayi1 / sayi2;
        int kalan = sayi1 % sayi2;
 
            Console.WriteLine($"Bölüm: {bolum}");
                Console.WriteLine($"Kalan: {kalan}");
            }

            Console.ReadLine();*/
      



 /*12 Console.WriteLine("Bir X Sayısı Giriniz");
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

    Console.ReadLine();*/




/*13 Console.WriteLine("Bir Sayı Giriniz");
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
*/

/*14
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
        }*/
  



   /* 16     Console.Write("Bir Sayı Giriniz ");
        int sayi = Convert.ToInt32(Console.ReadLine());

        // Negatif sayı kontrolü
        if (sayi < 0)
        {
            Console.WriteLine("Negatif bir sayı girdiniz. Pozitif karşılığı ile devam ediliyor...");
            sayi = Math.Abs(sayi);
        }

        // Basamak sayısını hesaplama
        int basamakSayisi = sayi.ToString().Length;


     
        Console.WriteLine("Girilen sayının basamak sayısı: " + basamakSayisi); */
   
    /*17for (char letter = 'A'; letter <= 'Z'; letter++)  
        {
            Console.Write(letter + "\n"); 
        }

        Console.WriteLine();
   */



   /*18 Console.WriteLine("Bir Sayı Giriniz");
   int sayi = Convert.ToInt32(Console.ReadLine());

   if (sayi == 0)
{
    Console.WriteLine("Girilen Sayı 0 Lütfen Başka Bir Sayı Giriniz");
}

    else if ( sayi > 0)
    {
        Console.WriteLine($"Mutlak Değer = {sayi}");
    }
   
   if (sayi < 0)
        {
            Console.WriteLine("Negatif Bir Sayı Girdiniz Sayınız Pozitife Çeviriliyor");
            sayi *= -1;
        }

        Console.WriteLine("Sayının Pozitif Hali: " + sayi); */
    





    /*19 Console.WriteLine("Bir Sayı Giriniz");
    int sayi1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Bir Sayı Giriniz");
    int sayi2 = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < 1; i++)
    {
        Console.WriteLine($"{sayi1} x {sayi2} = {sayi1 * sayi2}");
    }*/
    
      


    
       /*20  Console.Write("Bir tamsayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        bool asalMi = true;

        if (sayi < 2)
        {
            asalMi = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                {
                    asalMi = false;
                    break;
                }
            }
        }

        Console.WriteLine(asalMi ? $"{sayi} asal bir sayıdır." : $"{sayi} asal bir sayı değildir.");
    
    */


      /*21  Console.WriteLine("Başlangıç Sayısını Giriniz:");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Bitiş Sayısını Giriniz:");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Tek Sayılar:");
        for (int i = y; i >= x; i--)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }*/

       /*21 Console.WriteLine("Ürün fiyatını girin: ");
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
        }
*/

/*22 Console.WriteLine("Bir Sayı Giriniz");
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
*/


   /*23 Console.WriteLine("Bir Tam Sayı Giriniz");
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
}*/


    }}

     

         
  
  
  
  
  
    




        








    


