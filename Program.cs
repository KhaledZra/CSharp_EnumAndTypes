namespace EnumAndTypes;

internal class Program
{
    public static void Main(string[] args)
    {
        int choice = 0;
        Size size = (Size)choice;

        do
        { 
            Console.Clear();
            Console.WriteLine("Pick numbers 1, 2 or 3");
            Console.Write("Choice: ");
        } while (!int.TryParse(Console.ReadLine(), out choice));
        
        if ((choice >= 0) && (choice < Enum.GetNames(typeof(Size)).Length))
        {
            size = (Size)choice;
        }

        Console.Clear();
        if (size == Size.Small)
        {
            Console.WriteLine($"You managed to pick something small, humble maybe?. size: {size.ToString()}");
        }
        else if (size == Size.Medium)
        {
            Console.WriteLine($"You seem to like average. size: {size.ToString()}");
        }
        else if (size == Size.Large)
        {
            Console.WriteLine($"Uhmm.. You seem to aim for more than enough. size: {size.ToString()}");
        }
        else if (size == Size.Undefined)
        {
            Console.WriteLine($"You tried to be smart by entering another number than what was provided!");
        }
    }
}
