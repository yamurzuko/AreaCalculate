using System;

namespace AreaCalculate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("İşlem Yapmak İstediğiniz Geometrik Şekil ? ");
                Console.WriteLine("************************************************");
                Console.WriteLine("1 : Kare Hesaplama");
                Console.WriteLine("2 : Dikdörtgen Hesaplama");
                Console.WriteLine("3 : Daire Hesaplama");
                Console.WriteLine("4 : Üçgen Hesaplama");
                
                int choise = Convert.ToInt32(Console.ReadLine());

                switch (choise)
                {
                    case 1:
                        SquareCalculate square = new SquareCalculate();
                        break;
                    case 2:
                        RentangleCalculate rectangle = new RentangleCalculate();
                        break;
                    case 3:
                        CircleCalculate circle = new CircleCalculate();
                        break;
                    case 4:
                        TriangleCalculate triangle = new TriangleCalculate();
                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim");
                        break;
                }
            }
        }
    }
}