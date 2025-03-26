namespace RubikCube;

public partial class RubiksCube
{
    private void RotateFaceCounterClockwise(int startX, int startY)
    {
        var temp =  Grid.Snapshot(startY, startX, 3);
        
        for (int y = 0; y < 3; y++)
        for (int x = 0; x < 3; x++)
            Grid[startY + y, startX + x] = temp[x, 2 - y];
    }

    public void ApplyFInverseMove()
    {
        RotateFaceCounterClockwise(3, 3);
        
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
         
        Grid[5, 2] = u6;
        Grid[4, 2] = u7;
        Grid[3, 2] = u8;

        Grid[6, 3] = l2;
        Grid[6, 4] = l5;
        Grid[6, 5] = l8;

        Grid[3, 6] = d2;
        Grid[4, 6] = d1;
        Grid[5, 6] = d0;

        Grid[2, 3] = r6;
        Grid[2, 4] = r3;
        Grid[2, 5] = r0;
    }

    public void ApplyRInverseMove()
    {
        RotateFaceCounterClockwise(6, 3);
        
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

        
        Grid[3, 5] = u2;
        Grid[4, 5] = u5;
        Grid[5, 5] = u8;

        Grid[6, 5] = f2;
        Grid[7, 5] = f5;
        Grid[8, 5] = f8;

        Grid[5, 9] = d2;
        Grid[4, 9] = d5;
        Grid[3, 9] = d8;

        Grid[0, 5] = b0;
        Grid[1, 5] = b3;
        Grid[2, 5] = b6;
    }

    public void ApplyUInverseMove()
    {
        RotateFaceCounterClockwise(3,0);
        
        var f0 = Grid[3, 3];
        var f1 = Grid[3, 4];
        var f2 = Grid[3, 5];

        var r0 = Grid[3, 6];
        var r1 = Grid[3, 7];
        var r2 = Grid[3, 8];

        var b0 = Grid[3, 9];
        var b1 = Grid[3, 10];
        var b2 = Grid[3, 11];

        var o0 = Grid[3, 0];
        var o1 = Grid[3, 1];
        var o2 = Grid[3, 2];
        
        Grid[3, 3] = o0;
        Grid[3, 4] = o1;
        Grid[3, 5] = o2;

        Grid[3, 0] = b0;
        Grid[3, 1] = b1;
        Grid[3, 2] = b2;

        Grid[3, 9] = r0;
        Grid[3, 10] = r1;
        Grid[3, 11] = r2;

        Grid[3, 6] = f0;
        Grid[3, 7] = f1;
        Grid[3, 8] = f2;
    }

    public void ApplyBInverseMove()
    {   
        RotateFaceCounterClockwise(9, 3);
        
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
        
        Grid[5, 8] = u2;
        Grid[4, 8] = u1;
        Grid[3, 8] = u0;

        Grid[8, 3] = r8;
        Grid[8, 4] = r5;
        Grid[8, 5] = r2;

        Grid[3, 0] = d6;
        Grid[4, 0] = d7;
        Grid[5, 0] = d8;

        Grid[0, 3] = l6;
        Grid[0, 4] = l3;
        Grid[0, 5] = l0;
    }

    public void ApplyLInverseMove()
    {
        RotateFaceCounterClockwise(0, 3); 

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

        Grid[5, 11] = u0;
        Grid[4, 11] = u3;
        Grid[3, 11] = u6;

        Grid[6, 3] = b8;
        Grid[7, 3] = b5;
        Grid[8, 3] = b2;

        Grid[3, 3] = d0;
        Grid[4, 3] = d3;
        Grid[5, 3] = d6;

        Grid[0, 3] = f0;
        Grid[1, 3] = f3;
        Grid[2, 3] = f6;
    }
    
    public void ApplyDInverseMove()
    {
        RotateFaceCounterClockwise(3, 6);
        
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
        
        Grid[5, 3] = r6;
        Grid[5, 4] = r7;
        Grid[5, 5] = r8;

        Grid[5, 6] = b6;
        Grid[5, 7] = b7;
        Grid[5, 8] = b8;

        Grid[5, 9] = l6;
        Grid[5, 10] = l7;
        Grid[5, 11] = l8;

        Grid[5, 0] = f6;
        Grid[5, 1] = f7;
        Grid[5, 2] = f8;
    }
}