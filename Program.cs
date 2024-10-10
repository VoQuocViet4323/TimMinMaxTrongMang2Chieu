internal class Program
{
     private static void Main(string[] args)
    {
        double[,] matrix = {
            { 9.6, 3.8, 7.2 },
            { 4.3, 2.5, 1.7 },
            { 6.4, 5.9, 3.1 }
        };
        double max = matrix[0, 0];
        int row = 0, col = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++) 
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    row = i;
                    col = j;
                }
            }
        }
        Console.WriteLine($"Phần tử lớn nhất là {max} tại tọa độ ({row}, {col})");
    }
}