Console.WriteLine("Welcome to the wonderful world of menus! Please select a menu:\n");

Console.WriteLine("1. Relevant Menu");
Console.WriteLine("2. Irrelevant Menu");
Console.WriteLine("3. Absurd Menu");

try
{
    Console.Write("\nEnter selection: ");
    char selectedMenu = Console.ReadKey().KeyChar;

    if (selectedMenu == '1')
    {
        Console.WriteLine("\n\nGood choice! Here is the Relevant Menu:\n");

        Console.WriteLine("a. Bits Inside Computer Memory");
        Console.WriteLine("b. Instructions Running in a Processor");
        Console.WriteLine("c. Neat and Tidy Files on a Disk Drive");

        Console.Write("\nEnter selection: ");
        char selectedItem = Console.ReadKey().KeyChar;

        switch (selectedItem)
        {
            case 'a':
                Console.WriteLine("\n\nYou've selected Bits Inside Computer Memory!");
                break;
            case 'b':
                Console.WriteLine("\n\nYou've selected Instructions Running in a Processor!");
                break;
            case 'c':
                Console.WriteLine("\n\nYou've selected Neat and Tidy Files on a Disk Drive!");
                break;
            default:
                throw new Exception("You've selected nothing! You will receive nothing!");
        }
    }
    else if (selectedMenu == '2')
    {
        Console.WriteLine("\n\nGood choice! Here is the Irrelevant Menu:\n");

        Console.WriteLine("a. A Sword Wedged Firmly in a Stone");
        Console.WriteLine("b. Two Slices of American Cheese");
        Console.WriteLine("c. A Crisp One Dollar Bill");

        Console.Write("\nEnter selection: ");
        char selectedItem = Console.ReadKey().KeyChar;

        switch (selectedItem)
        {
            case 'a':
                Console.WriteLine("\n\nYou've selected A Sword Wedged Firmly in a Stone!");
                break;
            case 'b':
                Console.WriteLine("\n\nYou've selected Two Slices of American Cheese!");
                break;
            case 'c':
                Console.WriteLine("\n\nYou've selected A Crisp One Dollar Bill!");
                break;
            default:
                throw new Exception("You've selected nothing! You will receive nothing!");
        }
    }
    else if (selectedMenu == '3')
    {
        Console.WriteLine("\n\nGood choice! Here is the Absurd Menu:\n");

        Console.WriteLine("a. Six Ounces of Funny Jokes");
        Console.WriteLine("b. The Feeling of the Number 5");
        Console.WriteLine("c. A Bed Made of Sleep");

        Console.Write("\nEnter selection: ");
        char selectedItem = Console.ReadKey().KeyChar;

        switch (selectedItem)
        {
            case 'a':
                Console.WriteLine("\n\nYou've selected Six Ounces of Funny Jokes!");
                break;
            case 'b':
                Console.WriteLine("\n\nYou've selected The Feeling of the Number 5!");
                break;
            case 'c':
                Console.WriteLine("\n\nYou've selected A Bed Made of Sleep!");
                break;
            default:
                throw new Exception("You've selected nothing! You will receive nothing!");
        }
    }
    else
    {
        throw new Exception("You did not make a proper choice. You get no menu.");
    }
}
catch (Exception error)
{
    Console.WriteLine($"\n\n{error.Message}");
}