string inputSize;
string inputColor;
bool validInputSize = false;
int parsedSize = 0;

string [] colors = { "Red", "Green", "Yellow", "Magenta", "Blue", "White" };
bool validColor = false;

Console.WriteLine("Enrer size of square (from 3 to 20)");

while (!validInputSize)
{
    inputSize = Console.ReadLine();

    parsedSize = int.Parse(inputSize);

    if (parsedSize >= 3 && parsedSize <= 20)
    {
        validInputSize = true;

        Console.WriteLine("Enter name of color of the square (\"Red\", \"Green\", \"Yellow\", \"Magenta\", \"Blue\", \"White\")");
        
        inputColor = Console.ReadLine();
      //  ConsoleColor chosenColor = inputColor;


        for (int i = 0; i < parsedSize; i++)
        {
            for (int j = 0; j < parsedSize; j++)
            {
                if (i == 0 || i == parsedSize - 1 || j == 0 || j == parsedSize - 1)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write(" * ");
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("   ");
                }

            }
            Console.WriteLine();

        }

        Console.BackgroundColor = ConsoleColor.Black;
        return;
    }
    else
    {
        Console.WriteLine("You entered incorrect value, please try again!");
        validInputSize = false;
    }

}

