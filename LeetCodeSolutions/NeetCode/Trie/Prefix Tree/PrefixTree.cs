namespace LeetCodeSolutions.NeetCode.Trie
{
    public class PrefixTree
    {
        Trie root;

        public PrefixTree()
        {
            root = new Trie();
        }

        public void Insert(string word)
        {
            Trie temp = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (!temp.map.ContainsKey(word[i]))
                {
                    temp.map.Add(word[i], new Trie());
                }

                temp = temp.map[word[i]];
            }
            temp.End = true;
        }

        public bool Search(string word)
        {
            Trie temp = root;
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

            Trie temp = root;
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

        public Trie SearchLastMatchingNode(string prefix)
        {
            Trie temp = root;
            for (int i = 0; i < prefix.Length; i++)
            {

                if (!temp.map.ContainsKey(prefix[i]))
                {
                    return temp;
                }

                temp = temp.map[prefix[i]];

            }

            return temp;
        }

        public void FindAllWords(Trie node, string word, List<string> words)
        {

            if (node == null)
            {
                return;
            }

            if (node.End)
            {
                words.Add(word);
            }

            foreach (var val in node.map)
            {
                FindAllWords(val.Value, word + val.Key, words);
            }
        }
    }
}
