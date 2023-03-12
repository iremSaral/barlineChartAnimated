using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atama ve İşlemli Atama
           /*
            int d=8;
            d=d*4;
            Console.WriteLine(d);
            d+=2;
            Console.WriteLine(d);
            d/=2;
            Console.WriteLine(d);
        */
        //Mantıksal Operatorler //,&&,!
      /*  bool isSuccess=true;
        bool isCompleted=false;
        if(isSuccess && isCompleted){
            Console.WriteLine("And");
        }
        if(isSuccess ||isCompleted){
            Console.WriteLine("OR");
        }
        if(!isCompleted)
        {
              Console.WriteLine("Not")  ;
        }*/
        /*//İlişkisel Operatorler
        int a=3;
        int b=4;
        bool sonuc= a<b;
        Console.WriteLine(sonuc);
       sonuc= a>=b;
       Console.WriteLine(sonuc);
       sonuc= a==b;
       Console.WriteLine(sonuc);
       sonuc= a!=b ;
       Console.WriteLine(sonuc);
        */
        //Aritmetik Operatorler
         int sayi1=10;
         int sayi2=5;
         int sonuc1=sayi1/sayi2;
         Console.WriteLine(sonuc1);
         sonuc1=sayi1*sayi2;
         Console.WriteLine(sonuc1);
         sonuc1=sayi2++;
         Console.WriteLine(sonuc1);

         // % mod alma
        Console.WriteLine(20%3);
        }
    }
}