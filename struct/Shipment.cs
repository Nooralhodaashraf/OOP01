using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Assignment01_OOP
{
    public struct Shipment
    {
        #region feilds 
        private string trackingCode;
        private string description;
        private double weight;
        private decimal deliveryFee;
        #endregion

        #region properties && validation
        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get { return trackingCode; }
            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    trackingCode = value;
                }
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    description = value;
                }
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }
        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    deliveryFee = value;
                }
            }
        }

        //estimation
        public decimal EstimatedCost
        {
            get
            {
                return DeliveryFee + (decimal)(Weight * 5);
            }
        }

        #endregion

        #region CTOR
        public Shipment(string trackingCode)
        {
            // Initialize fields with default values
            this.trackingCode = "";
            this.description = "";
            this.weight = 0;
            this.deliveryFee = 0;
            this.Destination = new DeliveryAddress();

            // Set the tracking code using the property to ensure validation
            TrackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
            Destination = new DeliveryAddress("Cairo", "Nasr City", 1);
        }

        public Shipment(string trackingCode, string description, double weight, decimal deliveryFee, DeliveryAddress destination)
        {
            // Initialize fields first because this is a struct
            this.trackingCode = "";
            this.description = "";
            this.weight = 0;
            this.deliveryFee = 0;
            this.Destination = new DeliveryAddress();

            // Use properties for validation
            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;
        }

        #endregion

        #region deliveryFee
        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }
        #endregion

        #region PrintShipment()
        public void PrintShipment(string city, string street, int buildingNumber)
        {
            Console.WriteLine("Shipment Information:");
            Console.WriteLine($"Tracking Code: {TrackingCode}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Delivery Fee: {DeliveryFee}");
            Console.WriteLine($"Destination: {Destination.GetFullAddress(city, street, buildingNumber)}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost}");
        }
        #endregion
    }
}

