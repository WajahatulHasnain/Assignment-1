using System;

class Program
{
    static void Main()
    {
        // Initialize a 3x3x3 matrix
        int[,,] matrix = new int[3, 3, 3];
        int diagonalSum = 0;

        // Prompt user for matrix values
        Console.WriteLine("Please enter the values for a 3x3x3 matrix:");

        for (int depth = 0; depth < 3; depth++) 
        {
            for (int row = 0; row < 3; row++) 
            {
                for (int column = 0; column < 3; column++) 
                {
                    Console.Write($"Enter value for matrix[{depth},{row},{column}]: ");
                    matrix[depth, row, column] = int.Parse(Console.ReadLine());
                }
            }
        }

        // Calculate the sum of the diagonal elements
        for (int i = 0; i < 3; i++)
        {
            diagonalSum += matrix[i, i, i];
        }

        Console.WriteLine($"The total sum of the main diagonal is: {diagonalSum}");
    }
}
