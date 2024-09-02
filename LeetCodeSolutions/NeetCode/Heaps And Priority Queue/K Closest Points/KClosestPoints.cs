namespace K_Closest_Points
{
    public class KClosestPoints
    {
        public static int[][] KClosest(int[][] points, int k)
        {
            int x2 = 0, y2 = 0;

            PriorityQueue<(int, int), double> minDistanceHeap = new PriorityQueue<(int, int), double>();

            for (int i = 0; i < points.Length; i++)
            {
                int x1 = points[i][0];
                int y1 = points[i][1];

                double distance = Math.Sqrt(Math.Pow((x1 - x2), 2.0) + Math.Pow((y1 - y2), 2));

                minDistanceHeap.Enqueue((x1, y1), -distance);
                if(minDistanceHeap.Count > k)
                {
                    minDistanceHeap.Dequeue();
                }
            }

            int[][] result = new int[minDistanceHeap.Count][];

            int returnCount = minDistanceHeap.Count;

            for (int i = 0; i < returnCount; i++)
            {
                (int x1, int y1) point =  minDistanceHeap.Dequeue();
                result[i] = new int[2];
                result[i][0] = point.x1;
                result[i][1] = point.y1;
            }

            return result;
        }

    }
}
