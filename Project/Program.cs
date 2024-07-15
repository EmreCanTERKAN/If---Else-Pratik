using System;


Console.WriteLine("Bir Sayı Giriniz:");
int sayi = int.Parse(Console.ReadLine());

if (sayi > 10 ){
    Console.WriteLine("Sayı 10dan Büyüktür.");
    if (sayi % 2 == 0 ){
        Console.WriteLine("Sayı Çifttir");
    }
    else Console.WriteLine("Sayı Tektir.");
}

else if (sayi == 10) {
    Console.WriteLine("Sayı 10'a Eşittir");
    if (sayi % 2 == 0)
    {
        Console.WriteLine("Sayı Çifttir");
    }
    else Console.WriteLine("Sayı Tektir.");
}

else {
    Console.WriteLine("Sayı 10dan Küçüktür.");
    if (sayi % 2 == 0)
    {
        Console.WriteLine("Sayı Çifttir");
    }
    else Console.WriteLine("Sayı Tektir.");
}