namespace RubikCube.Api.Features.Cube.Move;

public class MoveMapper
{
    public static IReadOnlyList<StickerDto> ToDto(Color[,] grid)
    {
        var list = new List<StickerDto>();

        for (int y = 0; y < grid.GetLength(0); y++)
        {
            for (int x = 0; x < grid.GetLength(1); x++)
            {
                char c = grid[y, x];
                if (c != '\0') 
                {
                    list.Add(new StickerDto
                    {
                        X = x,
                        Y = y,
                        Color = c.ToString()
                    });
                }
            }
        }

        return list;
    }

    public static Color[,] FromDto(IEnumerable<StickerDto> stickers)
    {
        var grid = new Color[9, 12];

        foreach (var sticker in stickers)
        {
            Color color =  Color.From(sticker.Color[0]);

            if (sticker.X >= 0 && sticker.X < 12 && sticker.Y >= 0 && sticker.Y < 9)
            {
                grid[sticker.Y, sticker.X] = color;
            }
        }

        return grid;
    }
}