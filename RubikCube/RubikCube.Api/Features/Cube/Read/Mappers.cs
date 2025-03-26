namespace RubikCube.Api.Features.Cube.Read;

public static class ReadMapper
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
                        Color = c
                    });
                }
            }
        }

        return list;
    }
}