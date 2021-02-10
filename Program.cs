using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ODAraba
{
   class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {  
               Id = 1,
               Marka = "BMW",
               Model = "M4",
               Yıl = "2018",
               renk = "Kırmızı",
               Kasatipi = "Coupe",
               Turu = "Otomobil",
               MotorGucu = "431 hp",
               MotorHacmi = " 2979 cc",
               MaksimumHiz = "430 km/h",
               SifirYuze = "4.1 sn",
               Cekis = "Arkadan Çekiş",
               Agirlik = "1537 kg",
               Fiyat = "1.500.000 TL"


            };
            Car car2 = new Car()
            {
                Id = 2,
                Marka = "Mercedes-Benz",
                Model = " C 63 AMG",
                Yıl = "2015",
                renk = "Mavi",
                Kasatipi = "Sedan",
                Turu = "Otomobil",
                MotorGucu = "431 hp",
                MotorHacmi = " 2979 cc",
                MaksimumHiz = "430 km/h",
                SifirYuze = "4.1 sn",
                Cekis = "Arkadan Çekiş",
                Agirlik = "1537 kg",
                Fiyat = "1.500.000 TL"


            };


            Console.WriteLine(car.Id);
            Console.WriteLine("Marka: " + car.Marka);
            Console.WriteLine("Model: " + car.Model);
            Console.WriteLine("Yıl: "+car.Yıl);
            Console.WriteLine("renk: " + car.renk);
            Console.WriteLine("Kasatipi: " + car.Kasatipi);
            Console.WriteLine("Turu: " + car.Turu);
            Console.WriteLine("MotorGucu: " + car.MotorGucu);
            Console.WriteLine("MotorHacmi: " + car.MotorHacmi);
            Console.WriteLine("MaksimumHiz: " + car.MaksimumHiz);
            Console.WriteLine("SifirYuze: " + car.SifirYuze);
            Console.WriteLine("Cekis: " + car.Cekis);
            Console.WriteLine("Agirlik: " + car.Agirlik);
            Console.WriteLine("Fiyat: " + car.Fiyat);

            Console.WriteLine(car2.Id);
            Console.WriteLine("Marka: " + car2.Marka);
            Console.WriteLine("Model: " + car2.Model);
            Console.WriteLine("Yıl: " + car2.Yıl);
            Console.WriteLine("renk: " + car2.renk);
            Console.WriteLine("Kasatipi: " + car2.Kasatipi);
            Console.WriteLine("Turu: " + car2.Turu);
            Console.WriteLine("MotorGucu: " + car2.MotorGucu);
            Console.WriteLine("MotorHacmi: " + car2.MotorHacmi);
            Console.WriteLine("MaksimumHiz: " + car2.MaksimumHiz);
            Console.WriteLine("SifirYuze: " + car2.SifirYuze);
            Console.WriteLine("Cekis: " + car2.Cekis);
            Console.WriteLine("Agirlik: " + car2.Agirlik);
            Console.WriteLine("Fiyat: " + car2.Fiyat);

            Console.ReadLine();
        }
    }
}
