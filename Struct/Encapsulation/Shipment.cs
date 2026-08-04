using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP01.Struct.Encapsulation
{
    internal class Shipment
    {

        #region Q2
        //a)
        // The fields are public, so they can be modified directly
        // There is no validation for invalid values
        //The class does not protect its internal data

        //b) 
        //Use private fields to hide data and public properties to control access, validate values, and improve encapsulation.


        //private string Description;
        //private double Weight;
        //private decimal DeliveryFee;

        //public void SetDescription(string description)
        //{
        //    if (string.IsNullOrEmpty(description))
        //        throw new ArgumentNullException("description , can not be null");
        //    else
        //        Description = description;
        //}

        //public string GetDescription()
        //{
        //    return Description;
        //}

        //public void SetWeight(double weight)
        //{
        //    if (weight < 0)
        //        throw new ArgumentOutOfRangeException("weight , Weight cannot be negative");
        //    else
        //        Weight = weight;
        //}

        //public double GetWeight()
        //{
        //    return Weight;
        //}

        //public void SetDeliveryFee(decimal deliveryFee)
        //{
        //    if (deliveryFee < 0)
        //        throw new ArgumentOutOfRangeException("deliveryFee , Delivery fee cannot be negative");
        //    else
        //        DeliveryFee = deliveryFee;
        //}

        //public decimal GetDeliveryFee()
        //{
        //    return DeliveryFee;
        //}


        #endregion

    }
}
