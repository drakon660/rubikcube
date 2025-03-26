using FluentAssertions;

namespace RubikCube.Tests;

public class RubikCubeTests
{
    [Fact]
    public void Check_If_Upgrade_Grid_Works_Correctly()
    {
        var cube = new RubiksCube();
        
        var grid = new Color[9, 12];
        
        grid[1, 2] = Color.O;
        
        cube.UpdateGrid(grid);
        
        cube.Grid[1,2].Should().Be(Color.O);
    }

    [Fact]
    public void Check_Char_To_Color_Conversion()
    {
        Color.From('W').Should().Be(Color.W);
        Color.From('G').Should().Be(Color.G);
        Color.From('Y').Should().Be(Color.Y);
        Color.From('O').Should().Be(Color.O);
        Color.From('R').Should().Be(Color.R);
        Color.From('B').Should().Be(Color.B);
    }

    [Fact]
    public void Check_Char_To_Color_Conversion_Throws_Exception_When_Not_Recognised()
    {
        var act = () => Color.From('Z');
        
        act.Should().Throw<ArgumentException>().WithMessage("Invalid color character: Z");
    }
    
    [Fact]
    public void Check_Color_HashCode()
    {
        char inputChar = 'G';
        Color color = Color.G;
        
        int colorHash = color.GetHashCode();
        int expectedHash = inputChar.GetHashCode();
        
        colorHash.Should().Be(expectedHash);
    }

    [Fact]
    public void Check_If_Implicit_Conversion_Works()
    {
        char originalChar = 'R';
        
        Color color = originalChar; 
        char resultChar = color;
        
        resultChar.Should().Be(originalChar);
    }

    [Fact]
    public void Check_Color_ToString_Method()
    {
        var color = Color.W.ToString();
        
        color.Should().Be("W");
    }
}