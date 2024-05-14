class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }

    public Car(string brand, string model)
    {
        Brand = brand;
        Model = model;
    }

    public override string ToString()
    {
        return $"{Brand} {Model}";
    }
}