using AssignmentOOP01.Interfaces;
using AssignmentOOP01.Struct;
using AssignmentOOP01.Struct.Encapsulation;
using System.Net;

namespace AssignmentOOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1

            #region Part1

            //DeliveryAddress A1 = new DeliveryAddress();
            //A1.City = "Cairo ";
            //A1.Street = "Talaat Harb";
            //Console.WriteLine(A1.City + "," + A1.Street);
            //DeliveryAddress A2 = new DeliveryAddress();
            //A2 = A1;
            //A2.City = "Giza ";
            //A2.Street = "Faisal";
            //Console.WriteLine(A2.City + "," + A2.Street);
            //Console.WriteLine(A1.City + "," + A1.Street);


            #endregion

            #region Part2

            //Customer customer1 = new Customer();
            //customer1.Name = "Ahmed";

            //Console.WriteLine(customer1.Name);
            //Customer customer2 = new Customer();
            //customer1 = customer2;
            //customer2.Name = "Hamada";
            //Console.WriteLine(customer2.Name);
            //Console.WriteLine(customer1.Name);

            #endregion

            #endregion

            #region Q2

            //Shipment E1 = new Shipment();
            //E1.SetDescription("Laptop Shipment");
            //Console.WriteLine(E1.GetDescription());
            //E1.SetWeight(5);
            //Console.WriteLine(E1.GetWeight());
            //E1.SetDeliveryFee(12);
            //Console.WriteLine(E1.GetDeliveryFee());

            #endregion

            #region Q3


            //Driver driver = new Driver(2, "Ahmed Ali", "01030320746");

            //DeliveryCenter center = new DeliveryCenter();
            //string centerName;

            //do
            //{
            //    Console.Write("Enter Center Name: ");
            //    centerName = Console.ReadLine();

            //    if (string.IsNullOrWhiteSpace(centerName))
            //    {
            //        Console.WriteLine("Center Name cannot be empty. Please enter it again.");
            //    }

            //} while (string.IsNullOrWhiteSpace(centerName));
            //center.CenterName = centerName;

            //center.Driver = driver;

            //Console.WriteLine($"Driver ID: {center.Driver.DriverId}");
            //Console.WriteLine($"Driver Name: {center.Driver.FullName}");
            //Console.WriteLine($"Driver Phone: {center.Driver.PhoneNumber}");

            //Console.WriteLine("---------------------");

            //Console.WriteLine("\nEnter Standard Shipment Data");

            //Console.Write("TrackingCode: ");
            //string standardCode = Console.ReadLine();

            //Console.Write("Description: ");
            //string standardDesc = Console.ReadLine();

            //Console.Write("Weight: ");
            //decimal standardWeight = decimal.Parse(Console.ReadLine());

            //Console.Write("DeliveryFee: ");
            //decimal standardFee = decimal.Parse(Console.ReadLine());

            //Console.Write("City: ");
            //string standardCity = Console.ReadLine();

            //Console.Write("Street: ");
            //string standardStreet = Console.ReadLine();

            //Console.Write("Building Number: ");
            //int standardBuilding = int.Parse(Console.ReadLine());

            //DeliveryAddress standardAddress =
            //    new DeliveryAddress(standardCity, standardStreet, standardBuilding);

            //StandardShipment standardShipment =
            //    new StandardShipment(
            //        standardCode,
            //        standardDesc,
            //        standardWeight,
            //        standardFee,
            //        standardAddress);

            //Console.WriteLine("---------------------");

            //Console.WriteLine("Enter Express Shipment Data");

            //Console.Write("TrackingCode: ");
            //string expressCode = Console.ReadLine();

            //Console.Write("Description: ");
            //string expressDesc = Console.ReadLine();

            //Console.Write("Weight: ");
            //decimal expressWeight = decimal.Parse(Console.ReadLine());

            //Console.Write("DeliveryFee: ");
            //decimal expressFee = decimal.Parse(Console.ReadLine());

            //Console.Write("City: ");
            //string expressCity = Console.ReadLine();

            //Console.Write("Street: ");
            //string expressStreet = Console.ReadLine();

            //Console.Write("Building Number: ");
            //int expressBuilding = int.Parse(Console.ReadLine());

            //DeliveryAddress expressAddress =
            //    new DeliveryAddress(expressCity, expressStreet, expressBuilding);

            //Console.Write("Extra Fee: ");
            //decimal extraFee = decimal.Parse(Console.ReadLine());

            //ExpressShipment expressShipment =
            //    new ExpressShipment(
            //        expressCode,
            //        expressDesc,
            //        expressWeight,
            //        expressFee,
            //        expressAddress,
            //        extraFee);

            //Console.WriteLine("---------------------");

            //Console.WriteLine("Enter International Shipment Data");

            //Console.Write("TrackingCode: ");
            //string internationalCode = Console.ReadLine();

            //Console.Write("Description: ");
            //string internationalDesc = Console.ReadLine();

            //Console.Write("Weight: ");
            //decimal internationalWeight = decimal.Parse(Console.ReadLine());

            //Console.Write("DeliveryFee: ");
            //decimal internationalFee = decimal.Parse(Console.ReadLine());

            //Console.Write("City: ");
            //string internationalCity = Console.ReadLine();

            //Console.Write("Street: ");
            //string internationalStreet = Console.ReadLine();

            //Console.Write("Building Number: ");
            //int internationalBuilding = int.Parse(Console.ReadLine());

            //DeliveryAddress internationalAddress =
            //    new DeliveryAddress(
            //        internationalCity,
            //        internationalStreet,
            //        internationalBuilding);

            //Console.Write("Destination Country: ");
            //string destinationCountry = Console.ReadLine();

            //Console.Write("Customs Fee: ");
            //decimal customsFee = decimal.Parse(Console.ReadLine());

            //InternationalShipment internationalShipment =
            //    new InternationalShipment(
            //        internationalCode,
            //        internationalDesc,
            //        internationalWeight,
            //        internationalFee,
            //        internationalAddress,
            //        destinationCountry,
            //        customsFee);

            //Console.WriteLine("---------------------");



            //center.PrintAllShipments();

            //DeliveryHelper.PrintShipmentDetails(standardShipment);
            //DeliveryHelper.PrintShipmentDetails(expressShipment);
            //DeliveryHelper.PrintShipmentDetails(internationalShipment);

            //Console.WriteLine("Updating Weight...");

            //Console.WriteLine($"Original Weight : {standardShipment.Weight} KG");

            //standardShipment.UpdateWeight(5);

            //Console.WriteLine($"Updated Weight : {standardShipment.Weight} KG");

            //standardShipment.UpdateWeight(5, 0.5m);

            //Console.WriteLine($"Updated Weight After Packing : {standardShipment.Weight} KG");

            //Console.WriteLine("---------------------");

            //Shipment[] mixedShipments =
            //{
            //    standardShipment,
            //    expressShipment,
            //    internationalShipment
            // };

            //foreach (Shipment s in mixedShipments)
            //{
            //    s.PrintShipment();
            //}

            //// Search
            //Console.Write("Enter Tracking Code to Search: ");
            //string searchCode = Console.ReadLine();

            //Shipment foundShipment = center[searchCode];

            //if (foundShipment != null)
            //    foundShipment.PrintShipment();
            //else
            //    Console.WriteLine("Shipment not found.");



            //Console.Write("Enter Tracking Code to Remove: ");
            //string removeCode = Console.ReadLine();

            //if (center.RemoveShipment(removeCode))
            //    Console.WriteLine("Shipment removed successfully.");
            //else
            //    Console.WriteLine("Shipment not found.");


            //center.PrintAllShipments();
            //Console.WriteLine("---------------------");

            //Console.WriteLine($"Enter Shipment {1} Data");

            //Console.Write("TrackingCode: ");
            //string code = Console.ReadLine();

            //Console.Write("Description: ");
            //string desc = Console.ReadLine();

            //Console.Write("Weight: ");
            //decimal weight = decimal.Parse(Console.ReadLine());

            //Console.Write("DeliveryFee: ");
            //decimal fee = decimal.Parse(Console.ReadLine());


            //Console.Write("City: ");
            //string city = Console.ReadLine();

            //Console.Write("Street: ");
            //string street = Console.ReadLine();

            //Console.Write("Building Number: ");
            //int building = int.Parse(Console.ReadLine());


            //DeliveryAddress address =
            //    new DeliveryAddress(city, street, building);


            //Shipment newshipment =
            //    new StandardShipment(code, desc, weight, fee, address);


            //bool added = center.AddShipment(newshipment);


            //if (added)
            //    Console.WriteLine("Shipment added successfully.");


            //DeliveryAddress address1 = new DeliveryAddress("cairo", "Tahrir Street", 15);
            //DeliveryAddress address2 = address1;
            //address2.City = "Giza";
            //address2.Street = "Faisal";
            //address2.BuildingNumber = 20;
            //Console.WriteLine(address1.GetFullAddress());
            //Console.WriteLine(address2.GetFullAddress());


            //Shipment shipment = new Shipment(
            //    "SH-101",
            //    "Laptop",
            //    3,
            //    100,
            //    address1
            //);

            //shipment.PrintShipment// CompletedShipment is a sealed class,
            // so no class can inherit from it.

            // GenerateCustomsReport() is a sealed override in PriorityInternationalShipment,
            // so derived classes cannot override it again.



            //            center.AddShipment(standardShipment);
            //            center.AddShipment(expressShipment);
            //            center.AddShipment(internationalShipment);

            //            center.PrintAllShipments();

            //            Console.WriteLine("==========================================");
            //            Console.WriteLine("Tracking Status");
            //            Console.WriteLine("==========================================");

            //            center.PrintTrackingStatuses();

            //            Console.WriteLine("==========================================");
            //            Console.WriteLine("Insurance");
            //            Console.WriteLine("==========================================");

            //            center.CalculateInsurance();

            //            Console.WriteLine("==========================================");

            //            ITrackable[] trackableShipments =
            //            {
            //    standardShipment,
            //    expressShipment,
            //    internationalShipment
            //};

            //            foreach (ITrackable item in trackableShipments)
            //            {
            //                Console.WriteLine(item.GetTrackingStatus());
            //            }

            //            IInsurable[] insurableShipments =
            //            {
            //    standardShipment,
            //    expressShipment,
            //    internationalShipment
            //};

            //            foreach (IInsurable item in insurableShipments)
            //            {
            //                Console.WriteLine(item.CalculateInsurance());
            //            }

            //            Console.WriteLine("==========================================");
            //            Console.WriteLine("Interface Polymorphism Demonstrated Successfully.");



            #endregion

            // Q3 help with AI  المشكله معايا في الindexer لو لقيتي مشكله في السؤال يبقي المشكله بسبب indexer علشان انا مش فاهمه اوي 

            #region Q1 OOP04

            // a) Abstraction is the process of hiding implementation details and showing only the essential features of an object
            // b) Because Abstraction is one of the fundamental four pillars of Object-Oriented Programming. It helps us hide unnecessary implementation details and expose only the essential functionality, which makes the code easier to use and understand.

            #endregion

            #region Q2 OOP04


            /*
            a) 
             Abstract Class:

              Can contain abstract methods and implemented methods
              Can contain fields/state
              A class can inherit from only one abstract/base class
              
             Interface:
              
              Defines a contract that a class must follow
              A class can implement multiple interfaces
              Interfaces are useful for defining common behavior between classes that may not have the same base class
                           
             
             */

            /*

             b)
            Choose an Interface when you want to define a common contract/behavior that can be implemented by different classes  
            especially when those classes may already inherit from different classes
            also, use an Interface when a class needs to implement multiple behaviors because C# allows a class to implement multiple interfaces

             */

            /*
             c)
             No, a class cannot inherit from multiple abstract classes because C# supports single class inheritance

               Yes, a class can implement multiple interfaces

             */

            #endregion

        }
    }
}
