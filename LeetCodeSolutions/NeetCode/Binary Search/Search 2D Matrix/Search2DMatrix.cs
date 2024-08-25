namespace Binary_Search.Search_2D_Matrix
{
    public class Search2DMatrix
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            bool result = false;

            int rows = matrix.Length;
            int cols = matrix[0].Length;

            int totalBoxes = rows * cols;
            int l = 0;
            int r = totalBoxes - 1;

            while (l <= r)
            {
                int m = l + ((r - l) / 2);
                int mx = m / cols;
                int my = m % cols;

                if (matrix[mx][my] > target)
                {
                    r = m - 1;
                }
                else if (matrix[mx][my] < target)
                {
                    l = m + 1;
                }
                else
                {
                    return true;
                }
            }

            return result;
        }

    }
}
