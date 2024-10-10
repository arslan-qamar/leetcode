namespace LeetCodeSolutions.NeetCode.Advance_Graphs.Alien_Dictionary
{
    public class AlienDictionary
    {
        public string foreignDictionary(string[] words)
        {
            List<char> result = new List<char>();
            Dictionary<char, List<char>> adjList = new Dictionary<char, List<char>>();

            foreach (var word in words)
            {
                foreach (var c in word)
                {
                    if(!adjList.ContainsKey(c))
                    {
                        adjList[c] = new List<char>();
                    }
                }
            }

            for (int i = 0; i < words.Length-1; i++)
            {
                string w1 = words[i];
                string w2 = words[i+1];

                int minLength = Math.Min(w1.Length, w2.Length);

                if(w1.Length > w2.Length && w1.Substring(0,minLength) == w2.Substring(0, minLength))
                {
                    return "";
                }

                for (int j = 0; j < minLength; j++)
                {
                    if (w1[j] != w2[j])
                    {
                        adjList[w1[j]].Add(w2[j]);
                        break;
                    }
                }
            }


            Dictionary<char, bool> visited = new Dictionary<char, bool>();
           

            foreach (var c in adjList)
            {
                if(Dfs(c.Key))
                {
                    return "";
                }

            }

            bool Dfs(char c)
            {
                if(visited.ContainsKey(c))
                {
                    return visited[c];
                }

                visited[c] = true;

                foreach (var nei in adjList[c])
                {
                    
                    if(Dfs(nei))
                    {
                        return true;
                    }
                }

                visited[c] = false;
                result.Add(c);
                return false;
            }


            result.Reverse();
            return new string(result.ToArray());
        }
    }
}
