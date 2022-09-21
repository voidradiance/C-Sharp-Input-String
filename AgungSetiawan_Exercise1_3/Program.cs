using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgungSetiawan_Exercise1_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Terdapat sebuah kalimat seperti dibawah ini:\n" +
                "On September 12, 2018, The Reign of chaos has begun in the Kalimdor.\nThe warrior named Thrall rise from the west tribe.\n");

            Console.WriteLine("Masukan nama provinsi ");
            string provinceName = Console.ReadLine();

            Console.WriteLine("Masukan nama seseorang ");
            string personName = Console.ReadLine();

            Console.WriteLine("Masukan tanggal ");
            int tanggal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukan bulan ");
            int bulan = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Masukan tahun ");
            int tahun = Convert.ToInt32(Console.ReadLine());

            DateTime tanggalLahir = new DateTime(tahun, bulan, tanggal);

            Console.WriteLine("On {0}, The Reign of chaos has begun in the {1}.",tanggalLahir.ToString("MMMM dd, yyyy"), provinceName +
                "\nThe warrior named {0} rise from the west tribe.",personName);


        }
    }
}
