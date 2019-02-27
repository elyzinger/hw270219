using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car a1 = new Car("yaris", "toyota", 2018, "red", 3232, 4);
            Car[] cararray = new Car[]
            {
                new Car("yaris", "toyota", 2018, "red", 3232, 4),
                new Car("yaris", "toyota", 2018, "red", 3232, 4),
                new Car("yaris", "toyota", 2018, "red", 3232, 4),
                new Car("yaris", "toyota", 2018, "red", 3232, 4),
            };

            XmlSerializer xmlcar = new XmlSerializer(typeof(Car[]));
            // xml יצירה של אובייקט אחד 
            /*using (Stream file = new FileStream(@"C:\Users\USER\source\repos\Car\Car\xmlcar.xml", FileMode.Create))
            {
                xmlcar.Serialize(file, a1);
            }
            // הורדה של xml 
            Car adeserialzer;
            using (Stream file = new FileStream(@"C:\Users\USER\source\repos\Car\Car\xmlcar.xml", FileMode.Open))
            {
               adeserialzer =  xmlcar.Deserialize(file) as Car;
            }
            Console.WriteLine(adeserialzer);
            
            // xml של מערך
            using (Stream file = new FileStream(@"C:\Users\USER\source\repos\Car\Car\xmlcar.xml", FileMode.Create))
            {
                xmlcar.Serialize(file, cararray);
            }
            Car[] arrayout;
            using (Stream file = new FileStream(@"C:\Users\USER\source\repos\Car\Car\xmlcar.xml", FileMode.Open))
            {
                arrayout = xmlcar.Deserialize(file) as Car[];
            }
            Console.WriteLine(arrayout[1]);*/
            Console.WriteLine();
        }
    }

}
