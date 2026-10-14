using System;

class Program
{
    static void Main()
    {
        Uygulama uygulama = new Uygulama();
        uygulama.Baslat();
    }
}

class Uygulama
{
    public void Baslat()
    {
        SayiKontrolcusu kontrolcu = new SayiKontrolcusu();
        string giris = "";

        while (giris != "N" && giris != "n")
        {
            Console.Write("Bir sayı giriniz (Çıkış: N): ");
            giris = Console.ReadLine();

            if (giris == "N" || giris == "n")
            {
                Console.WriteLine("Program kapatılıyor...");
            }
            else
            {
                int sayi = int.Parse(giris);
                Console.WriteLine(kontrolcu.TekMiCiftMi(sayi));
            }
        }
    }
}

class SayiKontrolcusu
{
    public string TekMiCiftMi(int sayi)
    {
        if (sayi % 2 == 0)
        {
            return sayi + " çift sayıdır.";
        }

        return sayi + " tek sayıdır.";
    }
}