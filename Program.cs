namespace CarRentalPolymorephism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--SmartCar Rentals System--");
            // Create the vehicle objects
            Car toyotaCorolla = new Car("Toyota", "Corolla", 2022, "TCRL2022", false);
            Car mercedesE300 = new Car("Mercedes", "E300", 2023, "MRCDSE300", true);
            Truck volvoFH16 = new Truck("Volvo", "FH16", 2021, "VLVFH16", 18000.0);
            Motorbike hondaCBR = new Motorbike("Honda", "CBR", 2019, "HNDCBR19", true);

            Console.WriteLine("Available Vehicles:");
            Console.WriteLine("-------------------");
            Console.WriteLine("Select Option: ");
            Console.WriteLine("1. Add New Vehicle ");
            Console.WriteLine("2. Rentals Vehicle ");
            Console.WriteLine("3. Exist ");

            char option = Console.ReadKey().KeyChar;

            switch (option)
            {
                case '1':
                    AddNewVehicle();
                    Console.ReadLine();
                    break;
            }
            
            Console.ReadKey(); // Keep the console open


        }


        // Add New Vehicle function 
        public static void AddNewVehicle()
        {
            Console.WriteLine("Select the type of vehicle:");
            Console.WriteLine("1. Car");
            Console.WriteLine("2. Truck");
            Console.WriteLine("3. Motorbike");

            char option1 = Console.ReadKey().KeyChar;

            switch (option1) 
            { 
                case'1':

                    break;

                case '2':

                    break;

                case '3':

                    break;
            }
        }
    }
    
}
