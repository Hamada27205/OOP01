using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP01.Struct.Encapsulation
{
    public class Shipment
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

        #region Q3

        //private string trackingCode;
        //private string description;
        //private decimal weight;
        //private decimal deliveryFee;
        //private DeliveryAddress destination;

        //public Shipment(string trackingCode)
        //{
        //    this.trackingCode = trackingCode;

        //    Description = "Unknown";
        //    Weight = 1;
        //    DeliveryFee = 50;
        //    Destination = new DeliveryAddress("Unknown", "Unknown", 0);
        //}


        //public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        //{
        //    this.trackingCode = trackingCode;

        //    Description = description;
        //    Weight = weight;
        //    DeliveryFee = deliveryFee;
        //    Destination = destination;
        //}

        //public string TrackingCode
        //{
        //    get { return trackingCode; }
        //}

        //public string Description
        //{
        //    get
        //    {
        //        return description;
        //    }

        //    set
        //    {
        //        if (!string.IsNullOrWhiteSpace(value))
        //        {
        //            description = value;
        //        }
        //    }
        //}

        //public decimal Weight
        //{
        //    get
        //    {
        //        return weight;
        //    }

        //    set
        //    {
        //        if (value > 0)
        //        {
        //            weight = value;
        //        }
        //    }
        //}


        //public decimal DeliveryFee
        //{
        //    get
        //    {
        //        return deliveryFee;
        //    }

        //    private set
        //    {
        //        if (value > 0)
        //        {
        //            deliveryFee = value;
        //        }
        //    }
        //}

        //public DeliveryAddress Destination
        //{
        //    get
        //    {
        //        return destination;
        //    }

        //    set
        //    {
        //        destination = value;
        //    }
        //}

        //public virtual decimal EstimatedCost
        //{
        //    get
        //    {
        //        return DeliveryFee + (Weight * 5);
        //    }
        //}

        //public void UpdateDeliveryFee(decimal newFee)
        //{
        //    if (newFee > 0)
        //    {
        //        DeliveryFee = newFee;
        //    }
        //}

        //public void PrintShipment()
        //{
        //    Console.WriteLine($"Tracking Code: {TrackingCode}");
        //    Console.WriteLine($"Description: {Description}");
        //    Console.WriteLine($"Weight: {Weight} KG");
        //    Console.WriteLine($"Delivery Fee: {DeliveryFee} EGP");
        //    Console.WriteLine($"Destination: {Destination.GetFullAddress()}");
        //    Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        //}

        #endregion

    }
}
