using AssignmentOOP01.Struct;
using AssignmentOOP01.Struct.Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP01
{
    //internal class InternationalShipment : Shipment
    //{

    //    private string destinationCountry;
    //    private decimal customsFee;

    //    public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destination)
    //    {
    //        DestinationCountry = destinationCountry;
    //        CustomsFee = customsFee;
    //    }

    //    public string DestinationCountry
    //    {
    //        get
    //        {
    //            return destinationCountry;
    //        }
    //        set
    //        {
    //            if (!string.IsNullOrWhiteSpace(value))
    //            {
    //                destinationCountry = value;
    //            }
    //        }
    //    }

    //    public decimal CustomsFee
    //    {

    //        get
    //        {
    //            return customsFee;
    //        }
    //        set
    //        {
    //            if (value >= 0)
    //            {
    //                customsFee = value;
    //            }
    //        }

    //    }

    //    public override decimal EstimatedCost
    //    {
    //        get
    //        {
    //            return DeliveryFee + (Weight * 5) + CustomsFee;
    //        }
    //    }

    //    public virtual void GenerateCustomsReport()
    //    {
    //        Console.WriteLine("Customs Report for International Shipment");
    //    }

    //    public override void PrintShipment()
    //    {
    //        base.PrintShipment();
    //        Console.WriteLine($"Destination Country : {DestinationCountry}\n Customs Fee : {CustomsFee} \n Estimated Cost : {EstimatedCost}");
    //    }

    //}
}
