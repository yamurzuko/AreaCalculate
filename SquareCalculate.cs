using System;

namespace AreaCalculate
{
    public class SquareCalculate
    {
        public SquareCalculate()
        {
            Console.WriteLine("Lütfen Yapmak istediğiniz işlemi seçiniz..:");
            Console.WriteLine("***********************************************");
            Console.WriteLine("Alan     Hesaplamak İçin =>    (1)");
            Console.WriteLine("Çevre    Hesaplamak İçin =>    (2)");
            Console.WriteLine("Hacim    Hesaplamak İçin =>    (3)");
            int choise = Convert.ToInt32(Console.ReadLine());
            int side;

            switch (choise)
            {
                case 1:
                    Console.WriteLine("Kenar Uzunluğu Giriniz : ");
                    side = int.Parse(Console.ReadLine());
                    Alan(side);
                    break;
                case 2:
                    Console.WriteLine("Kenar Uzunluğu Giriniz : ");
                    side = int.Parse(Console.ReadLine());
                    Cevre(side);
                    break;
                case 3:
                    Console.WriteLine("Kenar Uzunluğu Giriniz : ");
                    side = int.Parse(Console.ReadLine());
                    Hacim(side);
                    break;
                default:
                    Console.WriteLine("Hatalı Seçim");
                    break;
            }
        }
        public void Alan(int side)
        {
            int result = side * side;
            Console.WriteLine("Karenin Alanı : {0}", result);
        }
        public void Cevre(int side)
        {
            int result = side * 4;
            Console.WriteLine("Karenin Çevresi : {0}", result);
        }
        public void Hacim(int side)
        {
            int result = side * side;
            Console.WriteLine("Karenin Çevresi : {0}", result);
        }
    }
}