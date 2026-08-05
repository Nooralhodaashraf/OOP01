using System.Security.Principal;

namespace Assignment01_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 001

            #region Q001
            #region Part 001 Q01 a)
            //a)	 What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            // it wont effect the original variable because it is a struct and structs are value types so it creates a new copy of the variable
            //DeliveryAddress address01 = new DeliveryAddress();
            //    address01.City = "Cairo";
            //    address01.Street = "dokki";
            //    DeliveryAddress address02 = new DeliveryAddress();
            //    address02 = address01;
            //    address02.City = "Giza";
            //    Console.WriteLine(address02.City);// Giza
            //    Console.WriteLine(address01.City);// Cairo
            //not the same 

            #endregion

            #region Part 001 Q01 b)
            //b)	 What happens when a Customer variable is copied into another variable and one variable modifies the object
            //customer is a class == refrance type == when take a copy and modify it will modify the original object because both variables point to the same object in memory
            //Customer customer01 = new Customer();
            //customer01.Name = "Ahmed";
            //Customer customer02 = new Customer();
            //customer02 = customer01;
            //customer02.Name = "Ali";
            //Console.WriteLine(customer02.Name);// Ali   
            //Console.WriteLine(customer01.Name);//Ali
            #endregion

            #endregion

            #region Q002
            #region a)
            //a)	a) Identify at least three problems with this design from an encapsulation perspective.
            ////1- The fields are public, which means they can be accessed and modified directly from outside the class. This violates the principle of encapsulation, which states that the internal state of an object should be hidden from the outside world.
            //Shipment shipment = new Shipment();
            //shipment.Description = "Electronics";// The fields are public
            //shipment.Weight = 2.5;// can be accessed and modified directly from outside the class.
            //shipment.DeliveryFee = 30.0m;

            //2- The class does not provide any methods to manipulate the data, which means that the data can only be accessed and modified directly. This makes it difficult to enforce any rules or constraints on the data.
            //3- The class does not provide any validation or error checking, which means that invalid data can be stored in the object. This can lead to unexpected behavior and bugs in the program.
            #endregion

            #region b)
            //b)	b) How can private fields and public properties improve this design?
            //Private fields and public properties can improve the design of the Shipment class by providing a way to encapsulate the data and control access to it. By making the fields private, we can prevent direct access to the data from outside the class, which helps to enforce encapsulation. Public properties can be used to provide controlled access to the data, allowing us to implement validation and error checking when setting or getting the values of the fields. This can help to ensure that the data is always in a valid state and prevent unexpected behavior in the program.
            //look at the struct file for ex for it ...
            #endregion
            #endregion
            #endregion

            #region Part 002
            #region Smart Delivery Management System
        
            DeliveryAddress address = new DeliveryAddress();

            Console.WriteLine("Please enter your Address:");

            bool IsParsed;

            //City
            string city;
            do
            {
                Console.WriteLine("City:");
                IsParsed = int.TryParse(city = Console.ReadLine(), out int cityName);

            } while (IsParsed || string.IsNullOrWhiteSpace(city));

            //Street
            string street;
            do
            {
                Console.WriteLine("Street:");
                IsParsed = int.TryParse(street = Console.ReadLine(), out int streetName);

            } while (IsParsed || string.IsNullOrWhiteSpace(street));

            //Building Number
            int buildingNumber;
            do
            {
                Console.WriteLine("Building Number:");
                IsParsed = !int.TryParse(Console.ReadLine(), out buildingNumber);
            } while (IsParsed || buildingNumber <= 0 );

           Console.WriteLine( address.GetFullAddress(city, street, buildingNumber));





        


            #endregion
            #endregion
    }
    }
}