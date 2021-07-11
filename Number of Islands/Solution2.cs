//using System;

//namespace Number_of_Islands
//{

//    class Solution2
//    {
//        static public int number_of_Islands(int[][] grid)
//        {
//            if (grid == null || grid.Length == 0) return 0;

//            int numIslands = 0;
//            for (int i = 0; i < grid.Length; i++)
//            {
//                for (int j = 0; j < grid[i].Length; j++)
//                {
//                    if (grid[i][j] == 1)
//                    {
//                        numIslands += dfs(grid, i, j);
//                    }
//                }
//            }
//            return numIslands;
//        }

//        private static int dfs(int[][] grid, int i, int j)
//        {
//            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == 0) return 0;

//            grid[i][j] = 0;
//            dfs(grid, i + 1, j);
//            dfs(grid, i - 1, j);

//            dfs(grid, i, j + 1);
//            dfs(grid, i, j - 1);
//            return 1;
//        }

//        public static void Main()
//        {


//            int[][] M = new int[][]{new int[] { 1, 1, 0, 0, 0 },
//                                    new int[] { 0, 1, 0, 0, 1 },
//                                    new int[] { 1, 0, 0, 1, 1 },
//                                    new int[] { 0, 0, 0, 0, 0 },
//                                    new int[] { 1, 0, 1, 0, 1 } };
//            //Output: 5
//            Console.Write("Number of islands is: " + number_of_Islands(M));
//        }

//    }
//}
