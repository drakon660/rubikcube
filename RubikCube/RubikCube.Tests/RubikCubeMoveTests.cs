using FluentAssertions;

namespace RubikCube.Tests;

public class RubikCubeMoveTests
{
    [Fact]
    public void Check_If_Grid_In_Solved_View_Is_Correct()
    {
        var cube = new RubiksCube();

        cube.Grid[0, 3].Should().Be(Color.W);
        cube.Grid[0, 4].Should().Be(Color.W);
        cube.Grid[0, 5].Should().Be(Color.W);
        cube.Grid[1, 3].Should().Be(Color.W);
        cube.Grid[1, 4].Should().Be(Color.W);
        cube.Grid[1, 5].Should().Be(Color.W);
        cube.Grid[2, 3].Should().Be(Color.W);
        cube.Grid[2, 4].Should().Be(Color.W);
        cube.Grid[2, 5].Should().Be(Color.W);

        cube.Grid[3, 6].Should().Be(Color.R);
        cube.Grid[3, 7].Should().Be(Color.R);
        cube.Grid[3, 8].Should().Be(Color.R);
        cube.Grid[4, 6].Should().Be(Color.R);
        cube.Grid[4, 7].Should().Be(Color.R);
        cube.Grid[4, 8].Should().Be(Color.R);
        cube.Grid[5, 6].Should().Be(Color.R);
        cube.Grid[5, 7].Should().Be(Color.R);
        cube.Grid[5, 8].Should().Be(Color.R);

        cube.Grid[3, 3].Should().Be(Color.G);
        cube.Grid[3, 4].Should().Be(Color.G);
        cube.Grid[3, 5].Should().Be(Color.G);
        cube.Grid[4, 3].Should().Be(Color.G);
        cube.Grid[4, 4].Should().Be(Color.G);
        cube.Grid[4, 5].Should().Be(Color.G);
        cube.Grid[5, 3].Should().Be(Color.G);
        cube.Grid[5, 4].Should().Be(Color.G);
        cube.Grid[5, 5].Should().Be(Color.G);

        cube.Grid[6, 3].Should().Be(Color.Y);
        cube.Grid[6, 4].Should().Be(Color.Y);
        cube.Grid[6, 5].Should().Be(Color.Y);
        cube.Grid[7, 3].Should().Be(Color.Y);
        cube.Grid[7, 4].Should().Be(Color.Y);
        cube.Grid[7, 5].Should().Be(Color.Y);
        cube.Grid[8, 3].Should().Be(Color.Y);
        cube.Grid[8, 4].Should().Be(Color.Y);
        cube.Grid[8, 5].Should().Be(Color.Y);

        cube.Grid[3, 0].Should().Be(Color.O);
        cube.Grid[3, 1].Should().Be(Color.O);
        cube.Grid[3, 2].Should().Be(Color.O);
        cube.Grid[4, 0].Should().Be(Color.O);
        cube.Grid[4, 1].Should().Be(Color.O);
        cube.Grid[4, 2].Should().Be(Color.O);
        cube.Grid[5, 0].Should().Be(Color.O);
        cube.Grid[5, 1].Should().Be(Color.O);
        cube.Grid[5, 2].Should().Be(Color.O);

        cube.Grid[3, 9].Should().Be(Color.B);
        cube.Grid[3, 10].Should().Be(Color.B);
        cube.Grid[3, 11].Should().Be(Color.B);
        cube.Grid[4, 9].Should().Be(Color.B);
        cube.Grid[4, 10].Should().Be(Color.B);
        cube.Grid[4, 11].Should().Be(Color.B);
        cube.Grid[5, 9].Should().Be(Color.B);
        cube.Grid[5, 10].Should().Be(Color.B);
        cube.Grid[5, 11].Should().Be(Color.B);
    }
    
    [Fact]
    public void Check_If_F_Move_Is_Correct()
    {
        var cube = new RubiksCube();
        
        cube.ApplyFMove();
        
        cube.Grid[3, 6].Should().Be(Color.W);
        cube.Grid[4, 6].Should().Be(Color.W);
        cube.Grid[5, 6].Should().Be(Color.W);
                                     
        cube.Grid[6, 5].Should().Be(Color.R);
        cube.Grid[6, 4].Should().Be(Color.R);
        cube.Grid[6, 3].Should().Be(Color.R);
        
        cube.Grid[5, 2].Should().Be(Color.Y);
        cube.Grid[4, 2].Should().Be(Color.Y);
        cube.Grid[3, 2].Should().Be(Color.Y);
        
        cube.Grid[2, 3].Should().Be(Color.O);
        cube.Grid[2, 4].Should().Be(Color.O);
        cube.Grid[2, 5].Should().Be(Color.O);
    }
    
    [Fact]
    public void Check_If_R_Move_Is_Correct()
    {
        var cube = new RubiksCube();
        
        cube.ApplyRMove();
        
        cube.Grid[5, 9].Should().Be(Color.W);
        cube.Grid[4, 9].Should().Be(Color.W);
        cube.Grid[3, 9].Should().Be(Color.W);
                                     
        cube.Grid[6, 5].Should().Be(Color.B);
        cube.Grid[7, 5].Should().Be(Color.B);
        cube.Grid[8, 5].Should().Be(Color.B);
                  
        cube.Grid[3, 5].Should().Be(Color.Y);
        cube.Grid[4, 5].Should().Be(Color.Y);
        cube.Grid[5, 5].Should().Be(Color.Y);
                  
        cube.Grid[0, 5].Should().Be(Color.G);
        cube.Grid[1, 5].Should().Be(Color.G);
        cube.Grid[2, 5].Should().Be(Color.G);
    }
    
    [Fact]
    public void Check_If_U_Move_Is_Correct()
    {
        var cube = new RubiksCube();
        
        cube.ApplyUMove();
        
        cube.Grid[3, 3].Should().Be(Color.R);
        cube.Grid[3, 4].Should().Be(Color.R);
        cube.Grid[3, 5].Should().Be(Color.R);
                                     
        cube.Grid[3, 6].Should().Be(Color.B);
        cube.Grid[3, 7].Should().Be(Color.B);
        cube.Grid[3, 8].Should().Be(Color.B);
                       
        cube.Grid[3, 9].Should().Be(Color.O);
        cube.Grid[3, 10].Should().Be(Color.O);
        cube.Grid[3, 11].Should().Be(Color.O);
                       
        cube.Grid[3, 0].Should().Be(Color.G);
        cube.Grid[3, 1].Should().Be(Color.G);
        cube.Grid[3, 2].Should().Be(Color.G);
    }
    
    [Fact]
    public void Check_If_B_Move_Is_Correct()
    {
        var cube = new RubiksCube();
        
        cube.ApplyBMove();

        cube.Grid[3, 0].Should().Be(Color.W);
        cube.Grid[4, 0].Should().Be(Color.W);
        cube.Grid[5, 0].Should().Be(Color.W);
                                     
        cube.Grid[8, 3].Should().Be(Color.O);
        cube.Grid[8, 4].Should().Be(Color.O);
        cube.Grid[8, 5].Should().Be(Color.O);
                       
        cube.Grid[5, 8].Should().Be(Color.Y);
        cube.Grid[4, 8].Should().Be(Color.Y);
        cube.Grid[3, 8].Should().Be(Color.Y);
                       
        cube.Grid[0, 3].Should().Be(Color.R);
        cube.Grid[0, 4].Should().Be(Color.R);
        cube.Grid[0, 5].Should().Be(Color.R);
    }
    
    [Fact]
    public void Check_If_L_Move_Is_Correct()
    {
        var cube = new RubiksCube();
        
        cube.ApplyLMove();

        cube.Grid[3, 3].Should().Be(Color.W);
        cube.Grid[4, 3].Should().Be(Color.W);
        cube.Grid[5, 3].Should().Be(Color.W);
                                      
        cube.Grid[6, 3].Should().Be(Color.G);
        cube.Grid[7, 3].Should().Be(Color.G);
        cube.Grid[8, 3].Should().Be(Color.G);
                        
        cube.Grid[5, 11].Should().Be(Color.Y);
        cube.Grid[4, 11].Should().Be(Color.Y);
        cube.Grid[3, 11].Should().Be(Color.Y);
                        
        cube.Grid[0, 3].Should().Be(Color.B);
        cube.Grid[1, 3].Should().Be(Color.B);
        cube.Grid[2, 3].Should().Be(Color.B);
    }
    
    [Fact]
    public void Check_If_D_Move_Is_Correct()
    {
        var cube = new RubiksCube();
        
        cube.ApplyDMove();

        cube.Grid[5, 3].Should().Be(Color.O);
        cube.Grid[5, 4].Should().Be(Color.O);
        cube.Grid[5, 5].Should().Be(Color.O);
                                     
        cube.Grid[5, 6].Should().Be(Color.G);
        cube.Grid[5, 7].Should().Be(Color.G);
        cube.Grid[5, 8].Should().Be(Color.G);
                       
        cube.Grid[5, 9].Should().Be(Color.R);
        cube.Grid[5, 10].Should().Be(Color.R);
        cube.Grid[5, 11].Should().Be(Color.R);
                       
        cube.Grid[5, 0].Should().Be(Color.B);
        cube.Grid[5, 1].Should().Be(Color.B);
        cube.Grid[5, 2].Should().Be(Color.B);
    }

    [Fact]
    public void Check_If_F_Inverse_Move_Is_Correct()
    {
        var cube = new RubiksCube();
        
        cube.ApplyFInverseMove();
        
        cube.Grid[5, 2].Should().Be(Color.W);
        cube.Grid[4, 2].Should().Be(Color.W);
        cube.Grid[3, 2].Should().Be(Color.W);
                                     
        cube.Grid[6, 3].Should().Be(Color.O);
        cube.Grid[6, 4].Should().Be(Color.O);
        cube.Grid[6, 5].Should().Be(Color.O);
                       
        cube.Grid[3, 6].Should().Be(Color.Y);
        cube.Grid[4, 6].Should().Be(Color.Y);
        cube.Grid[5, 6].Should().Be(Color.Y);
                       
        cube.Grid[2, 3].Should().Be(Color.R);
        cube.Grid[2, 4].Should().Be(Color.R);
        cube.Grid[2, 5].Should().Be(Color.R);
    }
    
    [Fact]
    public void Check_If_R_Inverse_Move_Is_Correct()
    {
        var cube = new RubiksCube();
        
        cube.ApplyRInverseMove();
        
        cube.Grid[3, 5].Should().Be(Color.W);
        cube.Grid[4, 5].Should().Be(Color.W);
        cube.Grid[5, 5].Should().Be(Color.W);
                                     
        cube.Grid[6, 5].Should().Be(Color.G);
        cube.Grid[7, 5].Should().Be(Color.G);
        cube.Grid[8, 5].Should().Be(Color.G);
                       
        cube.Grid[5, 9].Should().Be(Color.Y);
        cube.Grid[4, 9].Should().Be(Color.Y);
        cube.Grid[3, 9].Should().Be(Color.Y);
                       
        cube.Grid[0, 5].Should().Be(Color.B);
        cube.Grid[1, 5].Should().Be(Color.B);
        cube.Grid[2, 5].Should().Be(Color.B);
    }
    
    [Fact]
    public void Check_If_U_Inverse_Move_Is_Correct()
    {
        var cube = new RubiksCube();
        
        cube.ApplyUInverseMove();
        
        cube.Grid[3, 3].Should().Be(Color.O);
        cube.Grid[3, 4].Should().Be(Color.O);
        cube.Grid[3, 5].Should().Be(Color.O);
                                      
        cube.Grid[3, 0].Should().Be(Color.B);
        cube.Grid[3, 1].Should().Be(Color.B);
        cube.Grid[3, 2].Should().Be(Color.B);
                   
        cube.Grid[3, 9].Should().Be(Color.R);
        cube.Grid[3, 10].Should().Be(Color.R);
        cube.Grid[3, 11].Should().Be(Color.R);
                   
        cube.Grid[3, 6].Should().Be(Color.G);
        cube.Grid[3, 7].Should().Be(Color.G);
        cube.Grid[3, 8].Should().Be(Color.G);
    }
    
    [Fact]
    public void Check_If_B_Inverse_Move_Is_Correct()
    {
        var cube = new RubiksCube();
        
        cube.ApplyBInverseMove();
        
        cube.Grid[5, 8].Should().Be(Color.W);
        cube.Grid[4, 8].Should().Be(Color.W);
        cube.Grid[3, 8].Should().Be(Color.W);
                                     
        cube.Grid[8, 3].Should().Be(Color.R);
        cube.Grid[8, 4].Should().Be(Color.R);
        cube.Grid[8, 5].Should().Be(Color.R);
                       
        cube.Grid[3, 0].Should().Be(Color.Y);
        cube.Grid[4, 0].Should().Be(Color.Y);
        cube.Grid[5, 0].Should().Be(Color.Y);
        
        cube.Grid[0, 3].Should().Be(Color.O);
        cube.Grid[0, 4].Should().Be(Color.O);
        cube.Grid[0, 5].Should().Be(Color.O);
    }
    
    [Fact]
    public void Check_If_L_Inverse_Move_Is_Correct()
    {
        var cube = new RubiksCube();
        
        cube.ApplyLInverseMove();
        
        cube.Grid[5, 11].Should().Be(Color.W);
        cube.Grid[4, 11].Should().Be(Color.W);
        cube.Grid[3, 11].Should().Be(Color.W);
                                     
        cube.Grid[6, 3].Should().Be(Color.B);
        cube.Grid[7, 3].Should().Be(Color.B);
        cube.Grid[8, 3].Should().Be(Color.B);
                       
        cube.Grid[3, 3].Should().Be(Color.Y);
        cube.Grid[4, 3].Should().Be(Color.Y);
        cube.Grid[5, 3].Should().Be(Color.Y);
                  
        cube.Grid[0, 3].Should().Be(Color.G);
        cube.Grid[1, 3].Should().Be(Color.G);
        cube.Grid[2, 3].Should().Be(Color.G);
    }
    
    [Fact]
    public void Check_If_D_Inverse_Move_Is_Correct()
    {
        var cube = new RubiksCube();
        
        cube.ApplyDInverseMove();
        
        cube.Grid[5, 3].Should().Be(Color.R);
        cube.Grid[5, 4].Should().Be(Color.R);
        cube.Grid[5, 5].Should().Be(Color.R);
                                     
        cube.Grid[5, 6].Should().Be(Color.B);
        cube.Grid[5, 7].Should().Be(Color.B);
        cube.Grid[5, 8].Should().Be(Color.B);
                       
        cube.Grid[5, 9].Should().Be(Color.O);
        cube.Grid[5, 10].Should().Be(Color.O);
        cube.Grid[5, 11].Should().Be(Color.O);
                       
        cube.Grid[5, 0].Should().Be(Color.G);
        cube.Grid[5, 1].Should().Be(Color.G);
        cube.Grid[5, 2].Should().Be(Color.G);
    }
}