namespace LeetCodeSolutions.NeetCode.Sudoku_Validator
{
    public class SudokuValidator
    {
        public static bool IsValidSudoku(char[][] board)
        {

            return validateRows(board) && validateColumns(board) && validateSubBoxes(board);

        }

        public static bool validateRows(char[][] board)
        {
            HashSet<int> duplicateSet = new HashSet<int>();
            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    char c = board[row][col];
                    if (Char.IsDigit(c))
                    {
                        int number = int.Parse(c.ToString());

                        if (number < 1 || number > 9)
                            return false;

                        if (duplicateSet.Contains(number))
                        {
                            // Duplicate digit found in row
                            return false;
                        }

                        duplicateSet.Add(number);
                    }
                }

                // Reset for next row checking
                duplicateSet.Clear();
            }

            return true;
        }

        public static bool validateColumns(char[][] board)
        {
            HashSet<int> duplicateSet = new HashSet<int>();
            for (int col = 0; col < board.Length; col++)
            {
                for (int row = 0; row < board[col].Length; row++)
                {
                    char c = board[row][col];
                    if (Char.IsDigit(c))
                    {
                        int number = int.Parse(c.ToString());

                        if (number < 1 || number > 9)
                            return false;

                        if (duplicateSet.Contains(number))
                        {
                            // Duplicate digit found in col
                            return false;
                        }

                        duplicateSet.Add(number);
                    }
                }

                // Reset for next row checking
                duplicateSet.Clear();
            }

            return true;
        }

        public static bool validateSubBoxes(char[][] board)
        {

            HashSet<int>[,] hashSets = new HashSet<int>[3, 3];

            HashSet<int> duplicateSet;

            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    char c = board[row][col];

                    if (hashSets[row / 3, col / 3] == null)
                    {
                        hashSets[row / 3, col / 3] = new HashSet<int>();
                    }

                    duplicateSet = hashSets[row / 3, col / 3];

                    if (Char.IsDigit(c))
                    {
                        int number = int.Parse(c.ToString());

                        if (number < 1 || number > 9)
                            return false;

                        if (duplicateSet.Contains(number))
                        {
                            // Duplicate digit found in sub box
                            return false;
                        }

                        duplicateSet.Add(number);
                    }
                }
            }
            return true;
        }
    }
}
