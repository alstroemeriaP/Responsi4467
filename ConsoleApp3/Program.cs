using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4467
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan
            {
                Nik = "190302123",
                Nama = "Paijo",
                GajiBulanan =  3000000
            };



            Karyawan karyawan2 = new Karyawan
            {
                Nik = "190302124",
                Nama = "Jono",
                GajiBulanan =  2000000
            };


            //sebelum naik gaji
            Console.WriteLine("No. Nik/Nama          Gaji Bulanan");
            
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. {0} {1}  {2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine("2. {0} {1}  {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Asyiiiiik kenaikan gaji 10%!! ");
            Console.WriteLine();

            //setelah naik gaji 10%
            Console.WriteLine("No. Nik/Nama          Gaji Bulanan");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1. {0} {1}  {2}", karyawan1.Nik, karyawan1.Nama, karyawan1.GajiBulanan + (karyawan2.GajiBulanan * 0.10));
            Console.WriteLine("2. {0} {1}  {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan + (karyawan2.GajiBulanan * 0.10));
            Console.ReadKey();



        }
    }
}