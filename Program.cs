namespace Assignment01_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

        }
    }
}
