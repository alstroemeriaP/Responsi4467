using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4467
{
    class Karyawan
    {
        public Karyawan()
        {
            
        }

        public Karyawan (string Nama, string Nik, int GajiBulanan)
        {
            Nama = Nama;
            Nik = Nik;

            if (GajiBulanan > 0)
            { GajiBulanan = 0; }
            else { GajiBulanan = GajiBulanan; }
        }
        public string Nama { get; set; }
        public string Nik { get; set; }
        public int GajiBulanan { get; set; }
    }
}
