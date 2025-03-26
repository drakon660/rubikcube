namespace RubikCube;

public static class TwoDimensionArrayExtension
{
    public static T[,] Snapshot<T>(this T[,] array, int startY, int startX, int length)
    {
        var snapshot = new T[length, length];
        
        for (int y = 0; y < length; y++)
        for (int x = 0; x < length; x++)
            snapshot[y, x] = array[startY + y, startX + x];

        return snapshot;
    }
    
    public static T[,] Snapshot<T>(this T[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        var snapshot = new T[rows, cols];

        for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            snapshot[i, j] = array[i, j];

        return snapshot;
    }
}