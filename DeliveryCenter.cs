using AssignmentOOP01.Struct.Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP01
{
    //internal class DeliveryCenter
    //{

    //    private Shipment[] shipments;
    //    public DeliveryCenter()
    //    {
    //        shipments = new Shipment[10];
    //    }

    //    public bool AddShipment(Shipment shipment)
    //    {
    //        for (int i = 0; i < shipments.Length; i++)
    //        {
    //            if (shipments[i] == null)
    //            {
    //                shipments[i] = shipment;
    //                return true;
    //            }
    //        }

    //        return false;
    //    }

    //    public Shipment this[int index]
    //    {
    //        get
    //        {
    //            if (index >= 0 && index < shipments.Length)
    //            {
    //                return shipments[index];
    //            }

    //            return null;
    //        }

    //        set
    //        {
    //            if (index >= 0 && index < shipments.Length)
    //            {
    //                shipments[index] = value;
    //            }
    //        }
    //    }


    //    public Shipment this[string trackingCode]
    //    {
    //        get
    //        {
    //            for (int i = 0; i < shipments.Length; i++)
    //            {
    //                if (shipments[i] != null &&
    //                    shipments[i].TrackingCode == trackingCode)
    //                {
    //                    return shipments[i];
    //                }
    //            }

    //            return null;
    //        }

    //    }


    //}
}
