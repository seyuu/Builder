using System;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Builder nesnesi oluşturuluyor
            IBuilder builder = new ComputerBuilder();

            // Yönetici nesnesi oluşturuluyor ve builder nesnesi ile ilişkilendiriliyor
            ComputerDirector director = new ComputerDirector(builder);

            // Yüksek performanslı bir bilgisayarın oluşturulması için yöneticiye construct işlemi veriliyor
            director.ConstructHighEndComputer();

            // Oluşturulan bilgisayar alınıyor
            Computer highEndComputer = builder.GetComputer();

            Console.WriteLine("Yüksek Performanslı Bilgisayar:");
            highEndComputer.DisplayInfo();

            Console.WriteLine();

            // Düşük performanslı bir bilgisayarın oluşturulması için yöneticiye construct işlemi veriliyor
            director.ConstructLowEndComputer();

            // Oluşturulan bilgisayar alınıyor
            Computer lowEndComputer = builder.GetComputer();

            Console.WriteLine("Düşük Performanslı Bilgisayar:");
            lowEndComputer.DisplayInfo();
        }
    }
}
