namespace RubikCube;

public partial class RubiksCube
{
    private void RotateFaceClockwise(int startX, int startY)
    {
       var temp =  Grid.Snapshot(startY, startX, 3);
        
        for (int y = 0; y < 3; y++)
        for (int x = 0; x < 3; x++)
            Grid[startY + y, startX + x] = temp[2 - x, y];
    }
    
    public void ApplyFMove()
    {
        RotateFaceClockwise(3, 3);
        
        var u6 = Grid[2, 3];
        var u7 = Grid[2, 4];
        var u8 = Grid[2, 5];

        var r0 = Grid[3, 6];
        var r3 = Grid[4, 6];
        var r6 = Grid[5, 6];

        var d0 = Grid[6, 3];
        var d1 = Grid[6, 4];
        var d2 = Grid[6, 5];

        var l8 = Grid[5, 2];
        var l5 = Grid[4, 2];
        var l2 = Grid[3, 2];

        Grid[3, 6] = u6;
        Grid[4, 6] = u7;
        Grid[5, 6] = u8;

        Grid[6, 5] = r0;
        Grid[6, 4] = r3;
        Grid[6, 3] = r6;

        Grid[5, 2] = d2;
        Grid[4, 2] = d1;
        Grid[3, 2] = d0;

        Grid[2, 3] = l8;
        Grid[2, 4] = l5;
        Grid[2, 5] = l2;
    }
    
    public void ApplyRMove()
    {
        RotateFaceClockwise(6, 3);
        
        var u2 = Grid[0, 5];
        var u5 = Grid[1, 5];
        var u8 = Grid[2, 5];
    
        var f2 = Grid[3, 5];
        var f5 = Grid[4, 5];
        var f8 = Grid[5, 5];
    
        var d2 = Grid[6, 5];
        var d5 = Grid[7, 5];
        var d8 = Grid[8, 5];
    
        var b0 = Grid[5, 9];
        var b3 = Grid[4, 9];
        var b6 = Grid[3, 9];
    
        Grid[5, 9] = u2;
        Grid[4, 9] = u5;
        Grid[3, 9] = u8;
    
        Grid[6, 5] = b0;
        Grid[7, 5] = b3;
        Grid[8, 5] = b6;
    
        Grid[3, 5] = d2;
        Grid[4, 5] = d5;
        Grid[5, 5] = d8;
    
        Grid[0, 5] = f2;
        Grid[1, 5] = f5;
        Grid[2, 5] = f8;
    }
    
    public void ApplyUMove()
    {
        RotateFaceClockwise(3,0);
        
        var f0 = Grid[3, 3];
        var f1 = Grid[3, 4];
        var f2 = Grid[3, 5];
    
        var r0 = Grid[3,6];
        var r1 = Grid[3,7];
        var r2 = Grid[3,8];
        
        var b0 = Grid[3,9];
        var b1 = Grid[3,10];
        var b2 = Grid[3,11];
        
        var l0 = Grid[3,0];
        var l1 = Grid[3,1];
        var l2 = Grid[3,2];
    
        Grid[3, 3] = r0;
        Grid[3, 4] = r1;
        Grid[3, 5] = r2;
        
        Grid[3, 6] = b0;
        Grid[3, 7] = b1;
        Grid[3, 8] = b2;
        
        Grid[3, 9] = l0;
        Grid[3, 10] = l1;
        Grid[3, 11] = l2;
        
        Grid[3, 0] = f0;
        Grid[3, 1] = f1;
        Grid[3, 2] = f2;
    }
    
    public void ApplyBMove()
    {
        RotateFaceClockwise(9, 3);
        
        var u0 = Grid[0, 3];
        var u1 = Grid[0, 4];
        var u2 = Grid[0, 5];
    
        var r8 = Grid[5, 8];
        var r5 = Grid[4, 8];
        var r2 = Grid[3, 8];
    
        var d6 = Grid[8, 3];
        var d7 = Grid[8, 4];
        var d8 = Grid[8, 5];
    
        var l0 = Grid[3, 0];
        var l3 = Grid[4, 0];
        var l6 = Grid[5, 0];
        
        Grid[3, 0] = u2;
        Grid[4, 0] = u1;
        Grid[5, 0] = u0;
    
        Grid[8, 3] = l0;
        Grid[8, 4] = l3;
        Grid[8, 5] = l6;
    
        Grid[5, 8] = d6;
        Grid[4, 8] = d7;
        Grid[3, 8] = d8;
    
        Grid[0, 3] = r2;
        Grid[0, 4] = r5;
        Grid[0, 5] = r8;
    }
    
    public void ApplyLMove()
    {
        RotateFaceClockwise(0, 3);
    
        var u0 = Grid[0, 3];
        var u3 = Grid[1, 3];
        var u6 = Grid[2, 3];
        
        var f0 = Grid[3, 3];
        var f3 = Grid[4, 3];
        var f6 = Grid[5, 3];
        
        var d0 = Grid[6, 3];
        var d3 = Grid[7, 3];
        var d6 = Grid[8, 3];
        
        var b8 = Grid[5, 11];
        var b5 = Grid[4, 11];
        var b2 = Grid[3, 11];
    
        Grid[3, 3] = u0;
        Grid[4, 3] = u3;
        Grid[5, 3] = u6;
    
        Grid[6, 3] = f0;
        Grid[7, 3] = f3;
        Grid[8, 3] = f6;
    
        Grid[5, 11] = d0;
        Grid[4, 11] = d3;
        Grid[3, 11] = d6;
    
        Grid[0, 3] = b8;
        Grid[1, 3] = b5;
        Grid[2, 3] = b2;
    }
    
    public void ApplyDMove()
    {
        RotateFaceClockwise(3, 6); 
    
        var f6 = Grid[5, 3];
        var f7 = Grid[5, 4];
        var f8 = Grid[5, 5];
    
        var r6 = Grid[5, 6];
        var r7 = Grid[5, 7];
        var r8 = Grid[5, 8];
    
        var b6 = Grid[5, 9];
        var b7 = Grid[5, 10];
        var b8 = Grid[5, 11];
    
        var l6 = Grid[5, 0];
        var l7 = Grid[5, 1];
        var l8 = Grid[5, 2];
    
        Grid[5, 3] = l6;
        Grid[5, 4] = l7;
        Grid[5, 5] = l8;
    
        Grid[5, 6] = f6;
        Grid[5, 7] = f7;
        Grid[5, 8] = f8;
    
        Grid[5, 9] = r6;
        Grid[5, 10] = r7;
        Grid[5, 11] = r8;
    
        Grid[5, 0] = b6;
        Grid[5, 1] = b7;
        Grid[5, 2] = b8;
    }
}