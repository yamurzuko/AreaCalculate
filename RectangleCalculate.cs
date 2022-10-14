using System;

namespace AreaCalculate
{
    public class RentangleCalculate
    {
        public RentangleCalculate()
        {
            Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz..:");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Alan     Hesaplamak İçin =>    (1)");
            Console.WriteLine("Çevre    Hesaplamak İçin =>    (2)");
            Console.WriteLine("Hacim    Hesaplamak İçin =>    (3)");
            int choise = Convert.ToInt32(Console.ReadLine());
            int shortSide;
            int longSide;;

            switch (choise)
            {
                case 1:
                    Console.WriteLine("Kısa Kenar Uzunluğu Giriniz : ");
                    shortSide = int.Parse(Console.ReadLine());
                    Console.WriteLine("Uzun Kenar Uzunluğu Giriniz : ");
                    longSide = int.Parse(Console.ReadLine());
                    Alan(shortSide, longSide);
                    break;
                case 2:
                    Console.WriteLine("Kısa Kenar Uzunluğu Giriniz : ");
                    shortSide = int.Parse(Console.ReadLine());
                    Console.WriteLine("Uzun Kenar Uzunluğu Giriniz : ");
                    longSide = int.Parse(Console.ReadLine());
                    Cevre(shortSide, longSide);
                    break;
                case 3:
                    Console.WriteLine("Kısa Kenar Uzunluğu Giriniz : ");
                    shortSide = int.Parse(Console.ReadLine());
                    Console.WriteLine("Uzun Kenar Uzunluğu Giriniz : ");
                    longSide = int.Parse(Console.ReadLine());
                    Hacim(shortSide, longSide);
                    break;
                default:
                    Console.WriteLine("Hatalı Seçim");
                    break;
            }
        }
        public void Alan(int value, int value1)
        {
            int result = value * value1;
            Console.WriteLine("Dİkdörtgenin Alanı : {0}",result);
        }
        public void Cevre(int value, int value1)
        {
            int result = (value + value1) * 2;
            Console.WriteLine("Dİkdörtgenin Çevresi : {0}",result);
        }
        public void Hacim(int value, int value1)
        {
            int result = value * value1;
            Console.WriteLine("Dİkdörtgenin Alanı : {0}",result);
        }
    }
}