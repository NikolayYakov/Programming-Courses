using System; 

namespace ClassBoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            try
            { 
                

                Box box = new Box(length, width, height);
                Console.WriteLine("Surface Area - {0:F2}", box.SurfaceArea());
                Console.WriteLine("Lateral Surface Area - {0:F2}", box.LateralSurfaceArea());
                Console.WriteLine("Volume - {0:F2}", box.Volume());
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
