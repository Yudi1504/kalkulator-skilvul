using System;

namespace SkilvulLearning
{
    class Latihan
    {
        static void Main(string[] args)
        {
            double angkaPertama = 0;
            double angkaKedua = 0;

            double hasil = 0;
            Console.WriteLine("Program Kalkulator Sederhana");
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Masukkan Angka Pertama : ");
            angkaPertama = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Angka Kedua : ");
            angkaKedua = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Tekan 1 untuk Pertambahan(+)");
            Console.WriteLine("Tekan 2 untuk Pengurangan(-)");
            Console.WriteLine("Tekan 3 untuk Perkalian(x)");
            Console.WriteLine("Tekan 4 untuk Pembagian(:)");
            Console.WriteLine();

            switch (Console.ReadLine()){
                case "1":
                    hasil = angkaPertama + angkaKedua;
                    Console.WriteLine($"Hasil pertambahannya adalah: {angkaPertama} + {angkaKedua} = " + hasil);
                    break;
                case "2":
                    hasil = angkaPertama - angkaKedua;
                    Console.WriteLine($"Hasil pengurangannya adalah: {angkaPertama} - {angkaKedua} = " + hasil);
                    break;
                case "3":
                    hasil = angkaPertama * angkaKedua;
                    Console.WriteLine($"Hasil perkaliannya adalah: {angkaPertama} x {angkaKedua} = " + hasil);
                    break;
                case "4":
                    hasil = angkaPertama / angkaKedua;
                    Console.WriteLine($"Hasil pembagiannya adalah: {angkaPertama} : {angkaKedua} = " + hasil);
                    break;
            }

            Console.ReadLine();
        }
    }
}
