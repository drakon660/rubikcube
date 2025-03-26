using System.Text.RegularExpressions;
using FastEndpoints;

namespace RubikCube.Api.Features.Cube.Move;

public class Endpoint : Endpoint<MoveRequest, MoveResponse>
{
    private const string MoveRegex = @"^\s*(?:[FRUBLD](?:')?\s*(?:,\s*[FRUBLD](?:')?\s*)*)?$";

    public override void Configure()
    {
        Post("/api/rubiksCube");
        AllowAnonymous();
        Throttle(
           hitLimit:5,
           durationSeconds:1
        );
    }

    public override async Task HandleAsync(MoveRequest request, CancellationToken cancellationToken)
    {
        var cube = new RubiksCube();
        var stickers = MoveMapper.FromDto(request.Stickers);

        cube.UpdateGrid(stickers); 

        var isMoveValid = Regex.IsMatch(request.Move, MoveRegex);
        
        if (isMoveValid)
        {
            var moves = request.Move.ToUpper()
                .Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
            cube.ApplyMoves(moves);

            await SendAsync(new()
            {
                Stickers = MoveMapper.ToDto(cube.Grid)
            }, cancellation: cancellationToken);
        }
        else
        {
            AddError("Invalid move format. Allowed format: F, R, U', etc.");
            await SendErrorsAsync(400, cancellation: cancellationToken);
        }
    }
}