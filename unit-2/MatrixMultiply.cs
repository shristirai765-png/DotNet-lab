using System.Data;

class MatrixMultiply
{
    static int[,] multiply(int[,] m1, int[,] m2)
    {
        int m1Rows = m1.GetLength(0);
        int m1Columns = m1.GetLength(1);
        // int m2Rows = m2.GetLength(0);
        int m2Columns = m2.GetLength(1);
        int[,] resultMatrix = new int[m1Rows , m2Columns];
        
        for(int i = 0; i < m1Rows; i++)
        {
            for(int j = 0; j < m2Columns; j++)
            {
                for(int k = 0; k<m1Columns; k++)
                {
                    resultMatrix[i,j] += (m1[i, k] * m2[k,j])  ;
                }
            }
        }
        return resultMatrix;
        
    }
    public static void invoke()
    {
        int[,] matrix1 = { 
            { 1, 2 }, 
            { 4, 5 } 
        };
        int[,] matrix2 = { 
            { 6, 5 }, 
            { 1, 0}
        };
        int[,] result = multiply( matrix1, matrix2 );
        // foreach(int r in result)
        // {
        //     Console.Write(" "+ r);
        // }

        for (int i = 0; i < result.GetLength(0); i++)
        {
            Console.Write("| "); 
            for (int j = 0; j < result.GetLength(1); j++) 
            {
                Console.Write($"{result[i, j], 4} "); 
            }
            Console.WriteLine(" |");
        }
    }
}