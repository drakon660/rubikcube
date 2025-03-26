namespace RubikCube.Api.Features.Cube.Read;

public record StickerDto
{
    public int X { get; init; }
    public int Y { get; init; }
    public char Color { get; init; }
}

public class RubiksCubeResponse
{
    public IReadOnlyList<StickerDto> Stickers { get; init; }
}