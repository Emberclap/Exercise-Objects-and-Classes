namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = " ";

            List <Catalog> vehicleCatalog = new List <Catalog> ();
           
            while ((input = Console.ReadLine()) != "End")
            {
                List<string> vehicleInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                string type = vehicleInfo[0];
                type = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(type.ToLower());
                string model = vehicleInfo[1];
                string color = vehicleInfo[2];
                double horsePower = double.Parse(vehicleInfo[3]);
                Catalog vehicle = new Catalog (type, model, color, horsePower);
                vehicleCatalog.Add (vehicle);
            }
            string command = " ";
            while ((command = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Catalog page in vehicleCatalog)
                {
                    if (page.Model == command)
                    {
                        Console.WriteLine($"Type: {page.Type}");
                        Console.WriteLine($"Model: {page.Model}");
                        Console.WriteLine($"Color: {page.Color}");
                        Console.WriteLine($"Horsepower: {page.Horsepower}");
                    }
                    
                }
            }
            double carsAverageHorsePower = 0;
            int carCounter = 0;
            int TruckCounter = 0;
            double trucksAverageCarsAverage = 0;
            foreach (Catalog page in vehicleCatalog)
            {
                if (page.Type == "Car")
                {
                    carsAverageHorsePower += page.Horsepower;
                    carCounter++;
                }
                else if (page.Type == "Truck")
                {
                    trucksAverageCarsAverage += page.Horsepower;
                    TruckCounter++;
                }
            }
            if (carCounter > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsePower/carCounter:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }
            if (TruckCounter > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {trucksAverageCarsAverage/TruckCounter:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }
        }
    }
    class Catalog
    {
        public Catalog(string type, string model, string color, double horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Horsepower { get; set; }
    }
}