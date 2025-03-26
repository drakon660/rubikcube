using FastEndpoints;

namespace RubikCube.Api.Features.Cube.Read;

public class Endpoint : EndpointWithoutRequest<RubiksCubeResponse>
{
    public override void Configure()
    {
        Get("/api/rubiksCube");
        AllowAnonymous();
    }
    
    public override Task HandleAsync(CancellationToken ct)
    {
        var cube = new RubiksCube();
   
        Response = new RubiksCubeResponse
        {
            Stickers = ReadMapper.ToDto(cube.Grid)
        };
        
        return Task.CompletedTask;
    }
}

