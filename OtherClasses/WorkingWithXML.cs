using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TaxiService;

namespace TaxiServiceWPF
{
    public static class WorkingWithXML
    {
        public static void DeserializeEconomCar(ref Car car,string nickname)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(EconomCar));
            using (Stream stream = File.OpenRead($@"..\..\XML\TaxistsWithCars\{nickname}.xml"))
            {
                car = (EconomCar)xmlSerializer.Deserialize(stream);
            }
        }

        public static void DeserializeLuxuryCar(ref Car car, string nickname)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(LuxuryCar));
            using (Stream stream = File.OpenRead($@"..\..\XML\TaxistsWithCars\{nickname}.xml"))
            {
                car = (LuxuryCar)xmlSerializer.Deserialize(stream);
            }
        }

        public static void DeserializeTruck(ref Car car, string nickname)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Truck));
            using (Stream stream = File.OpenRead($@"..\..\XML\TaxistsWithCars\{nickname}.xml"))
            {
                car = (Truck)xmlSerializer.Deserialize(stream);
            }
        }

        public static void SerializeEconomCar(ref Car car,string nickname)
        {
            XmlSerializer xmlSerializerCar = new XmlSerializer(typeof(EconomCar));
            using (Stream stream = File.Create($@"..\..\XML\TaxistsWithCars\{nickname}.xml"))
            {
                xmlSerializerCar.Serialize(stream, ((EconomCar)car));
            }
        }

        public static void SerializeLuxuryCar(ref Car car, string nickname)
        {
            XmlSerializer xmlSerializerCar = new XmlSerializer(typeof(LuxuryCar));
            using (Stream stream = File.Create($@"..\..\XML\TaxistsWithCars\{nickname}.xml"))
            {
                xmlSerializerCar.Serialize(stream, ((LuxuryCar)car));
            }
        }

        public static void SerializeTruck(ref Car car, string nickname)
        {
            XmlSerializer xmlSerializerCar = new XmlSerializer(typeof(Truck));
            using (Stream stream = File.Create($@"..\..\XML\TaxistsWithCars\{nickname}.xml"))
            {
                xmlSerializerCar.Serialize(stream, ((Truck)car));
            }
        }

        public static void DeserializeEconomBase(ref List<EconomCar> usersEconomBase,string path = @"..\..\XML\UserBase\UsersEconomCars.xml")
        {
            XmlSerializer xmlSerializerEconom = new XmlSerializer(typeof(List<EconomCar>));
            using (Stream stream = File.OpenRead(path))
            {
                usersEconomBase = (List<EconomCar>)xmlSerializerEconom.Deserialize(stream);
            }
        }

        public static void DeserializeLuxuryBase(ref List<LuxuryCar> usersLuxuryBase,string path= @"..\..\XML\UserBase\UsersLuxuryCars.xml")
        {
            XmlSerializer xmlSerializerLuxury = new XmlSerializer(typeof(List<LuxuryCar>));
            using (Stream stream = File.OpenRead(path))
            {
                usersLuxuryBase = (List<LuxuryCar>)xmlSerializerLuxury.Deserialize(stream);
            }
        }

        public static void DeserializeTruckBase(ref List<Truck> usersTruckBase, string path = @"..\..\XML\UserBase\UsersTrucks.xml")
        {
            XmlSerializer xmlSerializerTruck = new XmlSerializer(typeof(List<Truck>));
            using (Stream stream = File.OpenRead(path))
            {
                usersTruckBase = (List<Truck>)xmlSerializerTruck.Deserialize(stream);
            }
        }
    }
}
