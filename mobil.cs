using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace mingguke3 // 22.11.4868
{
    internal class mobil
    {
       public string merek { get; set; }
        public float jumlahpintu { get; set; }
        public string warna { get; set; }
        public string model { get; set; }

        public float tahunkeluaran { get; set; }
        public float kecepatan { get; set; }
        public string suaraklakson { get; set; }

        public void kualitas()
        {
            Console.WriteLine("merek: {0}", merek);
            Console.WriteLine("jumlah pintu: {0}", jumlahpintu);
            Console.WriteLine("warna: {0}", warna);
            Console.WriteLine("model: {0}", model);
            Console.WriteLine("tahun keluaran: {0}", tahunkeluaran);
            Console.WriteLine("kecepatan: {0}", kecepatan);
            Console.WriteLine("suara klakson: {0}", suaraklakson);
        }

        public void hasil()
        {
            Console.WriteLine("\nMobil " + merek + " berjalan dengan kecepatan " + kecepatan + "\n");
        }
        public void klakson(string suara)
        {
            Console.WriteLine("{0}\n", suara);
        }

        public void tampilaninfo()
        {
            Console.WriteLine("Mobil saya berwarna " + warna + ", merek " + merek + ", model " + model + " keluaran tahun " + tahunkeluaran + " dengan jumlah pintu sebanyak " + jumlahpintu + " dengan kecepatan " + kecepatan);
        }

      
    }
}
