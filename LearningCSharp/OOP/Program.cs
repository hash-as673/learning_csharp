namespace LearningCSharp.OOP;


public class Program
{
    public static void Run()
    {
        Car car = new(speed: 80, noOfWheels: 4, model: "Toyota", color: "White");
        car.Accelerate();
        car.Breaks();
        car.PrintDetails();


        List<Vehicle> garage = [
          new Car(speed: 180, noOfWheels: 4, model: "Toyota", color: "White"),
            new Motorcycle(speed: 220, model: "Ducati")
        ];

        foreach (var vehicle in garage)
        {
            vehicle.Accelerate();
            vehicle.PrintDetails();
            Console.WriteLine();
        }

        Product p1 = new("Laptop",999.99m);
        Product p2 = new("Laptop",999.99m);

        System.Console.WriteLine(p1==p2);
        System.Console.WriteLine(p1);
        Product discontinuedLaptop = p1 with {Price = 799.99m};
        System.Console.WriteLine(discontinuedLaptop);

        Point point = new(10,20);
        double distance = point.GetDistance();
        System.Console.WriteLine(distance);

        
    }
}