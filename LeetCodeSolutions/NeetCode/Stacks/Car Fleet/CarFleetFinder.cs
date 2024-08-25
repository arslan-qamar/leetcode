namespace Car_Fleet
{
    public class CarFleetFinder
    {
        public static int CarFleet(int target, int[] position, int[] speed)
        {
            var combined = position.Zip(speed, (p, s) => new { Position = p, Speed = s }).ToList();
            combined.Sort((c, y) => c.Position.CompareTo(y.Position));

            position = combined.Select(x => x.Position).ToArray();
            speed = combined.Select(x => x.Speed).ToArray();

            LinkedList<double> minDeque = new LinkedList<double>();

            for (int i = 0; i < position.Length; i++)
            {

                double hops = (double)(target - position[i]) / speed[i];

                while (minDeque.Count > 0 && minDeque.Last.Value <= hops)
                {
                    minDeque.RemoveLast();
                }

                minDeque.AddLast(hops);
            }

            return minDeque.Count;

        }
    }
}
