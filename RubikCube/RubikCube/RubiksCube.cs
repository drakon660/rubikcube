namespace RubikCube;

public partial class RubiksCube
{
    public Color[,] Grid { get; private set; } = new Color[9, 12];

    public RubiksCube()
    {
        for (int i = 0; i < 54; i++)
        {
            Color color = i switch
            {
                < 9 => Color.W,   // U
                < 18 => Color.R,  // R
                < 27 => Color.G,  // F
                < 36 => Color.Y,  // D
                < 45 => Color.O,  // L
                _ => Color.B     // B
            };

            var (x, y) = GetExplodedViewPosition(i);
            Grid[y, x] = color;
        }
    }

    private (int x, int y) GetExplodedViewPosition(int index)
    {
        int face = index / 9;
        int pos = index % 9;

        int row = pos / 3;
        int col = pos % 3;

        (int offsetX, int offsetY) = face switch
        {
            0 => (3, 0), // U
            1 => (6, 3), // R
            2 => (3, 3), // F
            3 => (3, 6), // D
            4 => (0, 3), // L
            5 => (9, 3), // B
            _ => (0, 0)
        };
        
        return (offsetX + col, offsetY + row);
    }
    
    public void ApplyMoves(params string[] moves)
    {
        foreach (var move in moves)
        {
            ApplyMove(move);
        }
    }

    public void ApplyMove(string move)
    {
        switch (move)
        {
            case "F":
                ApplyFMove();
                break;
            case "F'":
                ApplyFInverseMove();
                break;
            case "R":
                ApplyRMove();
                break;
            case "R'":
                ApplyRInverseMove();
                break;
            case "U":
                ApplyUMove();
                break;
            case "U'":
                ApplyUInverseMove();
                break;
            case "B":
                ApplyBMove();
                break;
            case "B'":
                ApplyBInverseMove();
                break;
            case "L":
                ApplyLMove();
                break;
            case "L'":
                ApplyLInverseMove();
                break;
            case "D":
                ApplyDMove();
                break;
            case "D'":
                ApplyDInverseMove();
                break;
            default:
                throw new ArgumentException("Invalid move");
        }
    }
    
    public void UpdateGrid(Color[,] stickers)
    {
        Grid = stickers;
    }
}