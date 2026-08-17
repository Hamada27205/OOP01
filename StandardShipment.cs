using AssignmentOOP01.Interfaces;
using AssignmentOOP01.Struct;
using AssignmentOOP01.Struct.Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP01
{
    internal class StandardShipment : Shipment , IInsurable , ITrackable
    {



        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {

        }

        public override decimal EstimatedCost =>  DeliveryFee + (Weight* 5);

        public decimal CalculateInsurance()
        {
            return 0.05m * EstimatedCost;
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready";
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight} KG");
            Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
            Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine($" \n Estimated Cost : {EstimatedCost}");
        }

    }

}
