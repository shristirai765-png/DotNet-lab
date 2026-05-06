// using System.Data;

// class MatrixMultiply
// {
//     static int multiply(int[,] m1, int[,] m2)
//     {
//         int[,] resultMatrix = new int[rows , columns];
//         int m1Rows = m1.GetLength(0);
//         int m1Columns = m1.GetLength(1);
//         int m2Rows = m2.GetLength(0);
//         int m2Columns = m2.GetLength(1);
//         if (m1Columns == m2Rows)
//         {
//             for(int i = 1; i < m1Rows; i++)
//             {
//                 for(int j = 1; j < m1Columns; j++)
//                 {
//                     resultMatrix[i,j] = (m1[i, j] * m2[i,j]) + (m1[i,j+1]*m2[i+1,j]) ;
//                 }
//             }
//             return resultMatrix;
//         }
        
//     }
//     public static void invoke()
//     {
//         int[,] matrix1 = { 
//             { 1, 2 }, 
//             { 4, 5 } 
//         };
//         int[,] matrix2 = { 
//             { 6 }, 
//             { 1 }
//         };
//         int[,] result = {multiply( matrix1, matrix2 )};
//     }
// }