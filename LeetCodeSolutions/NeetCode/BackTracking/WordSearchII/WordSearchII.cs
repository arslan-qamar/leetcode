
namespace LeetCodeSolutions.NeetCode.BackTracking.WordSearchII
{
    public class WordSearchII
    {
        public List<string> FindWords(char[][] board, string[] words)
        {

            List<string> result = new List<string>();
            foreach (var w in words)
            {
                if (Exist(board, w))
                {
                    result.Add(w);
                }
            }

            return result;

        }

        public bool Exist(char[][] board, string word)
        {

            HashSet<(int row, int col)> visited = new HashSet<(int row, int col)>();

            for (int r = 0; r < board.Length; r++)
            {
                for (int c = 0; c < board[0].Length; c++)
                {

                    if (word[0] == board[r][c])
                    {
                        visited.Clear();
                        if(Dfs(r, c))
                        { return true; }
                    }

                }
            }

            bool Dfs(int r, int c, int index = 0)
            {
                if(index == word.Length)
                {
                    return true;
                }

                if (
                    r >= board.Length || r < 0 || c >= board[0].Length || c < 0 ||
                    board[r][c] != word[index] || visited.Contains((r, c))
                   )
                {
                    return false;
                }

                visited.Add((r, c));

                
                bool result =    Dfs(r + 1, c, index + 1) ||
                    Dfs(r - 1, c, index + 1) ||
                    Dfs(r, c + 1, index + 1) ||
                    Dfs(r, c - 1, index + 1);

                visited.Remove((r, c));

                return result;


            }

            return false;
        }

        
    }
}
