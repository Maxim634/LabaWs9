class Program
{
    static void Main()
    {
        Garage garage = new Garage();

        garage.AddCar(new Car("Toyota", "Corolla"));
        garage.AddCar(new Car("BMW", "X5"));

        Washer washer = new Washer();

        Garage.WashDelegate washDelegate = new Garage.WashDelegate(washer.Wash);

        garage.WashAllCars(washDelegate);
    }
}