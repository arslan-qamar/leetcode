namespace LeetCodeSolutions.NeetCode.Graphs.Course_Schedule
{
    public class CourseSchedule
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            Dictionary<int, List<int>> dependencyList = new Dictionary<int, List<int>>();
            HashSet<int> visited = new HashSet<int>();

            for (int i = 0; i < numCourses; i++)
            {
                dependencyList[i] = new List<int>();
            }

            foreach (var item in prerequisites)
            {
                dependencyList[item[0]].Add(item[1]);
            }


            foreach (var item in dependencyList)
            {
                if(!Dfs(item.Key))
                {
                    return false;                    
                }
            }

            return true;

            bool Dfs(int node)
            {
                if(dependencyList[node].Count == 0)
                {
                    return true;
                }

                if(visited.Contains(node))
                {
                    return false;
                }


                visited.Add(node);

                foreach (var dep in dependencyList[node])
                {
                    if(!Dfs(dep))
                    {
                        return false;
                    }    
                }

                visited.Remove(node);
                dependencyList[node] = new List<int>();
                return true;

            }

           
        }

    }
}
