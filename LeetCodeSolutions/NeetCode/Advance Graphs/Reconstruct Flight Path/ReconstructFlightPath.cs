namespace LeetCodeSolutions.NeetCode.Advance_Graphs.Reconstruct_Flight_Path
{
    public class ReconstructFlightPath
    {
        public List<string> FindItinerary(List<List<string>> tickets)
        {
            List<string> iternary = new List<string>();            

            Dictionary<string, List<string>> adjList = new Dictionary<string, List<string>>();

            foreach (var ticket in tickets)
            {
                string from = ticket[0];
                string to = ticket[1];

                if (!adjList.ContainsKey(from))
                {
                    adjList[from] = new List<string>();
                }

                adjList[from].Add(to);
            }

            foreach (var stops in adjList)
            {
                stops.Value.Sort();
            }
            
            Dfs("JFK");

            iternary.Reverse();

            if (iternary.Count != tickets.Count + 1)
                return new List<string>();

            return iternary;


            void Dfs(string airport)
            {
                if (adjList.ContainsKey(airport))
                {

                    var dests = new List<string>(adjList[airport]);
                    while (dests.Any())
                    {
                        adjList[airport].RemoveAt(0);
                        Dfs(dests.First());
                        dests = new List<string>(adjList[airport]);
                    }

                }
                iternary.Add(airport);
            }
            
        }

    }
}
