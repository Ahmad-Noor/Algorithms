using System;

namespace Number_of_Islands
{
    class GFG
    {
        static int ROW = 5, COL = 5; 
        static bool isSafe(int[,] M, int row, int col, bool[,] visited)
        {
            return (row >= 0) && (row < ROW) && (col >= 0) && (col < COL) && (M[row, col] == 1 && !visited[row, col]);
        }
        static void DFS(int[,] M, int row,
                int col, bool[,] visited)
        {
            int[] rowNbr = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] colNbr = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };

            visited[row, col] = true;

            for (int k = 0; k < 8; ++k)
                if (isSafe(M, row + rowNbr[k], col + colNbr[k], visited))
                    DFS(M, row + rowNbr[k], col + colNbr[k], visited);
        }

        static int countIslands(int[,] M)
        {
            bool[,] visited = new bool[ROW, COL];
            int count = 0;
            for (int i = 0; i < ROW; ++i)
                for (int j = 0; j < COL; ++j)
                    if (M[i, j] == 1 && !visited[i, j])
                    {
                        DFS(M, i, j, visited);
                        ++count;
                    }
            return count;
        }

        public static void Main()
        {
            int[,] M = new int[,] { { 1, 1, 0, 0, 0 },
                                    { 0, 1, 0, 0, 1 },
                                    { 1, 0, 0, 1, 1 },
                                    { 0, 0, 0, 0, 0 },
                                    { 1, 0, 1, 0, 1 } };
            // output =5
            Console.Write("Number of islands is: " + countIslands(M));
        }
    }


}
