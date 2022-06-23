using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi: " + musteri.Adi);
        }

        public void Remove(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi!" + musteri.Soyadi);
        }
    }
}
