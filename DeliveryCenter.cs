using AssignmentOOP01.Struct.Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP01
{
    internal class DeliveryCenter
    {
        //private string centerName;
        //public Driver Driver { get; set; }

        //public string CenterName
        //{
        //    get { return centerName; }
        //    set
        //    {
        //        if (string.IsNullOrWhiteSpace(value))
        //        {
        //            throw new ArgumentException("Center Name cannot be empty.");
        //            return;
        //        }

        //        centerName = value;
        //    }
        //}
        //private Shipment[] shipments;
        //public DeliveryCenter()
        //{
        //    shipments = new Shipment[20];
        //}

        //public bool AddShipment(Shipment shipment)
        //{
        //    for (int i = 0; i < shipments.Length; i++)
        //    {
        //        if (shipments[i] == null)
        //        {
        //            shipments[i] = shipment;
        //            return true;
        //        }
        //    }

        //    return false;
        //}

        //public Shipment this[int index]
        //{
        //    get
        //    {
        //        if (index >= 0 && index < shipments.Length)
        //        {
        //            return shipments[index];
        //        }

        //        return null;
        //    }

        //    set
        //    {
        //        if (index >= 0 && index < shipments.Length)
        //        {
        //            shipments[index] = value;
        //        }
        //    }
        //}


        //public Shipment this[string trackingCode]
        //{
        //    get
        //    {
        //        for (int i = 0; i < shipments.Length; i++)
        //        {
        //            if (shipments[i] != null &&
        //                shipments[i].TrackingCode == trackingCode)
        //            {
        //                return shipments[i];
        //            }
        //        }

        //        return null;
        //    }

        //}

        //public bool RemoveShipment(string trackingCode)
        //{
        //    for (int i = 0; i < shipments.Length; i++)
        //    {
        //        if (shipments[i] != null &&
        //            shipments[i].TrackingCode == trackingCode)
        //        {
        //            shipments[i] = null;
        //            return true;
        //        }
        //    }

        //    return false;
        //}


        //public void PrintAllShipments()
        //{
        //    Console.WriteLine("----------------------------------------");
        //    Console.WriteLine($"Delivery Center : {CenterName}");
        //    Console.WriteLine("----------------------------------------");

        //    for (int i = 0; i < shipments.Length; i++)
        //    {
        //        if (shipments[i] != null)
        //        {
        //            shipments[i].PrintShipment();
        //        }
        //    }
        //}

    }
}
