using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01_OOP
{
 
public struct DeliveryCenter
    {
        // Private array that can store up to 10 shipments
        private Shipment[] shipments;


        // Constructor
        public DeliveryCenter()
        {
            shipments = new Shipment[10];
        }


        // Integer Indexer
        public Shipment this[int index]
        {
            get
            {
                // Check if index is valid
                if (index >= 0 && index < shipments.Length)
                {
                    return shipments[index];
                }

                // Invalid index
                return default;
            }

            set
            {
                // Check if index is valid
                if (index >= 0 && index < shipments.Length)
                {
                    shipments[index] = value;
                }
            }
        }


        // String Indexer
        public Shipment this[string trackingCode]
        {
            get
            {
                // Search for the shipment by tracking code
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i].TrackingCode == trackingCode)
                    {
                        return shipments[i];
                    }
                }

                // No matching shipment found
                return default;
            }
        }


        // Add a shipment to the first available position
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                // Check if the position is available
                if (shipments[i].TrackingCode == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }

            // Delivery center is full
            return false;
        }
    }

}
