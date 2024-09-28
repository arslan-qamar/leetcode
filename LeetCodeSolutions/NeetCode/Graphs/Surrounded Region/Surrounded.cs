namespace LeetCodeSolutions.NeetCode.Graphs.Surrounded_Region
{
    public class Surrounded
    {
        public void Solve(char[][] board)
        {

            for (int r = 0; r < board.Length; r++)
            {
                for (int c = 0; c < board[0].Length; c++)
                {

                    if (board[r][c] == 'O' && (r == 0 || r == board.Length - 1 || c == 0 || c == board[0].Length - 1))
                    {
                        Dfs(r, c);
                    }
                }
            }

            for (int r = 0; r < board.Length; r++)
            {
                for (int c = 0; c < board[0].Length; c++)
                {

                    if (board[r][c] == 'O')
                    {
                        board[r][c] = 'X';
                    }
                }
            }

            for (int r = 0; r < board.Length; r++)
            {
                for (int c = 0; c < board[0].Length; c++)
                {

                    if (board[r][c] == 'T')
                    {
                        board[r][c] = 'O';
                    }
                }
            }


            void Dfs(int row, int col)
            {
                if(row < 0 || row >= board.Length || col < 0 || col >= board[0].Length || board[row][col] != 'O')
                {
                    return;
                }

                
                board[row][col] = 'T';                    
                

                Dfs(row + 1, col);
                Dfs(row - 1, col);
                Dfs(row, col + 1);
                Dfs(row, col - 1);                
            }
        }
    }
}
