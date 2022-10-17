Console.Write("Where are you from? (Sligo, Ireland, Europe, Other): ");
string place = Console.ReadLine().ToLower();

double discount = 0;

switch (place)
{
    case "sligo":
        discount = 0.3 * 100;
        break;
    case "ireland":
        discount = 0.2 * 100;
        break;
    case "europe":
        discount = 0.1 * 100;
        break;
    default:
        discount = 0;
        break;
}

double price = 100 - discount;

Console.WriteLine($"The cost for a round of golf is {price}");
