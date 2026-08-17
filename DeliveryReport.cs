using AssignmentOOP01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP01
{
    internal class DeliveryReport
    {

        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine($" Tracking Status : {shipment.GetTrackingStatus()}");
        }

        public void PrintInsurance(IInsurable shipment)
        {
            Console.WriteLine($" Insurance Cost : {shipment.CalculateInsurance()}");
        }

    }
}
