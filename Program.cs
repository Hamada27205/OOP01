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

            


            //DeliveryCenter center = new DeliveryCenter();

           
            //    Console.WriteLine($"Enter Shipment {1} Data");

            //    Console.Write("TrackingCode: ");
            //    string code = Console.ReadLine();

            //    Console.Write("Description: ");
            //    string desc = Console.ReadLine();

            //    Console.Write("Weight: ");
            //    double weight = double.Parse(Console.ReadLine());

            //    Console.Write("DeliveryFee: ");
            //    decimal fee = decimal.Parse(Console.ReadLine());


            //    Console.Write("City: ");
            //    string city = Console.ReadLine();

            //    Console.Write("Street: ");
            //    string street = Console.ReadLine();

            //    Console.Write("Building Number: ");
            //    int building = int.Parse(Console.ReadLine());


            //    DeliveryAddress address =
            //        new DeliveryAddress(city, street, building);


            //    Shipment newshipment =
            //        new Shipment(code, desc, weight, fee, address);


            //    bool added = center.AddShipment(newshipment);


            //    if (added)
            //        Console.WriteLine("Shipment added successfully.");
            

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

            //shipment.PrintShipment();

            #endregion
            
            // Q3 help with AI  المشكله معايا في الindexer لو لقيتي مشكله في السؤال يبقي المشكله بسبب indexer علشان انا مش فاهمه اوي 

        }
    }
}
