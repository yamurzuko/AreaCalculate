using System;

namespace AreaCalculate
{
    public class TriangleCalculate
    {
        public TriangleCalculate()
        {
            Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz..:");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Alan     Hesaplamak İçin =>    (1)");
            Console.WriteLine("Çevre    Hesaplamak İçin =>    (2)");
            Console.WriteLine("Hacim    Hesaplamak İçin =>    (3)");
            int choise = Convert.ToInt32(Console.ReadLine());
            int side;
            int height;

            switch (choise)
            {
                case 1:
                    Console.WriteLine("Kenar Uzunluğu Giriniz : ");
                    side = int.Parse(Console.ReadLine());
                    Console.WriteLine("Yüksekliği Giriniz : ");
                    height = int.Parse(Console.ReadLine());
                    Alan(side, height);
                    break;
                case 2:
                    Console.WriteLine("Kenar Uzunluğu Giriniz : ");
                    side = int.Parse(Console.ReadLine());
                    Console.WriteLine("Yüksekliği Giriniz : ");
                    height = int.Parse(Console.ReadLine());
                    Cevre(side);
                    break;
                case 3:
                    Console.WriteLine("Kenar Uzunluğu Giriniz : ");
                    side = int.Parse(Console.ReadLine());
                    Console.WriteLine("Yüksekliği Giriniz : ");
                    height = int.Parse(Console.ReadLine());
                    Hacim(side, height);
                    break;
                default:
                    Console.WriteLine("Hatalı Seçim");
                    break;
            }
        }
        public void Alan(int value, int value1)
        {
            int result = (value * value1) / 2;
            Console.WriteLine("Üçgenin Alanı : {0}", result);
        }

        public void Cevre(int value)
        {
            int result = value * 3;
            Console.WriteLine("Üçgenin Çevresi : {0}", result);
        }

        public void Hacim(int value, int value1)
        {
            int result = (value * value1) / 2;
            Console.WriteLine("Üçgenin Alanı : {0}", result);
        }
    }
}