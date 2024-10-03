namespace LeetCodeSolutions.NeetCode.Graphs.Ladder_Length
{
    public class LadderLengthFinder
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            int result = 1;

            if (!wordList.Contains(endWord))
            {
                return 0;
            }


            Dictionary<string, List<string>> patternWords = new Dictionary<string, List<string>>();
            wordList.Add(beginWord);
            foreach (var word in wordList)
            {
                for (int p = 0; p < word.Length; p++)
                {
                    string pattern = word.Substring(0, p) + "*" + word.Substring(p + 1);

                    if (!patternWords.ContainsKey(pattern))
                    {
                        patternWords[pattern] = new List<string>();
                    }

                    patternWords[pattern].Add(word);
                }
            }

            HashSet<string> visited = new HashSet<string>();
            Queue<string> bfsQueue = new Queue<string>();
            visited.Add(beginWord);
            bfsQueue.Enqueue(beginWord);
            

            while (bfsQueue.Count > 0)
            {
                int queueLength = bfsQueue.Count;

                for (int i = 0; i < queueLength; i++)
                {
                    string word = bfsQueue.Dequeue();

                    if (word == endWord)
                    {
                        return result;
                    }

                    for (int p = 0; p < word.Length; p++)
                    {
                        string pattern = word.Substring(0, p) + "*" + word.Substring(p + 1);

                        foreach (var w in patternWords[pattern])
                        {
                            if (!visited.Contains(w))
                            {
                                visited.Add(w);
                                bfsQueue.Enqueue(w);
                            }
                        }
                    }

                }

                result++;
            }

            return 0;
        }
    }
}