using System.Xml.Schema;

namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- Testing: --------");
            Car mini = new Car("BM", "Mini Cooper");
            Motorcycle ducati = new Motorcycle("Ducati", "Ducati monster", false);

            mini.StartEngine();
            mini.Drive();

            ducati.StartEngine();
            ducati.Drive();
        }
    }
}
