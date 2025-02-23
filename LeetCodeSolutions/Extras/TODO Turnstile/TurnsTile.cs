namespace Extras.Test_3
{
    public class TurnsTile
    {

        public static List<int> getTimes(List<int> time, List<int> direction)
        {
            List<int> times = [];

            int[] result = new int[time.Count];

            PriorityQueue<(int time, int Direction, int Index), int> entryQueue = new PriorityQueue<(int time, int Direction, int Index), int>();
            PriorityQueue<(int time, int Direction, int Index), int> exitQueue = new PriorityQueue<(int time, int Direction, int Index), int>();

            //Create P.Queues with index  
            for (int i = 0; i < time.Count; i++)
            {
                if (direction[i] == 0)
                {
                    entryQueue.Enqueue((time[i], direction[i], i), time[i]);
                }
                else
                {
                    exitQueue.Enqueue((time[i], direction[i], i), time[i]);
                }
            }

            (int LastTime, int LastDirection) lastState = (-1, -1);
            int currTime = -1;

            while (entryQueue.Count > 0 && exitQueue.Count > 0)
            {
                currTime++;

                (int time, int Direction, int Index) entryPerson = entryQueue.Peek();
                (int time, int Direction, int Index) exitPerson = exitQueue.Peek();

                if (entryPerson.time <= currTime && exitPerson.time <= currTime)
                {


                }
                else
                {

                }

                // When both want to enter and exit
                if (exitPerson.time == entryPerson.time)
                {
                    // Not used , or was used way before
                    if (lastState.LastTime == -1 || lastState.LastTime < currTime - 1)
                    {
                        exitQueue.Dequeue();
                        result[exitPerson.Index] = currTime;
                        lastState.LastTime = currTime;
                        continue;
                    }


                    if (lastState.LastTime == currTime - 1 && lastState.LastDirection == 1)
                    {
                        exitQueue.Dequeue();
                        result[exitPerson.Index] = currTime;
                        lastState.LastTime = currTime;
                        continue;
                    }

                    if (lastState.LastTime == currTime - 1 && lastState.LastDirection == 0)
                    {
                        entryQueue.Dequeue();
                        result[entryPerson.Index] = currTime;
                        lastState.LastTime = currTime;
                        continue;
                    }
                }
                else
                {
                    if (lastState.LastDirection == 1 && entryPerson.time < exitPerson.time)
                    {
                        entryQueue.Dequeue();
                        result[entryPerson.Index] = currTime;
                        lastState.LastTime = currTime;
                        continue;
                    }
                    else
                    {
                        exitQueue.Dequeue();
                        result[exitPerson.Index] = currTime;
                        lastState.LastTime = currTime;
                        continue;
                    }
                }

            }

            while (entryQueue.Count > 0)
            {
                (int time, int Direction, int Index) entryPerson = entryQueue.Peek();
                entryQueue.Dequeue();
                result[entryPerson.Index] = currTime;
                lastState.LastTime = currTime;
                continue;
            }


            while (exitQueue.Count > 0)
            {
                (int time, int Direction, int Index) exitPerson = exitQueue.Peek();
                exitQueue.Dequeue();
                result[exitPerson.Index] = currTime;
                lastState.LastTime = currTime;
                continue;
            }

            return new List<int>(result);
        }

        public static List<int> getTimes2(List<int> time, List<int> direction)
        {
            int n = time.Count;
            int[] result = new int[n];
            Queue<int> entryQueue = new Queue<int>();
            Queue<int> exitQueue = new Queue<int>();

            int currentTime = 0;
            int lastUsedDirection = -1;

            int index = 0;

            while (index < n || entryQueue.Count > 0 || exitQueue.Count > 0)
            {
                while (index < n && time[index] <= currentTime)
                {
                    if (direction[index] == 0)
                        entryQueue.Enqueue(index);
                    else
                        exitQueue.Enqueue(index);
                    index++;
                }

                if (exitQueue.Count > 0 && (entryQueue.Count == 0 || lastUsedDirection == 1 || lastUsedDirection == -1))
                {
                    int nextExit = exitQueue.Dequeue();
                    result[nextExit] = currentTime;
                    lastUsedDirection = 1;
                }
                else if (entryQueue.Count > 0)
                {
                    int nextEntry = entryQueue.Dequeue();
                    result[nextEntry] = currentTime;
                    lastUsedDirection = 0;
                }
                else
                {
                    currentTime = time[index];
                    continue;
                }

                currentTime++;
            }

            return result.ToList();
        }

    }
}
