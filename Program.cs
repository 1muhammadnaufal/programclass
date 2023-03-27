using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mingguke3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mobil mobil1 = new mobil();
            mobil mobil2 = new mobil();
            {
                mobil1.merek = "lambo";
                mobil1.jumlahpintu = 4;
                mobil1.warna = "merah";
                mobil1.model = "terbaru";
                mobil1.tahunkeluaran = 2006;
                mobil1.suaraklakson = "tiiddd";
                mobil1.kecepatan = 800;

                mobil1.kualitas();
                mobil1.tampilaninfo();
                Console.ReadKey();
            }
        }
    }
}
