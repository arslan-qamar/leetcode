namespace LeetCodeSolutions.NeetCode.Trie.Word_Dictionary
{
    public class WordDictionary
    {
        public class Trie
        {
            public bool End = false;
            public Dictionary<char, Trie> map = new Dictionary<char, Trie>();
        }

        Trie root;

        public WordDictionary()
        {
            root = new Trie();
        }

        public void AddWord(string word)
        {
            Trie temp = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (!temp.map.ContainsKey(word[i]))
                {
                    temp.map[word[i]] = new Trie();
                }

                temp = temp.map[word[i]];
            }

            temp.End = true;
        }

        public bool Search(string word)
        {
            return Dfs(0, root);

            bool Dfs(int index, Trie node)
            {
                Trie temp = node;
                for (int i = index; i < word.Length; i++)
                {                    
                    if (word[i] == '.')
                    {
                        foreach (Trie n in temp.map.Values)
                        {
                            if(n != null && Dfs(i + 1, n))
                            {
                                return true;
                            }
                        }
                        return false;
                    }
                    else
                    {

                        if (!temp.map.ContainsKey(word[i]))
                        {
                            return false;
                        }

                        temp = temp.map[word[i]];
                    }
                }

                return temp.End;
            }
        }

    }
}
