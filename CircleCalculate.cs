using System;

namespace AreaCalculate
{
    public class CircleCalculate
    {
        public CircleCalculate()
        {
            Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz..:");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Alan Hesaplamak İçin =>    (1)");
            Console.WriteLine("Çevre Hesaplamak İçin =>    (2)");
            Console.WriteLine("Hacim Hesaplamak İçin =>    (3)");
            int choise = Convert.ToInt32(Console.ReadLine());
            int radius;

            switch (choise)
            {
                case 1:
                    Console.WriteLine("Yarıçap Giriniz : ");
                    radius = int.Parse(Console.ReadLine());
                    Alan(radius);
                    break;
                case 2:
                    Console.WriteLine("Yarıçap Giriniz : ");
                    radius = int.Parse(Console.ReadLine());
                    Cevre(radius);
                    break;
                case 3:
                    Console.WriteLine("Yarıçap Giriniz : ");
                    radius = int.Parse(Console.ReadLine());
                    Hacim(radius);
                    break;
                default:
                    Console.WriteLine("Hatalı Seçim");
                    break;
            }
        }
        public void Alan(int radius)
        {
            int result = Convert.ToInt32(Math.Floor(radius * radius * Math.PI));
            Console.WriteLine("Dairenin Alanı : {0}", result);
        }

        public void Cevre(int radius)
        {
            int result = Convert.ToInt32(Math.Floor(2 * radius * Math.PI));
            Console.WriteLine("Dairenin Çevresi : {0}", result);
        }

        public void Hacim(int radius)
        {
            int result = Convert.ToInt32(Math.Floor((radius * radius * radius * Math.PI) * 4 / 3 ) );
            Console.WriteLine("Dairenin Alanı : {0}", result);
        }
    }
}