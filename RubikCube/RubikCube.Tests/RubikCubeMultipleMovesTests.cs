using FluentAssertions;

namespace RubikCube.Tests;

public class RubikCubeMultipleMovesTests
{
    [Fact]
    public void Check_If_F_With_F_Reverse_Gets_Solved()
    {
        var cube = new RubiksCube();
        
        var snapshot = cube.Grid.Snapshot();
        
        cube.ApplyFMove();
        cube.ApplyFInverseMove();

        cube.Grid.Should().BeEquivalentTo(snapshot);
    }
    
    [Fact]
    public void Check_If_R_With_R_Reverse_Gets_Solved()
    {
        var cube = new RubiksCube();
        
        var snapshot = cube.Grid.Snapshot();
        
        cube.ApplyRMove();
        cube.ApplyRInverseMove();

        cube.Grid.Should().BeEquivalentTo(snapshot);
    }
    
    [Fact]
    public void Check_If_U_With_U_Reverse_Gets_Solved()
    {
        var cube = new RubiksCube();
        
        var snapshot = cube.Grid.Snapshot();
        
        cube.ApplyUMove();
        cube.ApplyUInverseMove();

        cube.Grid.Should().BeEquivalentTo(snapshot);
    }
    
    [Fact]
    public void Check_If_B_With_B_Reverse_Gets_Solved()
    {
        var cube = new RubiksCube();
        
        var snapshot = cube.Grid.Snapshot();
        
        cube.ApplyBMove();
        cube.ApplyBInverseMove();

        cube.Grid.Should().BeEquivalentTo(snapshot);
    }
    
    [Fact]
    public void Check_If_L_With_L_Reverse_Gets_Solved()
    {
        var cube = new RubiksCube();
        
        var snapshot = cube.Grid.Snapshot();
        
        cube.ApplyLMove();
        cube.ApplyLInverseMove();

        cube.Grid.Should().BeEquivalentTo(snapshot);
    }
    
    [Fact]
    public void Check_If_D_With_D_Reverse_Gets_Solved()
    {
        var cube = new RubiksCube();
        
        var snapshot = cube.Grid.Snapshot();
        
        cube.ApplyDMove();
        cube.ApplyDInverseMove();

        cube.Grid.Should().BeEquivalentTo(snapshot);
    }
}