namespace Extras.Test_1
{
    public class ServerLogs
    {

        public static List<int> getStaleServerCount(int n, List<List<int>> log_data, List<int> query, int X)
        {
            List<int> result = [];

            foreach (int q in query)
            {
                int startTime = q - X;
                int endTime = q;

                Dictionary<int, int> activeServers = [];
                for (int i = 0; i < log_data.Count; i++)
                {

                    int serverId = log_data[i][0];
                    int time = log_data[i][1];

                    if (time >= startTime && time <= endTime)
                    {
                        activeServers[serverId] = serverId;
                    }
                }

                result.Add(n - activeServers.Keys.Count);
            }

            return result;

        }
    }
}
