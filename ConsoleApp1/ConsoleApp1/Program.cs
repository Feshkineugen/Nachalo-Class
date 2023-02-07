static void Main()
{
 
    House[] house =
        {
                    new House {Address = "Пушкино 137", Floor = 3, RoomCount = 2, Square = 31.5},
                    new House {Address = "Андреево 120", Floor = 1, RoomCount = 3, Square = 44.6},
                    new House {Address = "Алексеево 140", Floor = 5, RoomCount = 3, Square = 50.2},
                    new House {Address = "Максиво 100", Floor = 6, RoomCount = 4, Square = 62.3},
                    new House {Address = "Елисеево 99", Floor = 8, RoomCount = 1, Square = 37.4},
                    new House {Address = "Молчанкино 1", Floor = 12, RoomCount = 7, Square = 100.6},
                    new House {Address = "Васильево 165", Floor = 9, RoomCount = 5, Square = 72.8}
                };

    bool ex = false;

    // список квартир, имеющих заданное число комнат;
    Console.Write("Кол-во комнат: ");
    int n = int.Parse(Console.ReadLine());

    foreach (House h in house)
        if (h.RoomCount == n)
        {
            Console.WriteLine(h.ToString());
            ex = true;
        }
    if (!ex) Console.WriteLine("Таких квартир нет!");
    ex = false;

    // список квартир, имеющих заданное число комнат и расположенных на этаже,
    // который находится в определенном промежутке;
    Console.Write("Кол-во комнат: ");
    n = int.Parse(Console.ReadLine());
    Console.Write("Этаж a: ");
    int a = int.Parse(Console.ReadLine());
    Console.Write("Этаж b: ");
    int b = int.Parse(Console.ReadLine());

    foreach (House h in house)
        if (h.RoomCount == n && h.Floor >= a && h.Floor <= b)
        {
            Console.WriteLine(h.ToString());
            ex = true;
        }
    if (!ex) Console.WriteLine("Таких квартир нет!");
    ex = false;

    // список квартир, имеющих площадь, превосходящую заданную.
    Console.Write("Минимальная площадь: ");
    double d = double.Parse(Console.ReadLine());

    foreach (House h in house)
        if (h.Square > d)
        {
            Console.WriteLine(h.ToString());
            ex = true;
        }
    if (!ex) Console.WriteLine("Таких квартир нет!");


    Console.ReadKey();
}