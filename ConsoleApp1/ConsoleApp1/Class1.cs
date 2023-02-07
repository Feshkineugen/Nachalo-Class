internal class House
{
    public string Address { get; set; }
    public int Floor { get; set; }
    public int RoomCount { get; set; }
    public double Square { get; set; }

    public override string ToString()
    {
        return $"Адрес: {Address}, Этаж: {Floor}, Количество комнат: {RoomCount}, Площадь: {Square}";
    }
}
