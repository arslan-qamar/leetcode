
namespace LeetCodeSolutions.NeetCode.Graphs.Course_Schedule_II
{
    public class CourseScheduleOrder
    {
        public int[] FindOrder(int numCourses, int[][] prerequisites)
        {
            List<int> result = new List<int>();

            HashSet<int> visited = new HashSet<int>();
            Dictionary<int, List<int>> adjList = new Dictionary<int, List<int>>();

            for (int i = 0; i < numCourses; i++)
            {
                adjList[i] = new List<int>();
            }

            foreach (var item in prerequisites)
            {
                adjList[item[0]].Add(item[1]);
            }

            foreach (var item in adjList)
            {
                if(item.Value.Count == 0)
                {
                    result.Add(item.Key);
                }
            }

            for (int i = 0; i < numCourses; i++)
            {
                if (!Dfs(i))
                {
                    return new int[0];
                }
            }

            bool Dfs(int i)
            {
                if (adjList[i].Count == 0)
                {
                    return true;
                }

                if(visited.Contains(i))
                {
                    return false;
                }

                visited.Add(i);                

                foreach (var item in adjList[i])
                {
                    if(!Dfs(item))
                    {
                        return false;
                    }
                }

                visited.Remove(i);
                adjList[i] = new List<int>();
                result.Add(i);
                return true;
            }


            return result.ToArray();
        }        
    }
}
