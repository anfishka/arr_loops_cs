string inputSize;
string inputColor;
bool validInputSize = false;
int parsedSize = 0;

string [] colors = { "Red", "Green", "Yellow", "Magenta", "Blue", "White" };
ConsoleColor[] consoleColors = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Magenta, ConsoleColor.Blue, ConsoleColor.White };

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
        

        while(!validColor)
        {
            inputColor = Console.ReadLine();
            for (int i = 0; i < colors.Length; i++)
            {
                if (string.Equals(colors[i], inputColor, StringComparison.OrdinalIgnoreCase))
                {
                    validColor = true;
                    Console.BackgroundColor = consoleColors[i];
                    break;
                }
            }
            if (!validColor)
            {
                Console.WriteLine("Invalid color! Please enter correct name of color");
            }
        }

        ConsoleColor defaultColor = Console.BackgroundColor;

        int xPos = 0;
        int yPos = 0;

        ConsoleKeyInfo keyInfo;

        do
        {
            Console.Clear();
            for (int i = 0; i < parsedSize; i++)
            {
                for (int j = 0; j < parsedSize; j++)
                {
                    if (i == 0 || i == parsedSize - 1 || j == 0 || j == parsedSize - 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(xPos + j * 3, yPos + i);
                        Console.Write(" * ");
                    }
                    else
                    {
                        Console.BackgroundColor = defaultColor;
                        Console.SetCursorPosition(xPos + j * 3, yPos + i);
                        Console.Write("   ");
                    }

                }
                Console.WriteLine();

            }

            Console.BackgroundColor = ConsoleColor.Black;
            keyInfo = Console.ReadKey();

            switch (keyInfo.Key)
            {
                case ConsoleKey.W:
                    if (yPos > 0)
                        yPos--;
                    break;
                case ConsoleKey.S:
                    if (yPos < Console.WindowWidth - parsedSize)
                        yPos++;
                    break;
                case ConsoleKey.A:
                    if (xPos > 0)
                        xPos -= 3;
                    break;
                case ConsoleKey.D:
                    if (xPos < Console.WindowWidth - parsedSize * 3)
                        xPos += 3;
                    break;
            }
        } while (keyInfo.Key != ConsoleKey.Escape);
        Console.BackgroundColor = ConsoleColor.Black;
        return;
    }
    else
    {
        Console.WriteLine("You entered incorrect value, please try again!");
        validInputSize = false;
    }

}
