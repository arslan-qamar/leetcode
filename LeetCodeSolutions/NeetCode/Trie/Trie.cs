namespace LeetCodeSolutions.NeetCode.Trie
{
    public class Trie
    {
        public bool End = false;

        public Dictionary<char, Trie> map = new Dictionary<char, Trie>();
    }
}
