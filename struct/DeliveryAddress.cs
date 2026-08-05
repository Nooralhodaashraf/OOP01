using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment01_OOP
{
    public struct DeliveryAddress
    {

        #region feilds
        private string City;
        private string Street;
        private int BuildingNumber ;
        #endregion

        #region CTOR
        public DeliveryAddress(string city, string street, int buildingNumber)
        {
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
        }
        #endregion
        #region GetFullAddress() method
        public string GetFullAddress(string City, string Street, int BuildingNumber)
        {
            return $"City: {City}, Street: {Street}, Building Number: {BuildingNumber}";
        }

        #endregion 


    }

    //public class Customer
    //{
    //    public string Name;
    //}

}
