using System.Drawing;

namespace BTLap6._3Cshap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> c = new List<Car>
            { 
            new Car { Name = "toyota", Color = "red" },
            new Car { Name = "g63", Color = "blue" },
            new Car { Name = "mcd", Color = "green" },
            new Car { Name = "md", Color = "orảnge" },
            new Car { Name = "i10", Color = "yellow" },
            new Car { Name = "huyndai", Color = "white" },
            new Car { Name = "honda", Color = "pink" },
            new Car { Name = "haha", Color = "black" },
            new Car { Name = "hihi", Color = "grey" },
            new Car { Name = "hoho", Color = "purper" },
            
            };

            Console.WriteLine("danh sach cac xe oto ban dau");
            PrintCarList(c);
            // xoá các xe có màu red
            c.RemoveAll(Car => Car.Color.ToLower() == "red");
            Console.WriteLine("danh sach cac oto sau khi xoa");
            PrintCarList(c);
            static void PrintCarList(List<Car> c)
            {
                foreach (Car car in c)
                {
                    Console.WriteLine($"name{car.Name}, color{car.Color}");
                }
            }
        }
    }
}