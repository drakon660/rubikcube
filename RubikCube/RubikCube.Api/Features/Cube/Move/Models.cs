namespace RubikCube.Api.Features.Cube.Move;

public record StickerDto
{
    public int X { get; init; }
    public int Y { get; init; }
    public string Color { get; init; }
}

public record MoveRequest
{
    public string Move { get; init; }   
    public IReadOnlyList<StickerDto> Stickers { get; init; }
}

public record MoveResponse
{
    public IEnumerable<StickerDto> Stickers { get; init; }
}