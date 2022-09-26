using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1214074
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int angkaPertama = int.Parse(Console.ReadLine()); ;
            int angkaKedua = int.Parse(Console.ReadLine());

            int tambah = angkaPertama + angkaKedua;
            int kurang = angkaPertama - angkaKedua;
            int kali = angkaPertama * angkaKedua;
            int bagi = angkaPertama / angkaKedua;

            Console.WriteLine("Angka Pertama : " + angkaPertama);
            Console.WriteLine("Angka Kedua : " + angkaKedua);

            Console.WriteLine("20 + 5 = " + tambah); // Tambah
            Console.WriteLine("20 - 5 = " + kurang); // Kurang
            Console.WriteLine("20 * 5 = " + kali); // Kali
            Console.WriteLine("20 / 5 = " + bagi); // Bagi



 
        }
    }
}
