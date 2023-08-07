using System;

class ConnectedArea
{
    static int width;
    static int height;
    static char[,] matrix;
    static bool[,] visited;
    static void Main()
    {
        ReadMatrix();
        visited = new bool[height, width];
        int maxSize = 0;
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < width; col++)
            {
                int areaSize = FindArea(row, col);
                maxSize = Math.Max(maxSize, areaSize);
            }
        }

        Console.WriteLine($"The largest connected area of the matrix is: {maxSize}");
    }

    private static int FindArea(int row, int col)
    {
        if (row >= height || row < 0 || col >= width || col < 0)
        {
            return 0;
        }
        else if (visited[row, col])
        {
            return 0;
        }
        else if (matrix[row, col] != '1')
        {
            return 0;
        }

        visited[row, col] = true;
        int areaSize = 1;
        areaSize += FindArea(row + 1, col);
        areaSize += FindArea(row - 1, col);
        areaSize += FindArea(row, col + 1);
        areaSize += FindArea(row, col - 1);
        return areaSize;
    }

    static void ReadMatrix()
    {
        height = int.Parse(Console.ReadLine());
        width = int.Parse(Console.ReadLine());

        matrix = new char[height, width];
        for (int row = 0; row < height; row++)
        {
            char[] rowElements = Console.ReadLine().ToCharArray();
            for (int col = 0; col < width; col++)
            {
                matrix[row, col] = rowElements[col];
            }
        }
    }
}
