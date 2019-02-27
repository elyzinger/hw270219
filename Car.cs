using System.IO;
using System.Xml.Serialization;

namespace Car
{
    public class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        private int Codan { get; set; }
        internal int NumberOfSeats { get; set; }
        public Car(string model, string brand, int year, string color)
        {
            XmlSerializer filename = new XmlSerializer(typeof(Car));
            Car desrializer;
            using (Stream file = new FileStream(@"C:\Users\USER\source\repos\Car\Car\xmlcar.xml", FileMode.Open))
            {
                desrializer = filename.Deserialize(file) as Car;
                
            }
            
        }
        public Car(string model, string brand, int year, string color, int codan, int numberofseats)
        {
            Model = model;
            Brand = brand;
            Year = year;
            Color = color;
            Codan = codan;
            NumberOfSeats = numberofseats;
        }
          public int GetCodan()
          {
              return Codan;
          }
          public int GetNumberOfSeats()
          {
              return NumberOfSeats;
          }
        /*internal void ChangeNumberOfSeats()
        {

        }
        public static void SerializeACar(filename, Car a)
        {

        }
        public static SerialzerCarArray(filename, Car[] arraya)
        {

        }
        public static DeserialzeACar(XmlSerializer filename)
        {
        
             
        }
        public static DeserialzeCarArray(filename)
        {
            Car[];
        }
        public bool CarCompare(filename)
        {
            bool result;
            result = false;
            return result;           
        }*/

        public override string ToString()
        {
            return $"model: {Model} brand: {Brand} year: {Year} coler: {Color} ";
        }
    }
}
