namespace LeetCodeSolutions.NeetCode.BackTracking.N_Queen
{
    public class NQueenBackTracking
    {
        public List<List<string>> SolveNQueens(int n)
        {
            List<List<string>> result = new List<List<string>>();

            HashSet<int> colOccupied = new HashSet<int>();
            HashSet<int> posDiagonalOccupied = new HashSet<int>();
            HashSet<int> negDiagonalOccupied = new HashSet<int>();

            char[][] board = new char[n][];

            for (int i = 0; i < n; i++)
            {
                board[i] = new char[n];
                Array.Fill(board[i], '.');
            }


            Dfs();

            void Dfs(int row = 0)
            {
                if(row == n)
                {
                    result.Add(CreateBoardCopy(board));
                    return;
                }

                for (int col = 0; col < board[row].Length; col++)
                {

                    if(colOccupied.Contains(col) || posDiagonalOccupied.Contains(row + col) || negDiagonalOccupied.Contains(row - col))
                    {
                        continue;
                    }


                    board[row][col] = 'Q';
                    colOccupied.Add(col);
                    posDiagonalOccupied.Add(row + col);
                    negDiagonalOccupied.Add(row - col);

                    Dfs(row + 1);


                    board[row][col] = '.';
                    colOccupied.Remove(col);
                    posDiagonalOccupied.Remove(row + col);
                    negDiagonalOccupied.Remove(row - col);

                }


            }


            return result;
        }

        private List<string> CreateBoardCopy(char[][] board)
        {
            List<string> boardCopy = new List<string>();

            for (int r = 0; r < board.Length; r++)
            {
                boardCopy.Add(String.Concat(board[r]));
            }
            return boardCopy;
        }
    }
}
