namespace LeetCodeSolutions.NeetCode.BackTracking.WordSearch
{
    public class WordSearch
    {
        public static bool Exist(char[][] board, string word)
        {

            HashSet<(int row, int col)> visited = new HashSet<(int row, int col)>();

            for (int r = 0; r < board.Length; r++)
            {
                for (int c = 0; c < board[0].Length; c++)
                {
                    visited.Clear();
                    if (board[r][c] == word[0])
                    {
                        if (Dfs(r, c, 0))
                        {
                            return true;
                        }
                    }

                }
            }

            return false;

            bool Dfs(int row, int col, int index)
            {
                if (index == word.Length)
                {
                    return true;
                }

                if (
                    row >= board.Length ||
                    row < 0 ||
                    col >= board[0].Length ||
                    col < 0 ||
                    board[row][col] != word[index] ||
                    visited.Contains((row, col))
                    )
                {
                    return false;
                }
                

                visited.Add((row, col));

                bool res = Dfs(row + 1, col, index + 1) ||
                Dfs(row - 1, col, index + 1) ||
                Dfs(row, col + 1, index + 1) ||
                Dfs(row, col - 1, index + 1);

                visited.Remove((row, col));

                return res;
            }
        }
    }
}
