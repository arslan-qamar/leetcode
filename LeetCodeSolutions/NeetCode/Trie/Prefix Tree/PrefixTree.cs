namespace LeetCodeSolutions.NeetCode.Trie
{
    public class PrefixTree
    {
        public class TrieNode
        {
            public bool End = false;

            public Dictionary<char, TrieNode> map = new Dictionary<char, TrieNode>();
        }

        TrieNode root;

        public PrefixTree()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode temp = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (!temp.map.ContainsKey(word[i]))
                {
                    temp.map.Add(word[i], new TrieNode());
                }

                temp = temp.map[word[i]];
            }
            temp.End = true;
        }

        public bool Search(string word)
        {
            TrieNode temp = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (!temp.map.ContainsKey(word[i]))
                {
                    return false;
                }

                temp = temp.map[word[i]];
            }

            return temp.End;
        }

        public bool StartsWith(string prefix)
        {

            TrieNode temp = root;
            for (int i = 0; i < prefix.Length; i++)
            {
                if (!temp.map.ContainsKey(prefix[i]))
                {
                    return false;
                }

                temp = temp.map[prefix[i]];
            }

            return true;

        }
    }
}
