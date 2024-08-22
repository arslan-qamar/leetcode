namespace Duplicate_Integer
{
    public class DuplicateInteger
    {
        public static bool HasDuplicates(int[] numbers)
        {
            HashSet<int> duplicates = new HashSet<int>();

            if (numbers.Length == 0 || numbers == null)
            {
                return false;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = numbers[i];
                if (duplicates.Contains(number))
                {
                    return true;
                }
                else
                {
                    duplicates.Add(number);
                }
            }

            return false;
        }

    }
}
