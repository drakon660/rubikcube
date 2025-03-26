namespace RubikCube;

public partial class RubiksCube
{
    private void PrintSticker(char color)
    {
        ConsoleColor originalColor = Console.ForegroundColor;

        Console.ForegroundColor = color switch
        {
            'W' => ConsoleColor.White,
            'Y' => ConsoleColor.Yellow,
            'R' => ConsoleColor.Red,
            'O' => ConsoleColor.DarkYellow,
            'B' => ConsoleColor.Blue,
            'G' => ConsoleColor.Green,
            _ => throw new Exception("Color not recognized.")
        };

        Console.Write(color);

        Console.ForegroundColor = originalColor;
    }
    
    public void Print()
    {
        for (int y = 0; y < Grid.GetLength(0); y++)
        {
            for (int x = 0; x < Grid.GetLength(1); x++)
            {
                Console.Write("      ");
                if (Grid[y, x] != '\0')
                    PrintSticker(Grid[y, x]);

                Console.Write(Grid[y, x] == '\0' ? "   " : $" {Grid[y, x]}({y},{x})");
            }

            Console.WriteLine();
        }
    }
}