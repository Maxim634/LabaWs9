class Garage
{
    private List<Car> cars = new List<Car>();

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public delegate void WashDelegate(Car car);

    public void WashAllCars(WashDelegate washMethod)
    {
        foreach (Car car in cars)
        {
            washMethod(car);
        }
    }
}