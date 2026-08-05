using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01_OOP
{
    //internal struct Shipment
    //{
    //    public string Description;
    //    public double Weight;
    //    public decimal DeliveryFee;
    //}
    public struct Shipment
    {
        #region feilds 
        private string description; 
        private double weight;
        private decimal deliveryFee;
        #endregion

        #region properties && validation
        public string Description
        { 
            get { return description; }
            set { if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Description cannot be empty.");
                description = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { if (value <= 0) throw new ArgumentException("Weight must be greater than 0.");
                weight = value; } 
        }
        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            set { if (value < 0) throw new ArgumentException("Delivery fee cannot be negative.");
                deliveryFee = value; } 
        }
        #endregion
    }
}
